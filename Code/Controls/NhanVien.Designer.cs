using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace QLPHONGKHAM
{
    partial class NhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Label = new System.Windows.Forms.Label();
            this.InformationSection = new System.Windows.Forms.Panel();
            this.gioiTinh = new System.Windows.Forms.Label();
            this.nuRadioButton = new System.Windows.Forms.RadioButton();
            this.namRadioButton = new System.Windows.Forms.RadioButton();
            this.capNhatButton = new System.Windows.Forms.Button();
            this.xoaButton = new System.Windows.Forms.Button();
            this.themButton = new System.Windows.Forms.Button();
            this.hoVaTenBox = new System.Windows.Forms.RichTextBox();
            this.hoVaTen = new System.Windows.Forms.Label();
            this.ngaySinh = new System.Windows.Forms.Label();
            this.ngaySinhBox = new System.Windows.Forms.DateTimePicker();
            this.soDienThoai = new System.Windows.Forms.Label();
            this.soDienThoaiBox = new System.Windows.Forms.TextBox();
            this.diaChi = new System.Windows.Forms.Label();
            this.diaChiBox = new System.Windows.Forms.TextBox();
            this.matKhau = new System.Windows.Forms.Label();
            this.matKhauBox = new System.Windows.Forms.TextBox();
            this.iDNhanVien = new System.Windows.Forms.Label();
            this.iDNhaSiBox = new System.Windows.Forms.TextBox();
            this.nhanVienTable = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.InformationSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.InformationSection, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nhanVienTable, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.88044F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.1413F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1294, 642);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.Color.Teal;
            this.Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.GhostWhite;
            this.Label.Location = new System.Drawing.Point(0, 0);
            this.Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(1294, 38);
            this.Label.TabIndex = 0;
            this.Label.Text = "NHÂN VIÊN";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InformationSection
            // 
            this.InformationSection.BackColor = System.Drawing.SystemColors.Control;
            this.InformationSection.Controls.Add(this.gioiTinh);
            this.InformationSection.Controls.Add(this.nuRadioButton);
            this.InformationSection.Controls.Add(this.namRadioButton);
            this.InformationSection.Controls.Add(this.capNhatButton);
            this.InformationSection.Controls.Add(this.xoaButton);
            this.InformationSection.Controls.Add(this.themButton);
            this.InformationSection.Controls.Add(this.hoVaTenBox);
            this.InformationSection.Controls.Add(this.hoVaTen);
            this.InformationSection.Controls.Add(this.ngaySinh);
            this.InformationSection.Controls.Add(this.ngaySinhBox);
            this.InformationSection.Controls.Add(this.soDienThoai);
            this.InformationSection.Controls.Add(this.soDienThoaiBox);
            this.InformationSection.Controls.Add(this.diaChi);
            this.InformationSection.Controls.Add(this.diaChiBox);
            this.InformationSection.Controls.Add(this.matKhau);
            this.InformationSection.Controls.Add(this.matKhauBox);
            this.InformationSection.Controls.Add(this.iDNhanVien);
            this.InformationSection.Controls.Add(this.iDNhaSiBox);
            this.InformationSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationSection.Location = new System.Drawing.Point(0, 38);
            this.InformationSection.Margin = new System.Windows.Forms.Padding(0);
            this.InformationSection.Name = "InformationSection";
            this.InformationSection.Size = new System.Drawing.Size(1294, 211);
            this.InformationSection.TabIndex = 1;
            // 
            // gioiTinh
            // 
            this.gioiTinh.AutoSize = true;
            this.gioiTinh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioiTinh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gioiTinh.Location = new System.Drawing.Point(477, 124);
            this.gioiTinh.Margin = new System.Windows.Forms.Padding(0);
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Size = new System.Drawing.Size(84, 25);
            this.gioiTinh.TabIndex = 25;
            this.gioiTinh.Text = "Giới tính";
            // 
            // nuRadioButton
            // 
            this.nuRadioButton.AutoSize = true;
            this.nuRadioButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nuRadioButton.Location = new System.Drawing.Point(688, 123);
            this.nuRadioButton.Name = "nuRadioButton";
            this.nuRadioButton.Size = new System.Drawing.Size(54, 24);
            this.nuRadioButton.TabIndex = 24;
            this.nuRadioButton.TabStop = true;
            this.nuRadioButton.Text = "Nữ";
            this.nuRadioButton.UseVisualStyleBackColor = true;
            // 
            // namRadioButton
            // 
            this.namRadioButton.AutoSize = true;
            this.namRadioButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.namRadioButton.Location = new System.Drawing.Point(601, 122);
            this.namRadioButton.Name = "namRadioButton";
            this.namRadioButton.Size = new System.Drawing.Size(67, 24);
            this.namRadioButton.TabIndex = 23;
            this.namRadioButton.TabStop = true;
            this.namRadioButton.Text = "Nam";
            this.namRadioButton.UseVisualStyleBackColor = true;
            // 
            // capNhatButton
            // 
            this.capNhatButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.capNhatButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.capNhatButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capNhatButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.capNhatButton.Location = new System.Drawing.Point(943, 161);
            this.capNhatButton.Name = "capNhatButton";
            this.capNhatButton.Size = new System.Drawing.Size(199, 37);
            this.capNhatButton.TabIndex = 15;
            this.capNhatButton.Text = "CẬP NHẬT";
            this.capNhatButton.UseVisualStyleBackColor = false;
            this.capNhatButton.Click += new System.EventHandler(this.capNhatButton_Click);
            // 
            // xoaButton
            // 
            this.xoaButton.BackColor = System.Drawing.Color.LightCoral;
            this.xoaButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.xoaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.xoaButton.Location = new System.Drawing.Point(943, 93);
            this.xoaButton.Name = "xoaButton";
            this.xoaButton.Size = new System.Drawing.Size(199, 37);
            this.xoaButton.TabIndex = 14;
            this.xoaButton.Text = "XÓA";
            this.xoaButton.UseVisualStyleBackColor = false;
            this.xoaButton.Click += new System.EventHandler(this.xoaButton_Click);
            // 
            // themButton
            // 
            this.themButton.BackColor = System.Drawing.Color.Chocolate;
            this.themButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.themButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.themButton.Location = new System.Drawing.Point(943, 27);
            this.themButton.Margin = new System.Windows.Forms.Padding(0);
            this.themButton.Name = "themButton";
            this.themButton.Size = new System.Drawing.Size(199, 37);
            this.themButton.TabIndex = 13;
            this.themButton.Text = "THÊM";
            this.themButton.UseVisualStyleBackColor = false;
            this.themButton.Click += new System.EventHandler(this.themButton_Click);
            // 
            // hoVaTenBox
            // 
            this.hoVaTenBox.Location = new System.Drawing.Point(601, 29);
            this.hoVaTenBox.Name = "hoVaTenBox";
            this.hoVaTenBox.Size = new System.Drawing.Size(274, 24);
            this.hoVaTenBox.TabIndex = 12;
            this.hoVaTenBox.Text = "";
            // 
            // hoVaTen
            // 
            this.hoVaTen.AutoSize = true;
            this.hoVaTen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoVaTen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.hoVaTen.Location = new System.Drawing.Point(477, 32);
            this.hoVaTen.Margin = new System.Windows.Forms.Padding(0);
            this.hoVaTen.Name = "hoVaTen";
            this.hoVaTen.Size = new System.Drawing.Size(92, 25);
            this.hoVaTen.TabIndex = 11;
            this.hoVaTen.Text = "Họ và tên";
            // 
            // ngaySinh
            // 
            this.ngaySinh.AutoSize = true;
            this.ngaySinh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ngaySinh.Location = new System.Drawing.Point(477, 79);
            this.ngaySinh.Margin = new System.Windows.Forms.Padding(0);
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Size = new System.Drawing.Size(94, 25);
            this.ngaySinh.TabIndex = 9;
            this.ngaySinh.Text = "Ngày sinh";
            // 
            // ngaySinhBox
            // 
            this.ngaySinhBox.CustomFormat = "yyyy-MM-dd";
            this.ngaySinhBox.Location = new System.Drawing.Point(601, 77);
            this.ngaySinhBox.Name = "ngaySinhBox";
            this.ngaySinhBox.Size = new System.Drawing.Size(274, 26);
            this.ngaySinhBox.TabIndex = 8;
            this.ngaySinhBox.Value = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            // 
            // soDienThoai
            // 
            this.soDienThoai.AutoSize = true;
            this.soDienThoai.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soDienThoai.ForeColor = System.Drawing.SystemColors.WindowText;
            this.soDienThoai.Location = new System.Drawing.Point(18, 178);
            this.soDienThoai.Margin = new System.Windows.Forms.Padding(0);
            this.soDienThoai.Name = "soDienThoai";
            this.soDienThoai.Size = new System.Drawing.Size(122, 25);
            this.soDienThoai.TabIndex = 7;
            this.soDienThoai.Text = "Số điện thoại";
            // 
            // soDienThoaiBox
            // 
            this.soDienThoaiBox.Location = new System.Drawing.Point(176, 175);
            this.soDienThoaiBox.Name = "soDienThoaiBox";
            this.soDienThoaiBox.Size = new System.Drawing.Size(252, 26);
            this.soDienThoaiBox.TabIndex = 6;
            // 
            // diaChi
            // 
            this.diaChi.AutoSize = true;
            this.diaChi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.diaChi.Location = new System.Drawing.Point(18, 126);
            this.diaChi.Margin = new System.Windows.Forms.Padding(0);
            this.diaChi.Name = "diaChi";
            this.diaChi.Size = new System.Drawing.Size(67, 25);
            this.diaChi.TabIndex = 5;
            this.diaChi.Text = "Địa chỉ";
            // 
            // diaChiBox
            // 
            this.diaChiBox.Location = new System.Drawing.Point(176, 123);
            this.diaChiBox.Name = "diaChiBox";
            this.diaChiBox.Size = new System.Drawing.Size(252, 26);
            this.diaChiBox.TabIndex = 4;
            // 
            // matKhau
            // 
            this.matKhau.AutoSize = true;
            this.matKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matKhau.ForeColor = System.Drawing.SystemColors.WindowText;
            this.matKhau.Location = new System.Drawing.Point(18, 75);
            this.matKhau.Margin = new System.Windows.Forms.Padding(0);
            this.matKhau.Name = "matKhau";
            this.matKhau.Size = new System.Drawing.Size(89, 25);
            this.matKhau.TabIndex = 3;
            this.matKhau.Text = "Mật khẩu";
            // 
            // matKhauBox
            // 
            this.matKhauBox.Location = new System.Drawing.Point(176, 72);
            this.matKhauBox.Name = "matKhauBox";
            this.matKhauBox.Size = new System.Drawing.Size(252, 26);
            this.matKhauBox.TabIndex = 2;
            // 
            // iDNhanVien
            // 
            this.iDNhanVien.AutoSize = true;
            this.iDNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDNhanVien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.iDNhanVien.Location = new System.Drawing.Point(18, 28);
            this.iDNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.iDNhanVien.Name = "iDNhanVien";
            this.iDNhanVien.Size = new System.Drawing.Size(119, 25);
            this.iDNhanVien.TabIndex = 1;
            this.iDNhanVien.Text = "ID Nhân viên";
            // 
            // iDNhaSiBox
            // 
            this.iDNhaSiBox.Location = new System.Drawing.Point(176, 25);
            this.iDNhaSiBox.Name = "iDNhaSiBox";
            this.iDNhaSiBox.Size = new System.Drawing.Size(252, 26);
            this.iDNhaSiBox.TabIndex = 0;
            // 
            // nhanVienTable
            // 
            this.nhanVienTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanVienTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanVienTable.Location = new System.Drawing.Point(3, 252);
            this.nhanVienTable.Name = "nhanVienTable";
            this.nhanVienTable.ReadOnly = true;
            this.nhanVienTable.RowHeadersWidth = 51;
            this.nhanVienTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nhanVienTable.Size = new System.Drawing.Size(1288, 387);
            this.nhanVienTable.TabIndex = 2;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NhanVien";
            this.Size = new System.Drawing.Size(1294, 642);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.InformationSection.ResumeLayout(false);
            this.InformationSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel InformationSection;
        private Label gioiTinh;
        private RadioButton nuRadioButton;
        private RadioButton namRadioButton;
        private Button capNhatButton;
        private Button xoaButton;
        private Button themButton;
        private RichTextBox hoVaTenBox;
        private Label hoVaTen;
        private Label ngaySinh;
        private DateTimePicker ngaySinhBox;
        private Label soDienThoai;
        private TextBox soDienThoaiBox;
        private Label diaChi;
        private TextBox diaChiBox;
        private Label matKhau;
        private TextBox matKhauBox;
        private Label iDNhanVien;
        private TextBox iDNhaSiBox;
        private Label Label;
        private DataGridView nhanVienTable;
    }
}