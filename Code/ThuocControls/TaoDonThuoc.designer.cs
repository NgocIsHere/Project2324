using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLPHONGKHAM
{
    partial class TaoDonThuoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.huyButton = new System.Windows.Forms.Button();
            this.hoanThanhButton = new System.Windows.Forms.Button();
            this.donThuocControlPanel = new System.Windows.Forms.Panel();
            this.ghiChuThuocBox = new System.Windows.Forms.RichTextBox();
            this.ghiChuThuocLabel = new System.Windows.Forms.Label();
            this.searchThuocButton = new System.Windows.Forms.Button();
            this.searchThuocBox = new System.Windows.Forms.TextBox();
            this.searchThuocLabel = new System.Windows.Forms.Label();
            this.tenThuocBox = new System.Windows.Forms.TextBox();
            this.xoaThuocButton = new System.Windows.Forms.Button();
            this.themThuocButton = new System.Windows.Forms.Button();
            this.maDonThuocBox = new System.Windows.Forms.TextBox();
            this.maDonThuoc1 = new System.Windows.Forms.Label();
            this.soLuongThuocBox = new System.Windows.Forms.TextBox();
            this.soLuongThuoc1 = new System.Windows.Forms.Label();
            this.tenThuoc1 = new System.Windows.Forms.Label();
            this.chiTietDonTable = new System.Windows.Forms.DataGridView();
            this.thongTinBenhAn = new System.Windows.Forms.Panel();
            this.InformationSection = new System.Windows.Forms.Panel();
            this.ngayKeDon1 = new System.Windows.Forms.Label();
            this.ngayKeDonBox = new System.Windows.Forms.DateTimePicker();
            this.gioiTinh1 = new System.Windows.Forms.Label();
            this.nuRadioButton = new System.Windows.Forms.RadioButton();
            this.namRadioButton = new System.Windows.Forms.RadioButton();
            this.tinhTrangDiUngBox = new System.Windows.Forms.RichTextBox();
            this.tinhTrangDiUng1 = new System.Windows.Forms.Label();
            this.thongTinTongQuanBox = new System.Windows.Forms.RichTextBox();
            this.thongTinTongQuan1 = new System.Windows.Forms.Label();
            this.diaChiBox = new System.Windows.Forms.RichTextBox();
            this.diaChi1 = new System.Windows.Forms.Label();
            this.ngaySinh1 = new System.Windows.Forms.Label();
            this.ngaySinhBox = new System.Windows.Forms.DateTimePicker();
            this.sdt1 = new System.Windows.Forms.Label();
            this.sdtBox = new System.Windows.Forms.TextBox();
            this.tenBenhNhan = new System.Windows.Forms.Label();
            this.tenBenhNhanBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchThuocTable = new System.Windows.Forms.DataGridView();
            this.buttonPanel.SuspendLayout();
            this.donThuocControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonTable)).BeginInit();
            this.thongTinBenhAn.SuspendLayout();
            this.InformationSection.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchThuocTable)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPanel.Controls.Add(this.huyButton);
            this.buttonPanel.Controls.Add(this.hoanThanhButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(0, 634);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(1678, 71);
            this.buttonPanel.TabIndex = 3;
            // 
            // huyButton
            // 
            this.huyButton.Location = new System.Drawing.Point(960, 17);
            this.huyButton.Margin = new System.Windows.Forms.Padding(0);
            this.huyButton.Name = "huyButton";
            this.huyButton.Size = new System.Drawing.Size(140, 34);
            this.huyButton.TabIndex = 1;
            this.huyButton.Text = "Hủy";
            this.huyButton.UseVisualStyleBackColor = true;
            // 
            // hoanThanhButton
            // 
            this.hoanThanhButton.Location = new System.Drawing.Point(1145, 17);
            this.hoanThanhButton.Margin = new System.Windows.Forms.Padding(0);
            this.hoanThanhButton.Name = "hoanThanhButton";
            this.hoanThanhButton.Size = new System.Drawing.Size(153, 34);
            this.hoanThanhButton.TabIndex = 0;
            this.hoanThanhButton.Text = "Hoàn thành";
            this.hoanThanhButton.UseVisualStyleBackColor = true;
            // 
            // donThuocControlPanel
            // 
            this.donThuocControlPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.donThuocControlPanel.Controls.Add(this.ghiChuThuocBox);
            this.donThuocControlPanel.Controls.Add(this.ghiChuThuocLabel);
            this.donThuocControlPanel.Controls.Add(this.searchThuocButton);
            this.donThuocControlPanel.Controls.Add(this.searchThuocBox);
            this.donThuocControlPanel.Controls.Add(this.searchThuocLabel);
            this.donThuocControlPanel.Controls.Add(this.tenThuocBox);
            this.donThuocControlPanel.Controls.Add(this.xoaThuocButton);
            this.donThuocControlPanel.Controls.Add(this.themThuocButton);
            this.donThuocControlPanel.Controls.Add(this.maDonThuocBox);
            this.donThuocControlPanel.Controls.Add(this.maDonThuoc1);
            this.donThuocControlPanel.Controls.Add(this.soLuongThuocBox);
            this.donThuocControlPanel.Controls.Add(this.soLuongThuoc1);
            this.donThuocControlPanel.Controls.Add(this.tenThuoc1);
            this.donThuocControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donThuocControlPanel.Location = new System.Drawing.Point(0, 211);
            this.donThuocControlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.donThuocControlPanel.Name = "donThuocControlPanel";
            this.donThuocControlPanel.Size = new System.Drawing.Size(1678, 141);
            this.donThuocControlPanel.TabIndex = 1;
            // 
            // ghiChuThuocBox
            // 
            this.ghiChuThuocBox.Location = new System.Drawing.Point(1082, 44);
            this.ghiChuThuocBox.Name = "ghiChuThuocBox";
            this.ghiChuThuocBox.Size = new System.Drawing.Size(180, 63);
            this.ghiChuThuocBox.TabIndex = 13;
            this.ghiChuThuocBox.Text = "";
            // 
            // ghiChuThuocLabel
            // 
            this.ghiChuThuocLabel.AutoSize = true;
            this.ghiChuThuocLabel.Location = new System.Drawing.Point(1008, 46);
            this.ghiChuThuocLabel.Name = "ghiChuThuocLabel";
            this.ghiChuThuocLabel.Size = new System.Drawing.Size(64, 20);
            this.ghiChuThuocLabel.TabIndex = 12;
            this.ghiChuThuocLabel.Text = "Ghi chú";
            // 
            // searchThuocButton
            // 
            this.searchThuocButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchThuocButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchThuocButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchThuocButton.Location = new System.Drawing.Point(1555, 79);
            this.searchThuocButton.Name = "searchThuocButton";
            this.searchThuocButton.Size = new System.Drawing.Size(98, 29);
            this.searchThuocButton.TabIndex = 11;
            this.searchThuocButton.Text = "Tìm";
            this.searchThuocButton.UseVisualStyleBackColor = false;
            // 
            // searchThuocBox
            // 
            this.searchThuocBox.Location = new System.Drawing.Point(1298, 79);
            this.searchThuocBox.Name = "searchThuocBox";
            this.searchThuocBox.Size = new System.Drawing.Size(231, 26);
            this.searchThuocBox.TabIndex = 10;
            // 
            // searchThuocLabel
            // 
            this.searchThuocLabel.AutoSize = true;
            this.searchThuocLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.searchThuocLabel.Location = new System.Drawing.Point(1294, 46);
            this.searchThuocLabel.Name = "searchThuocLabel";
            this.searchThuocLabel.Size = new System.Drawing.Size(82, 20);
            this.searchThuocLabel.TabIndex = 9;
            this.searchThuocLabel.Text = "Tìm thuốc:";
            // 
            // tenThuocBox
            // 
            this.tenThuocBox.Location = new System.Drawing.Point(739, 43);
            this.tenThuocBox.Name = "tenThuocBox";
            this.tenThuocBox.Size = new System.Drawing.Size(228, 26);
            this.tenThuocBox.TabIndex = 8;
            // 
            // xoaThuocButton
            // 
            this.xoaThuocButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.xoaThuocButton.Location = new System.Drawing.Point(426, 46);
            this.xoaThuocButton.Name = "xoaThuocButton";
            this.xoaThuocButton.Size = new System.Drawing.Size(161, 60);
            this.xoaThuocButton.TabIndex = 7;
            this.xoaThuocButton.Text = "Xóa thuốc";
            this.xoaThuocButton.UseVisualStyleBackColor = true;
            this.xoaThuocButton.Click += new System.EventHandler(this.xoaThuocButton_Click);
            // 
            // themThuocButton
            // 
            this.themThuocButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.themThuocButton.Location = new System.Drawing.Point(230, 46);
            this.themThuocButton.Name = "themThuocButton";
            this.themThuocButton.Size = new System.Drawing.Size(169, 60);
            this.themThuocButton.TabIndex = 6;
            this.themThuocButton.Text = "Thêm thuốc";
            this.themThuocButton.UseVisualStyleBackColor = true;
            this.themThuocButton.Click += new System.EventHandler(this.themThuocButton_Click);
            // 
            // maDonThuocBox
            // 
            this.maDonThuocBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.maDonThuocBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maDonThuocBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maDonThuocBox.Location = new System.Drawing.Point(10, 62);
            this.maDonThuocBox.Margin = new System.Windows.Forms.Padding(0);
            this.maDonThuocBox.Name = "maDonThuocBox";
            this.maDonThuocBox.Size = new System.Drawing.Size(198, 29);
            this.maDonThuocBox.TabIndex = 5;
            // 
            // maDonThuoc1
            // 
            this.maDonThuoc1.AutoSize = true;
            this.maDonThuoc1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maDonThuoc1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.maDonThuoc1.Location = new System.Drawing.Point(14, 15);
            this.maDonThuoc1.Name = "maDonThuoc1";
            this.maDonThuoc1.Size = new System.Drawing.Size(174, 32);
            this.maDonThuoc1.TabIndex = 4;
            this.maDonThuoc1.Text = "Mã đơn thuốc";
            // 
            // soLuongThuocBox
            // 
            this.soLuongThuocBox.Location = new System.Drawing.Point(739, 79);
            this.soLuongThuocBox.Name = "soLuongThuocBox";
            this.soLuongThuocBox.Size = new System.Drawing.Size(228, 26);
            this.soLuongThuocBox.TabIndex = 3;
            // 
            // soLuongThuoc1
            // 
            this.soLuongThuoc1.AutoSize = true;
            this.soLuongThuoc1.Location = new System.Drawing.Point(627, 82);
            this.soLuongThuoc1.Name = "soLuongThuoc1";
            this.soLuongThuoc1.Size = new System.Drawing.Size(72, 20);
            this.soLuongThuoc1.TabIndex = 2;
            this.soLuongThuoc1.Text = "Số lượng";
            // 
            // tenThuoc1
            // 
            this.tenThuoc1.AutoSize = true;
            this.tenThuoc1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tenThuoc1.Location = new System.Drawing.Point(622, 46);
            this.tenThuoc1.Name = "tenThuoc1";
            this.tenThuoc1.Size = new System.Drawing.Size(80, 20);
            this.tenThuoc1.TabIndex = 0;
            this.tenThuoc1.Text = "Tên thuốc";
            // 
            // chiTietDonTable
            // 
            this.chiTietDonTable.AllowUserToOrderColumns = true;
            this.chiTietDonTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chiTietDonTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chiTietDonTable.Location = new System.Drawing.Point(0, 0);
            this.chiTietDonTable.Margin = new System.Windows.Forms.Padding(0);
            this.chiTietDonTable.Name = "chiTietDonTable";
            this.chiTietDonTable.ReadOnly = true;
            this.chiTietDonTable.RowHeadersWidth = 51;
            this.chiTietDonTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.chiTietDonTable.Size = new System.Drawing.Size(836, 276);
            this.chiTietDonTable.TabIndex = 2;
            // 
            // thongTinBenhAn
            // 
            this.thongTinBenhAn.Controls.Add(this.InformationSection);
            this.thongTinBenhAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thongTinBenhAn.Location = new System.Drawing.Point(0, 0);
            this.thongTinBenhAn.Margin = new System.Windows.Forms.Padding(0);
            this.thongTinBenhAn.Name = "thongTinBenhAn";
            this.thongTinBenhAn.Size = new System.Drawing.Size(1678, 211);
            this.thongTinBenhAn.TabIndex = 0;
            // 
            // InformationSection
            // 
            this.InformationSection.BackColor = System.Drawing.SystemColors.Control;
            this.InformationSection.Controls.Add(this.ngayKeDon1);
            this.InformationSection.Controls.Add(this.ngayKeDonBox);
            this.InformationSection.Controls.Add(this.gioiTinh1);
            this.InformationSection.Controls.Add(this.nuRadioButton);
            this.InformationSection.Controls.Add(this.namRadioButton);
            this.InformationSection.Controls.Add(this.tinhTrangDiUngBox);
            this.InformationSection.Controls.Add(this.tinhTrangDiUng1);
            this.InformationSection.Controls.Add(this.thongTinTongQuanBox);
            this.InformationSection.Controls.Add(this.thongTinTongQuan1);
            this.InformationSection.Controls.Add(this.diaChiBox);
            this.InformationSection.Controls.Add(this.diaChi1);
            this.InformationSection.Controls.Add(this.ngaySinh1);
            this.InformationSection.Controls.Add(this.ngaySinhBox);
            this.InformationSection.Controls.Add(this.sdt1);
            this.InformationSection.Controls.Add(this.sdtBox);
            this.InformationSection.Controls.Add(this.tenBenhNhan);
            this.InformationSection.Controls.Add(this.tenBenhNhanBox);
            this.InformationSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationSection.Location = new System.Drawing.Point(0, 0);
            this.InformationSection.Margin = new System.Windows.Forms.Padding(0);
            this.InformationSection.Name = "InformationSection";
            this.InformationSection.Size = new System.Drawing.Size(1678, 211);
            this.InformationSection.TabIndex = 2;
            // 
            // ngayKeDon1
            // 
            this.ngayKeDon1.AutoSize = true;
            this.ngayKeDon1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ngayKeDon1.Location = new System.Drawing.Point(1117, 45);
            this.ngayKeDon1.Name = "ngayKeDon1";
            this.ngayKeDon1.Size = new System.Drawing.Size(97, 20);
            this.ngayKeDon1.TabIndex = 25;
            this.ngayKeDon1.Text = "Ngày kê đơn";
            // 
            // ngayKeDonBox
            // 
            this.ngayKeDonBox.Enabled = false;
            this.ngayKeDonBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayKeDonBox.Location = new System.Drawing.Point(1117, 75);
            this.ngayKeDonBox.Name = "ngayKeDonBox";
            this.ngayKeDonBox.Size = new System.Drawing.Size(145, 26);
            this.ngayKeDonBox.TabIndex = 24;
            // 
            // gioiTinh1
            // 
            this.gioiTinh1.AutoSize = true;
            this.gioiTinh1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioiTinh1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gioiTinh1.Location = new System.Drawing.Point(68, 193);
            this.gioiTinh1.Margin = new System.Windows.Forms.Padding(0);
            this.gioiTinh1.Name = "gioiTinh1";
            this.gioiTinh1.Size = new System.Drawing.Size(84, 25);
            this.gioiTinh1.TabIndex = 22;
            this.gioiTinh1.Text = "Giới tính";
            // 
            // nuRadioButton
            // 
            this.nuRadioButton.AutoSize = true;
            this.nuRadioButton.Enabled = false;
            this.nuRadioButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nuRadioButton.Location = new System.Drawing.Point(223, 193);
            this.nuRadioButton.Name = "nuRadioButton";
            this.nuRadioButton.Size = new System.Drawing.Size(54, 24);
            this.nuRadioButton.TabIndex = 21;
            this.nuRadioButton.TabStop = true;
            this.nuRadioButton.Text = "Nữ";
            this.nuRadioButton.UseVisualStyleBackColor = true;
            // 
            // namRadioButton
            // 
            this.namRadioButton.AutoSize = true;
            this.namRadioButton.Enabled = false;
            this.namRadioButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.namRadioButton.Location = new System.Drawing.Point(146, 192);
            this.namRadioButton.Name = "namRadioButton";
            this.namRadioButton.Size = new System.Drawing.Size(67, 24);
            this.namRadioButton.TabIndex = 20;
            this.namRadioButton.TabStop = true;
            this.namRadioButton.Text = "Nam";
            this.namRadioButton.UseVisualStyleBackColor = true;
            // 
            // tinhTrangDiUngBox
            // 
            this.tinhTrangDiUngBox.Location = new System.Drawing.Point(720, 28);
            this.tinhTrangDiUngBox.Name = "tinhTrangDiUngBox";
            this.tinhTrangDiUngBox.ReadOnly = true;
            this.tinhTrangDiUngBox.Size = new System.Drawing.Size(319, 53);
            this.tinhTrangDiUngBox.TabIndex = 19;
            this.tinhTrangDiUngBox.Text = "";
            // 
            // tinhTrangDiUng1
            // 
            this.tinhTrangDiUng1.AutoSize = true;
            this.tinhTrangDiUng1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhTrangDiUng1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tinhTrangDiUng1.Location = new System.Drawing.Point(573, 45);
            this.tinhTrangDiUng1.Margin = new System.Windows.Forms.Padding(0);
            this.tinhTrangDiUng1.Name = "tinhTrangDiUng1";
            this.tinhTrangDiUng1.Size = new System.Drawing.Size(157, 25);
            this.tinhTrangDiUng1.TabIndex = 18;
            this.tinhTrangDiUng1.Text = "Tình trạng dị ứng";
            // 
            // thongTinTongQuanBox
            // 
            this.thongTinTongQuanBox.Location = new System.Drawing.Point(720, 102);
            this.thongTinTongQuanBox.Name = "thongTinTongQuanBox";
            this.thongTinTongQuanBox.ReadOnly = true;
            this.thongTinTongQuanBox.Size = new System.Drawing.Size(319, 53);
            this.thongTinTongQuanBox.TabIndex = 17;
            this.thongTinTongQuanBox.Text = "";
            // 
            // thongTinTongQuan1
            // 
            this.thongTinTongQuan1.AutoSize = true;
            this.thongTinTongQuan1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongTinTongQuan1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.thongTinTongQuan1.Location = new System.Drawing.Point(548, 120);
            this.thongTinTongQuan1.Margin = new System.Windows.Forms.Padding(0);
            this.thongTinTongQuan1.Name = "thongTinTongQuan1";
            this.thongTinTongQuan1.Size = new System.Drawing.Size(185, 25);
            this.thongTinTongQuan1.TabIndex = 16;
            this.thongTinTongQuan1.Text = "Thông tin tổng quan";
            // 
            // diaChiBox
            // 
            this.diaChiBox.Location = new System.Drawing.Point(720, 177);
            this.diaChiBox.Name = "diaChiBox";
            this.diaChiBox.ReadOnly = true;
            this.diaChiBox.Size = new System.Drawing.Size(319, 53);
            this.diaChiBox.TabIndex = 12;
            this.diaChiBox.Text = "";
            // 
            // diaChi1
            // 
            this.diaChi1.AutoSize = true;
            this.diaChi1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChi1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.diaChi1.Location = new System.Drawing.Point(654, 196);
            this.diaChi1.Margin = new System.Windows.Forms.Padding(0);
            this.diaChi1.Name = "diaChi1";
            this.diaChi1.Size = new System.Drawing.Size(67, 25);
            this.diaChi1.TabIndex = 11;
            this.diaChi1.Text = "Địa chỉ";
            // 
            // ngaySinh1
            // 
            this.ngaySinh1.AutoSize = true;
            this.ngaySinh1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinh1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ngaySinh1.Location = new System.Drawing.Point(55, 133);
            this.ngaySinh1.Margin = new System.Windows.Forms.Padding(0);
            this.ngaySinh1.Name = "ngaySinh1";
            this.ngaySinh1.Size = new System.Drawing.Size(94, 25);
            this.ngaySinh1.TabIndex = 9;
            this.ngaySinh1.Text = "Ngày sinh";
            // 
            // ngaySinhBox
            // 
            this.ngaySinhBox.CustomFormat = "yyyy-MM-dd";
            this.ngaySinhBox.Enabled = false;
            this.ngaySinhBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaySinhBox.Location = new System.Drawing.Point(146, 128);
            this.ngaySinhBox.Name = "ngaySinhBox";
            this.ngaySinhBox.Size = new System.Drawing.Size(149, 26);
            this.ngaySinhBox.TabIndex = 8;
            this.ngaySinhBox.Value = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            // 
            // sdt1
            // 
            this.sdt1.AutoSize = true;
            this.sdt1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdt1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sdt1.Location = new System.Drawing.Point(32, 75);
            this.sdt1.Margin = new System.Windows.Forms.Padding(0);
            this.sdt1.Name = "sdt1";
            this.sdt1.Size = new System.Drawing.Size(122, 25);
            this.sdt1.TabIndex = 3;
            this.sdt1.Text = "Số điện thoại";
            // 
            // sdtBox
            // 
            this.sdtBox.Location = new System.Drawing.Point(146, 72);
            this.sdtBox.Name = "sdtBox";
            this.sdtBox.ReadOnly = true;
            this.sdtBox.Size = new System.Drawing.Size(252, 26);
            this.sdtBox.TabIndex = 2;
            // 
            // tenBenhNhan
            // 
            this.tenBenhNhan.AutoSize = true;
            this.tenBenhNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenBenhNhan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tenBenhNhan.Location = new System.Drawing.Point(18, 28);
            this.tenBenhNhan.Margin = new System.Windows.Forms.Padding(0);
            this.tenBenhNhan.Name = "tenBenhNhan";
            this.tenBenhNhan.Size = new System.Drawing.Size(134, 25);
            this.tenBenhNhan.TabIndex = 1;
            this.tenBenhNhan.Text = "Tên bệnh nhân";
            // 
            // tenBenhNhanBox
            // 
            this.tenBenhNhanBox.Location = new System.Drawing.Point(146, 25);
            this.tenBenhNhanBox.Name = "tenBenhNhanBox";
            this.tenBenhNhanBox.ReadOnly = true;
            this.tenBenhNhanBox.Size = new System.Drawing.Size(252, 26);
            this.tenBenhNhanBox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.thongTinBenhAn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.donThuocControlPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPanel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1678, 705);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.chiTietDonTable, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchThuocTable, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 355);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1672, 276);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // searchThuocTable
            // 
            this.searchThuocTable.AllowUserToAddRows = false;
            this.searchThuocTable.AllowUserToDeleteRows = false;
            this.searchThuocTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchThuocTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchThuocTable.GridColor = System.Drawing.Color.Thistle;
            this.searchThuocTable.Location = new System.Drawing.Point(842, 0);
            this.searchThuocTable.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.searchThuocTable.MultiSelect = false;
            this.searchThuocTable.Name = "searchThuocTable";
            this.searchThuocTable.ReadOnly = true;
            this.searchThuocTable.RowHeadersWidth = 51;
            this.searchThuocTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchThuocTable.Size = new System.Drawing.Size(830, 276);
            this.searchThuocTable.TabIndex = 3;
            // 
            // TaoDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 705);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TaoDonThuoc";
            this.Text = "CHI TIẾT ĐƠN";
            this.buttonPanel.ResumeLayout(false);
            this.donThuocControlPanel.ResumeLayout(false);
            this.donThuocControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonTable)).EndInit();
            this.thongTinBenhAn.ResumeLayout(false);
            this.InformationSection.ResumeLayout(false);
            this.InformationSection.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchThuocTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel buttonPanel;
        private Button huyButton;
        private Button hoanThanhButton;
        private Panel donThuocControlPanel;
        private TextBox tenThuocBox;
        private Button xoaThuocButton;
        private Button themThuocButton;
        private DataGridView chiTietDonTable;
        private TextBox maDonThuocBox;
        private Label maDonThuoc1;
        private TextBox soLuongThuocBox;
        private Label soLuongThuoc1;
        private Label tenThuoc1;
        private Panel thongTinBenhAn;
        private Panel InformationSection;
        private Label ngayKeDon1;
        private DateTimePicker ngayKeDonBox;
        private Label gioiTinh1;
        private RadioButton nuRadioButton;
        private RadioButton namRadioButton;
        private RichTextBox tinhTrangDiUngBox;
        private Label tinhTrangDiUng1;
        private RichTextBox thongTinTongQuanBox;
        private Label thongTinTongQuan1;
        private RichTextBox diaChiBox;
        private Label diaChi1;
        private Label ngaySinh1;
        private DateTimePicker ngaySinhBox;
        private Label sdt1;
        private TextBox sdtBox;
        private Label tenBenhNhan;
        private TextBox tenBenhNhanBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label searchThuocLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView searchThuocTable;
        private Button searchThuocButton;
        private TextBox searchThuocBox;
        private RichTextBox ghiChuThuocBox;
        private Label ghiChuThuocLabel;
    }
}