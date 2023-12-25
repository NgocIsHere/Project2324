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
        public static string idDonThuoc { get; set; }
        public static string ngayKeDon {  get; set; }

        string ngay = DateTime.Now.Day.ToString("d2");
        string thang = DateTime.Now.Month.ToString("d2");
        string nam = DateTime.Now.Year.ToString();
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
        private void themButton_Click(object sender, EventArgs e)
        { 
            DonThuoc.hoTen = this.tenBenhNhanBox.Text;
            DonThuoc.ngaySinh = this.ngaySinhBox.Value.ToString();
            DonThuoc.diaChi = this.diaChiBox.Text;
            DonThuoc.sdt = this.sdtBox.Text;
            DonThuoc.tinhTrangDiUng = this.tinhTrangDiUngBox.Text;
            DonThuoc.thongTinTongQuan = this.thongTinTongQuanBox.Text;
            DonThuoc.ngayKeDon = this.ngayKeDonBox.Value.ToString();

            if (namRadioButton.Checked)
            {
                DonThuoc.gioiTinh = "Nam";
            }
            else if (nuRadioButton.Checked)
            {
                DonThuoc.gioiTinh = "Nữ";
            }
            
            TaoDonThuoc taoDonThuoc = new TaoDonThuoc();
            taoDonThuoc.ShowDialog();
        }

        private void donThuocButton_Click(object sender, EventArgs e)
        {

        }

        private void benhNhanTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            themButton.Enabled = true;
            donThuocButton.Enabled = true;

            DataGridViewRow row = new DataGridViewRow();
            row = benhNhanTable.Rows[e.RowIndex];

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
    }
}
