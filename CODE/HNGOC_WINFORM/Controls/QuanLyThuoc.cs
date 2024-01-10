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
using QLPHONGKHAM.DataSetTableAdapters;

namespace QLPHONGKHAM.Controls
{
    public partial class QuanLyThuoc : UserControl
    {
        Connection connection;
        Util util;
        public QuanLyThuoc()
        {
            InitializeComponent();
            connection = new Connection();
            util = new Util();
        }

        void getMedicineList()
        {
            thuocTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            thuocTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            thuocTable.DefaultCellStyle.ForeColor = Color.Black;
            thuocTable.DataSource = connection.dataTable("EXEC SP_XEMDSTHUOC");

            //Đổi tên column
            thuocTable.Columns["ID_THUOC"].HeaderText = "Mã Thuốc";
            thuocTable.Columns["TENTHUOC"].HeaderText = "Tên Thuốc";
            thuocTable.Columns["DONGIA"].HeaderText = "Đơn Giá";
            thuocTable.Columns["DONVI"].HeaderText = "Đơn Vị";
            thuocTable.Columns["SOLUONG"].HeaderText = "Số Lượng";
            thuocTable.Columns["HANSUDUNG"].HeaderText = "Hạn Sử Dụng";
            thuocTable.Columns["GHICHU"].HeaderText = "Ghi Chú";
            //thuocTable.DataSource = thuoc.getMedicineTable();
        }

        private void QuanLyThuoc_Load(object sender, EventArgs e)
        {
            xoaButton.Enabled = false;
            capNhatButton.Enabled = false;
            connection.connect();
            getMedicineList();
            thuocTable.ClearSelection();
        }
        private void thuocTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            capNhatButton.Enabled = true;
            xoaButton.Enabled = true;
            DataGridViewRow row = new DataGridViewRow();
            row = thuocTable.Rows[e.RowIndex];

            //Match the value to the text boxes
            this.tenThuocBox.Text = Convert.ToString(row.Cells["TENTHUOC"].Value);
            this.donGiaBox.Text = Convert.ToString(row.Cells["DONGIA"].Value);
            this.donViBox.Text = Convert.ToString(row.Cells["DONVI"].Value);
            this.soLuongBox.Text = Convert.ToString(row.Cells["SOLUONG"].Value);
            this.ghiChuBox.Text = Convert.ToString(row.Cells["GHICHU"].Value);
            this.hanSuDungBox.Value = Convert.ToDateTime(row.Cells["HANSUDUNG"].Value);
        }

        private void RefreshDataGridView()
        {
            thuocTable.DataSource = connection.dataTable("EXEC SP_XEMDSTHUOC");
            xoaButton.Enabled = false;
            capNhatButton.Enabled = false;
            util.ClearControl(this.InformationSection);
        }
        private void themButton_Click(object sender, EventArgs e)
        {
            connection.connect();
            SqlParameter[] paras =
            {
                new SqlParameter("@TENTHUOC", SqlDbType.NVarChar){Value = this.tenThuocBox.Text},
                new SqlParameter("@DONGIA", SqlDbType.Int){Value = this.donGiaBox.Text},
                new SqlParameter("@DONVI", SqlDbType.NVarChar){Value = this.donViBox.Text},
                new SqlParameter("@SOLUONG", SqlDbType.Int){Value = this.soLuongBox.Text},
                new SqlParameter("@HANSUDUNG", SqlDbType.Date){Value = this.hanSuDungBox.Value},
                new SqlParameter("@GHICHU", SqlDbType.NVarChar){Value = this.ghiChuBox.Text}
            };
            int statusCode = connection.ExecuteStoredProcedureWithParams("SP_THEMTHUOC", paras);

            if (statusCode == 0)
            {
                MessageBox.Show("THÊM THUỐC THÀNH CÔNG");
            }
            else if (statusCode == -1)
            {
                MessageBox.Show("THUỐC NÀY ĐÃ TỒN TẠI");
            }
            RefreshDataGridView();
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {
            SqlParameter[] paras =
            {
                new SqlParameter("@ID_THUOC", SqlDbType.VarChar){Value = thuocTable.SelectedRows[0].Cells["ID_THUOC"].Value}
            };
            int statusCode = connection.ExecuteStoredProcedureWithParams("SP_XOATHUOC", paras);
            if (statusCode == 0)
            {
                MessageBox.Show("XÓA THUỐC THÀNH CÔNG");
            }
            else if (statusCode == -1)
            {
                MessageBox.Show("THUỐC KHÔNG TỒN TẠI");
            }
            else if (statusCode == -2)
            {
                MessageBox.Show("TỒN TẠI THUỐC TRONG ĐƠN. KHÔNG THỂ XÓA");
            }
            RefreshDataGridView();
        }

        private void capNhatButton_Click(object sender, EventArgs e)
        {
            SqlParameter[] paras =
            {
                new SqlParameter("@ID_THUOC", SqlDbType.VarChar){Value = thuocTable.SelectedRows[0].Cells["ID_THUOC"].Value},
                new SqlParameter("@TENTHUOC", SqlDbType.NVarChar){Value = this.tenThuocBox.Text},
                new SqlParameter("@DONGIA", SqlDbType.Int){Value = this.donGiaBox.Text},
                new SqlParameter("@DONVI", SqlDbType.NVarChar){Value = this.donViBox.Text},
                new SqlParameter("@SOLUONG", SqlDbType.Int){Value = this.soLuongBox.Text},
                new SqlParameter("@HANSUDUNG", SqlDbType.Date){Value = this.hanSuDungBox.Value},
                new SqlParameter("@GHICHU", SqlDbType.NVarChar){Value = this.ghiChuBox.Text}
            };

            int statusCode = connection.ExecuteStoredProcedureWithParams("SP_CAPNHATTHUOC", paras);
            if (statusCode == 0)
            {
                MessageBox.Show("CẬP NHẬT THUỐC THÀNH CÔNG");
            }
            else if (statusCode == -1)
            {
                MessageBox.Show("TÊN THUỐC KHÔNG ĐƯỢC BỎ TRỐNG");
            }
            else if (statusCode == -2)
            {
                MessageBox.Show("ĐƠN GIÁ KHÔNG HỢP LỆ");
            }
            else if (statusCode == -3)
            {
                MessageBox.Show("SỐ LƯỢNG KHÔNG HỢP LỆ");
            }
            else if (statusCode == -4)
            {
                MessageBox.Show("TRÙNG TÊN THUỐC ĐÃ CÓ");
            }
            RefreshDataGridView();
        }

        private void searchThuocButton_Click(object sender, EventArgs e)
        {
            if (this.searchThuocBox.Text != null && this.searchThuocBox.Text != "")
            {
                connection.connect();
                SqlParameter[] paras = {
                    new SqlParameter("@TENTHUOC", SqlDbType.NVarChar) { Value = this.searchThuocBox.Text }
                };
                this.thuocTable.DataSource = connection.dataTableWithParams("SP_TIMTHUOCTHEOTEN", paras);
            }
        }
    }
}
