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
    public partial class NhaSi : UserControl
    {

        Connection connection;
        Util util;
        public string role;
        public NhaSi()
        {
            InitializeComponent();
            connection = new Connection();
            util = new Util();

        }

        void getNhaSiList()
        {
            nhaSiTable.DefaultCellStyle.ForeColor = Color.Black;
            nhaSiTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            nhaSiTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            nhaSiTable.DataSource = connection.dataTable("EXEC SP_XEMDANHSACHNHASI");

            //Đổi tên column
            nhaSiTable.Columns["ID"].HeaderText = "ID Nha sĩ";
            nhaSiTable.Columns["HOTEN"].HeaderText = "Họ và tên";
            nhaSiTable.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            nhaSiTable.Columns["DIACHI"].HeaderText = "Địa chỉ";
            nhaSiTable.Columns["SDT"].HeaderText = "Số điện thoại";
            nhaSiTable.Columns["GIOITINH"].HeaderText = "Giới tinh";
            nhaSiTable.Columns["MATKHAU"].HeaderText = "Mật khẩu";
        }

        private void NhaSi_Load(object sender, EventArgs e)
        {
            xoaButton.Enabled = false;
            capNhatButton.Enabled = false;
            connection.connect();
            getNhaSiList();
            nhaSiTable.ClearSelection();
        }

        private void nhaSiTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            xoaButton.Enabled = true;
            capNhatButton.Enabled = true;
            DataGridViewRow row = new DataGridViewRow();
            row = nhaSiTable.Rows[e.RowIndex];

            //Match the value to the text boxes
            this.hoVaTenBox.Text = Convert.ToString(row.Cells["HOTEN"].Value);
            this.diaChiBox.Text = Convert.ToString(row.Cells["DIACHI"].Value);
            this.soDienThoaiBox.Text = Convert.ToString(row.Cells["SDT"].Value);
            this.matKhauBox.Text = Convert.ToString(row.Cells["MATKHAU"].Value);
            this.ngaySinhBox.Value = Convert.ToDateTime(row.Cells["NGAYSINH"].Value);

            string gioiTinh = Convert.ToString(row.Cells["GIOITINH"].Value);
            if (gioiTinh == "Male")
            {
                namRadioButton.Checked = true;
                nuRadioButton.Checked = false;
            }
            else if (gioiTinh == "Female")
            {
                nuRadioButton.Checked = true;
                namRadioButton.Checked = false;
            }
        }

        private void RefreshDataGridView()
        {
            nhaSiTable.DataSource = connection.dataTable("EXEC SP_XEMDANHSACHNHASI");
            xoaButton.Enabled = false;
            capNhatButton.Enabled = false;
            util.ClearControl(this.InformationSection);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Code to handle the event when the 'tableLayoutPanel1' is painted
        }

        private void themButton_Click(object sender, EventArgs e)
        {
            connection.connect();
            string gioiTinh = namRadioButton.Checked ? "Male" : "Female";
            SqlParameter[] paras =
            {
               
                new SqlParameter("@HOTEN", SqlDbType.NVarChar){Value = this.hoVaTenBox.Text},
                new SqlParameter("@NGAYSINH", SqlDbType.Date){Value = this.ngaySinhBox.Value},
                new SqlParameter("@DIACHI", SqlDbType.NVarChar){Value = this.diaChiBox.Text},
                new SqlParameter("@SDT", SqlDbType.NVarChar){Value = this.soDienThoaiBox.Text},
                new SqlParameter("@GIOITINH", SqlDbType.NVarChar){Value = gioiTinh},
                new SqlParameter("@MATKHAU", SqlDbType.NVarChar){Value = this.matKhauBox.Text}
            };
            int statusCode = connection.ExecuteStoredProcedureWithParams("SP_THEMNHASI", paras);

            if (statusCode == 0)
            {
                MessageBox.Show("THÊM NHA SĨ THÀNH CÔNG");
            }
            else if (statusCode == -1)
            {
                MessageBox.Show("NHA SĨ NÀY ĐÃ TỒN TẠI");
            }
            RefreshDataGridView();
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {
            SqlParameter[] paras =
            {
                new SqlParameter("@ID", SqlDbType.VarChar){Value = nhaSiTable.SelectedRows[0].Cells["ID"].Value}
            };

            int statusCode = connection.ExecuteStoredProcedureWithParams("SP_XOANHASI", paras);
            if (statusCode == 0)
            {
                MessageBox.Show("XÓA NHA SĨ THÀNH CÔNG");
            }
            else if (statusCode == -1)
            {
                MessageBox.Show("NHA SĨ KHÔNG TỒN TẠI");
            }
            else if (statusCode == -2)
            {
                MessageBox.Show("TỒN TẠI NHA SĨ TRONG ĐƠN. KHÔNG THỂ XÓA");
            }
            RefreshDataGridView();
        }

        private void capNhatButton_Click(object sender, EventArgs e)
        {
            string gioiTinh = namRadioButton.Checked ? "Nam" : "Nữ";
            SqlParameter[] paras =
            {
                //ID, HOTEN, NGAYSINH, DIACHI, SDT, GIOITINH, MATKHAU
                new SqlParameter("@ID", SqlDbType.VarChar){Value = nhaSiTable.SelectedRows[0].Cells["ID"].Value},
                new SqlParameter("@HOTEN", SqlDbType.NVarChar){Value = this.hoVaTenBox.Text},
                new SqlParameter("@NGAYSINH", SqlDbType.Date){Value = this.ngaySinhBox.Value},
                new SqlParameter("@DIACHI", SqlDbType.NVarChar){Value = this.diaChiBox.Text},
                new SqlParameter("@SDT", SqlDbType.NVarChar){Value = this.soDienThoaiBox.Text},
                new SqlParameter("@GIOITINH", SqlDbType.NVarChar){Value = gioiTinh},
                new SqlParameter("@MATKHAU", SqlDbType.NVarChar){Value = this.matKhauBox.Text}
            };

            int statusCode = connection.ExecuteStoredProcedureWithParams("SP_CAPNHATNHASI", paras);
            if (statusCode == 0)
            {
                MessageBox.Show("CẬP NHẬT NHA SĨ THÀNH CÔNG");
            }
            else if (statusCode == -1)
            {
                MessageBox.Show("TÊN NHA SĨ KHÔNG ĐƯỢC BỎ TRỐNG");
            }
            else if (statusCode == -2)
            {
                MessageBox.Show("ĐỊA CHỈ KHÔNG HỢP LỆ");
            }
            else if (statusCode == -3)
            {
                MessageBox.Show("SỐ ĐIỆN THOẠI KHÔNG HỢP LỆ");
            }
            else if (statusCode == -4)
            {
                MessageBox.Show("TRÙNG TÊN NHA SĨ ĐÃ CÓ");
            }
            RefreshDataGridView();
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void InformationSection_Paint(object sender, PaintEventArgs e)
        {
            // Code to handle the event when the 'InformationSection' is painted
        }
    }
}

