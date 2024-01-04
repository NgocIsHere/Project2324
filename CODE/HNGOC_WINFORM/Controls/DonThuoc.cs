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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLPHONGKHAM.Controls
{
    public partial class DonThuoc : UserControl
    {
        Connection connection;
        Util util;

        //Shared variable
        public static string idBenhAn { get; set; }
        public static string hoTen { get; set; }
        public static string ngaySinh { get; set; }
        public static string diaChi { get; set; }
        public static string sdt { get; set; }
        public static string gioiTinh { get; set; }
        public static string thongTinTongQuan { get; set; }
        public static string tinhTrangDiUng { get; set; }
        public static string idDonThuocGlobal { get; set; }
        public static string ngayKeDon { get; set; }
        public DonThuoc()
        {
            InitializeComponent();
            connection = new Connection();
            util = new Util();
        }
        void getBenhAn()
        {
            benhNhanTable.DefaultCellStyle.ForeColor = Color.Black;
            benhNhanTable.DataSource = connection.dataTable("EXEC SP_XEMDANHSACHBENHAN");

            //Change column name
            benhNhanTable.Columns["ID"].HeaderText = "ID Bệnh án";
            benhNhanTable.Columns["HOTEN"].HeaderText = "Họ tên";
            benhNhanTable.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            benhNhanTable.Columns["DIACHI"].HeaderText = "Địa chỉ";
            benhNhanTable.Columns["SDT"].HeaderText = "Số điện thoại";
            benhNhanTable.Columns["GIOITINH"].HeaderText = "Giới tính";
            benhNhanTable.Columns["THONGTINTONGQUAN"].HeaderText = "Thông tin tổng quan";
            benhNhanTable.Columns["TINHTRANGDIUNG"].HeaderText = "Tình trạng dị ứng";
        }
        private void DonThuoc_Load(object sender, EventArgs e)
        {
            themButton.Enabled = false;
            donThuocButton.Enabled = false;
            connection.connect();
            getBenhAn();
        }

        //Them Don Thuoc
        private void TaoDonThuocMoi()
        {
            connection.connect();
            SqlParameter[] paras =
            {
                new SqlParameter("@ID_BENHAN", SqlDbType.Char){Value = DonThuoc.idBenhAn},
                new SqlParameter("@NGAYLAPDON", SqlDbType.Date){Value = Convert.ToDateTime(DonThuoc.ngayKeDon)},
                new SqlParameter("@NewIDDon", SqlDbType.VarChar, 8) { Direction = ParameterDirection.Output }
            };

            int status = connection.ExecuteStoredProcedureWithParams("SP_THEMDONTHUOC", paras);
            if (status == 0)
            {
                idDonThuocGlobal = paras[2].Value.ToString();
                MessageBox.Show("TẠO ĐƠN THÀNH CÔNG");
            }
            else
            {
                MessageBox.Show("TẠO ĐƠN KHÔNG THÀNH CÔNG");
            }
        }
        private void themButton_Click(object sender, EventArgs e)
        {
            TaoDonThuocMoi();
            TaoDonThuoc taoDonThuoc = new TaoDonThuoc();
            taoDonThuoc.ShowDialog();
        }

        private void donThuocButton_Click(object sender, EventArgs e)
        {
            DanhSachDonThuoc dsdt = new DanhSachDonThuoc();
            dsdt.ShowDialog();
        }

        private void benhNhanTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            themButton.Enabled = true;
            donThuocButton.Enabled = true;

            DataGridViewRow row = new DataGridViewRow();
            row = benhNhanTable.Rows[e.RowIndex];

            //Set global variable
            DonThuoc.hoTen = Convert.ToString(row.Cells["HOTEN"].Value);
            DonThuoc.ngaySinh = Convert.ToString(row.Cells["NGAYSINH"].Value);
            DonThuoc.diaChi = Convert.ToString(row.Cells["DIACHI"].Value);
            DonThuoc.sdt = Convert.ToString(row.Cells["SDT"].Value);
            DonThuoc.tinhTrangDiUng = Convert.ToString(row.Cells["TINHTRANGDIUNG"].Value);
            DonThuoc.thongTinTongQuan = Convert.ToString(row.Cells["THONGTINTONGQUAN"].Value);
            DonThuoc.ngayKeDon = this.ngayKeDonBox.Value.ToString();
            DonThuoc.gioiTinh = Convert.ToString(row.Cells["GIOITINH"].Value);

            //Match the value to the text boxes
            this.tenBenhNhanBox.Text = Convert.ToString(row.Cells["HOTEN"].Value);
            this.sdtBox.Text = Convert.ToString(row.Cells["SDT"].Value);
            this.diaChiBox.Text = Convert.ToString(row.Cells["DIACHI"].Value);
            this.thongTinTongQuanBox.Text = Convert.ToString(row.Cells["THONGTINTONGQUAN"].Value);
            this.tinhTrangDiUngBox.Text = Convert.ToString(row.Cells["TINHTRANGDIUNG"].Value);
            this.ngaySinhBox.Value = Convert.ToDateTime(row.Cells["NGAYSINH"].Value);

            DonThuoc.idBenhAn = Convert.ToString(benhNhanTable.SelectedRows[0].Cells["ID"].Value);
            string gioiTinh = Convert.ToString(row.Cells["GIOITINH"].Value);
            if (gioiTinh == "Nam")
            {
                namRadioButton.Checked = true;
                nuRadioButton.Checked = false;
            }
            else if (gioiTinh == "Nữ")
            {
                nuRadioButton.Checked = true;
                namRadioButton.Checked = false;
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InformationSection_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
