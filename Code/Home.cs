using QLPHONGKHAM.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPHONGKHAM
{
    public partial class Home : Form
    {
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        Color btnDefaultColor = Color.Transparent;
        Color btnSelectedtColor = Color.Teal;
        public string role;
        public Home(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void thuocButton_Click(object sender, EventArgs e)
        {
            QuanLyThuoc qlthuoc = new QuanLyThuoc();
            qlthuoc.role = role;
            qlthuoc.Show();
        }

        private void NSButton_Click(object sender, EventArgs e)
        {
            NhaSi nhaSi = new NhaSi();
            nhaSi.role = role;
            nhaSi.Show();
        }

        private void NVButton_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.role = role;
            nhanVien.Show();
        }
        private void LLVButton_Click(object sender, EventArgs e)
        {
            LichLamViec llv = new LichLamViec();
            llv.role = role;
            llv.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            QuanLyBenhNhan qlbn = new QuanLyBenhNhan(role);
            qlbn.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment(role);
            this.Hide();
            appointment.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DonThuoc donThuoc = new DonThuoc();
            donThuoc.role = role;
            donThuoc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThongKe thongKe = new ThongKe(this.role);
            this.Hide();
            thongKe.Show();
        }
    }
}