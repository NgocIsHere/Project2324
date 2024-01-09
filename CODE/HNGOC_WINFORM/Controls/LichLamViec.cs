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

namespace QLPHONGKHAM.Controls
{
    public partial class LichLamViec : UserControl
    {

        Connection connection;
        Util util;

        public LichLamViec()
        {
            InitializeComponent();
            connection = new Connection();
            util = new Util();
        }
        private void LichLamViec_Load(object sender, EventArgs e)
        {
            connection.connect();
            getLichLamViecList();
            lichLamViecTable.ClearSelection();
        }

        private void RefreshDataGridView()
        {
            lichLamViecTable.DataSource = connection.dataTable("EXEC SP_XEMLICHLAMVIEC");
            xoaButton.Enabled = false;
            capNhatButton.Enabled = false;
            util.ClearControl(this.InformationSection);
        }

        void getLichLamViecList()
        {
            lichLamViecTable.DefaultCellStyle.ForeColor = Color.Black;
            lichLamViecTable.DataSource = connection.dataTable("EXEC SP_XEMLICHLAMVIEC");

            //Đổi tên column
            lichLamViecTable.Columns["NHASI"].HeaderText = "ID Nha Sĩ";
            lichLamViecTable.Columns["HOTEN"].HeaderText = "Họ và tên";
            lichLamViecTable.Columns["THANG"].HeaderText = "Tháng";
            lichLamViecTable.Columns["NGAYLAMVIEC"].HeaderText = "Ngày làm việc";
        }

        private void lichLamViecTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ngaySinhBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void themButton_Click(object sender, EventArgs e)
        {
            connection.connect();
            SqlParameter[] paras =
            {
                new SqlParameter("@NHASI", SqlDbType.Char){Value = this.iDNhaSiBox.Text},
                new SqlParameter("@NGAY", SqlDbType.Date){Value = this.ngayLamViecBox.Value},
                new SqlParameter("@THOIGIAN", SqlDbType.Time){Value = this.gioLamViecBox.Value.TimeOfDay}
            };
            int statusCode = connection.ExecuteStoredProcedureWithParams("THEMLICHLAMVIEC", paras);

            if (statusCode == 0)
            {
                MessageBox.Show("THÊM LỊCH LÀM VIỆC THÀNH CÔNG");
            }
            else if (statusCode == -1)
            {
                MessageBox.Show("LỊCH LÀM VIỆC NÀY ĐÃ TỒN TẠI");
            }
            getLichLamViecList();
            lichLamViecTable.ClearSelection();
            //RefreshDataGridView();
        }


        private void InformationSection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hoVaTenBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
