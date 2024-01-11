using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPHONGKHAM
{
    public partial class LichLamViec : Form
    {

        Connection connection;
        Util util;
        public string role;
        public LichLamViec()
        {
            InitializeComponent();
            connection = new Connection();
            util = new Util();
        }
        private void LichLamViec_Load(object sender, EventArgs e)
        {
            connection.connect();
            lichLamViecTable.ClearSelection();
        }

        private void themButton_Click(object sender, EventArgs e)
        {
            if (role != "qtv")
            {
                MessageBox.Show("Chỉ qtv có quyền thêm lịch làm việc");
            }
            else
            {
                connection.connect();
                SqlParameter[] paras =
                {
                new SqlParameter("@NHASI", SqlDbType.Char){Value = this.iDNhaSiBox.Text},
                new SqlParameter("@NGAY", SqlDbType.Date){Value = this.ngayLamViecBox.Value},
                new SqlParameter("@THOIGIANBATDAU", SqlDbType.Time){Value = this.gioBatDauBox.Value.TimeOfDay},
                new SqlParameter("@THOIGIANKETTHUC", SqlDbType.Time){Value = this.gioKetThucBox.Value.TimeOfDay}
            };
                int statusCode = connection.ExecuteStoredProcedureWithParams("SP_THEMLICHLAMVIEC", paras);

                if (statusCode == 0)
                {
                    MessageBox.Show("THÊM LỊCH LÀM VIỆC THÀNH CÔNG");
                }
                else if (statusCode == -1)
                {
                    MessageBox.Show("LỊCH LÀM VIỆC NÀY ĐÃ TỒN TẠI");
                }
                else if (statusCode == -2)
                {
                    MessageBox.Show("THỜI GIAN BẮT ĐẦU KHÔNG ĐƯỢC LỚN HƠN THỜI GIAN KẾT THÚC");
                }
                lichLamViecTable.ClearSelection();
            }
            
        }

        private void locButton_Click(object sender, EventArgs e)
        {
            locLichLamViec();
        }

        void locLichLamViec()
        {
            connection.connect();
            string procName = "";
            SqlParameter[] paras = null;

            lichLamViecTable.DefaultCellStyle.ForeColor = Color.Black;
            
            //Nếu có id thì lọc theo id
            if (this.idNhaSiSearchBox.Text.Length > 0)
            {
                if (ngayradioButton.Checked)
                {
                    procName = "SP_LICHLAMVIECNGAYCUANHASI";
                    paras = new SqlParameter[] {
                        new SqlParameter("@ID_NHASI", SqlDbType.Char) { Value = this.idNhaSiSearchBox.Text},
                        new SqlParameter("@StartDate", SqlDbType.Date) { Value = this.ngayBatDauTimePicker.Value },
                        new SqlParameter("@EndDate", SqlDbType.Date) { Value = this.NgayKetThucTimePicker.Value }
                    };
                }
                else if (tuanradioButton.Checked)
                {
                    procName = "SP_LICHLAMVIECTUANCUANHASI";
                    // Tính ngày đầu tuần và cuối tuần từ ngày được chọn
                    DateTime selectedDate = this.ngayBatDauTimePicker.Value;
                    DateTime startOfWeek = selectedDate.AddDays((int)DayOfWeek.Monday - (int)selectedDate.DayOfWeek);
                    DateTime endOfWeek = startOfWeek.AddDays(6);

                    paras = new SqlParameter[] {
                        new SqlParameter("@ID_NHASI", SqlDbType.Char) { Value = this.idNhaSiSearchBox.Text},
                        new SqlParameter("@StartDate", SqlDbType.Date) { Value = startOfWeek },
                        new SqlParameter("@EndDate", SqlDbType.Date) { Value = this.NgayKetThucTimePicker.Value }
                    };
                }
                else if (thangradioButton.Checked)
                {
                    procName = "SP_LICHLAMVIECTHANGCUANHASI";
                    // Lấy ngày đầu tháng và cuối tháng từ ngày được chọn
                    DateTime selectedDate = this.ngayBatDauTimePicker.Value;
                    DateTime startOfMonth = new DateTime(selectedDate.Year, selectedDate.Month, 1);
                    DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

                    paras = new SqlParameter[] {
                        new SqlParameter("@ID_NHASI", SqlDbType.Char) { Value = this.idNhaSiSearchBox.Text},
                        new SqlParameter("@StartDate", SqlDbType.Date) { Value = startOfMonth },
                        new SqlParameter("@EndDate", SqlDbType.Date) { Value = this.NgayKetThucTimePicker.Value }
                    };
                }
            }
            else
            {
                if (ngayradioButton.Checked)
                {
                    procName = "SP_XEMLICHLAMVIECNGAY";
                    paras = new SqlParameter[] {
                        new SqlParameter("@StartDate", SqlDbType.Date) { Value = this.ngayBatDauTimePicker.Value },
                        new SqlParameter("@EndDate", SqlDbType.Date) { Value = this.NgayKetThucTimePicker.Value }
                    };
                }
                else if (tuanradioButton.Checked)
                {
                    procName = "SP_XEMLICHLAMVIECTUAN";
                    // Tính ngày đầu tuần và cuối tuần từ ngày được chọn
                    DateTime selectedDate = this.ngayBatDauTimePicker.Value;
                    DateTime startOfWeek = selectedDate.AddDays((int)DayOfWeek.Monday - (int)selectedDate.DayOfWeek);
                    DateTime endOfWeek = startOfWeek.AddDays(6);

                    paras = new SqlParameter[] {
                        new SqlParameter("@StartDate", SqlDbType.Date) { Value = startOfWeek },
                        new SqlParameter("@EndDate", SqlDbType.Date) { Value = this.NgayKetThucTimePicker.Value }
                    };
                }
                else if (thangradioButton.Checked)
                {
                    procName = "SP_XEMLICHLAMVIECTHANG";
                    // Lấy ngày đầu tháng và cuối tháng từ ngày được chọn
                    DateTime selectedDate = this.ngayBatDauTimePicker.Value;
                    DateTime startOfMonth = new DateTime(selectedDate.Year, selectedDate.Month, 1);
                    DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

                    paras = new SqlParameter[] {
                        new SqlParameter("@StartDate", SqlDbType.Date) { Value = startOfMonth },
                        new SqlParameter("@EndDate", SqlDbType.Date) { Value = this.NgayKetThucTimePicker.Value }
                    };
                }
            }
            if (!string.IsNullOrEmpty(procName) && paras != null)
            {
                DataTable resultTable = connection.dataTableWithParams(procName, paras);
                lichLamViecTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                lichLamViecTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                lichLamViecTable.DataSource = resultTable;
            }
            else
            {
                MessageBox.Show("Chọn loại lịch làm việc trước");
            }

        }

        
    }
}
