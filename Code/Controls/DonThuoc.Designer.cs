using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLPHONGKHAM.Controls
{
    partial class DonThuoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.themButton = new System.Windows.Forms.Button();
            this.diaChiBox = new System.Windows.Forms.RichTextBox();
            this.diaChi1 = new System.Windows.Forms.Label();
            this.ngaySinh1 = new System.Windows.Forms.Label();
            this.ngaySinhBox = new System.Windows.Forms.DateTimePicker();
            this.sdt1 = new System.Windows.Forms.Label();
            this.sdtBox = new System.Windows.Forms.TextBox();
            this.tenBenhNhan = new System.Windows.Forms.Label();
            this.tenBenhNhanBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.InformationSection = new System.Windows.Forms.Panel();
            this.ngayKeDon1 = new System.Windows.Forms.Label();
            this.ngayKeDonBox = new System.Windows.Forms.DateTimePicker();
            this.donThuocButton = new System.Windows.Forms.Button();
            this.gioiTinh1 = new System.Windows.Forms.Label();
            this.nuRadioButton = new System.Windows.Forms.RadioButton();
            this.namRadioButton = new System.Windows.Forms.RadioButton();
            this.tinhTrangDiUngBox = new System.Windows.Forms.RichTextBox();
            this.tinhTrangDiUng1 = new System.Windows.Forms.Label();
            this.thongTinTongQuanBox = new System.Windows.Forms.RichTextBox();
            this.thongTinTongQuan1 = new System.Windows.Forms.Label();
            this.benhNhanTable = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.InformationSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanTable)).BeginInit();
            this.SuspendLayout();
            // 
            // themButton
            // 
            this.themButton.BackColor = System.Drawing.Color.Chocolate;
            this.themButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.themButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.themButton.Location = new System.Drawing.Point(993, 68);
            this.themButton.Margin = new System.Windows.Forms.Padding(0);
            this.themButton.Name = "themButton";
            this.themButton.Size = new System.Drawing.Size(164, 43);
            this.themButton.TabIndex = 13;
            this.themButton.Text = "KÊ ĐƠN";
            this.themButton.UseVisualStyleBackColor = false;
            this.themButton.Click += new System.EventHandler(this.themButton_Click);
            // 
            // diaChiBox
            // 
            this.diaChiBox.Location = new System.Drawing.Point(640, 142);
            this.diaChiBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diaChiBox.Name = "diaChiBox";
            this.diaChiBox.ReadOnly = true;
            this.diaChiBox.Size = new System.Drawing.Size(284, 43);
            this.diaChiBox.TabIndex = 12;
            this.diaChiBox.Text = "";
            this.diaChiBox.TextChanged += new System.EventHandler(this.diaChiBox_TextChanged);
            // 
            // diaChi1
            // 
            this.diaChi1.AutoSize = true;
            this.diaChi1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChi1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.diaChi1.Location = new System.Drawing.Point(581, 157);
            this.diaChi1.Margin = new System.Windows.Forms.Padding(0);
            this.diaChi1.Name = "diaChi1";
            this.diaChi1.Size = new System.Drawing.Size(56, 20);
            this.diaChi1.TabIndex = 11;
            this.diaChi1.Text = "Địa chỉ";
            // 
            // ngaySinh1
            // 
            this.ngaySinh1.AutoSize = true;
            this.ngaySinh1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinh1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ngaySinh1.Location = new System.Drawing.Point(49, 106);
            this.ngaySinh1.Margin = new System.Windows.Forms.Padding(0);
            this.ngaySinh1.Name = "ngaySinh1";
            this.ngaySinh1.Size = new System.Drawing.Size(78, 20);
            this.ngaySinh1.TabIndex = 9;
            this.ngaySinh1.Text = "Ngày sinh";
            // 
            // ngaySinhBox
            // 
            this.ngaySinhBox.CustomFormat = "yyyy-MM-dd";
            this.ngaySinhBox.Enabled = false;
            this.ngaySinhBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaySinhBox.Location = new System.Drawing.Point(130, 102);
            this.ngaySinhBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngaySinhBox.Name = "ngaySinhBox";
            this.ngaySinhBox.Size = new System.Drawing.Size(126, 22);
            this.ngaySinhBox.TabIndex = 8;
            this.ngaySinhBox.Value = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            this.ngaySinhBox.ValueChanged += new System.EventHandler(this.ngaySinhBox_ValueChanged);
            // 
            // sdt1
            // 
            this.sdt1.AutoSize = true;
            this.sdt1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdt1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sdt1.Location = new System.Drawing.Point(28, 60);
            this.sdt1.Margin = new System.Windows.Forms.Padding(0);
            this.sdt1.Name = "sdt1";
            this.sdt1.Size = new System.Drawing.Size(99, 20);
            this.sdt1.TabIndex = 3;
            this.sdt1.Text = "Số điện thoại";
            // 
            // sdtBox
            // 
            this.sdtBox.Location = new System.Drawing.Point(130, 58);
            this.sdtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sdtBox.Name = "sdtBox";
            this.sdtBox.ReadOnly = true;
            this.sdtBox.Size = new System.Drawing.Size(224, 22);
            this.sdtBox.TabIndex = 2;
            this.sdtBox.TextChanged += new System.EventHandler(this.sdtBox_TextChanged);
            // 
            // tenBenhNhan
            // 
            this.tenBenhNhan.AutoSize = true;
            this.tenBenhNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenBenhNhan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tenBenhNhan.Location = new System.Drawing.Point(16, 22);
            this.tenBenhNhan.Margin = new System.Windows.Forms.Padding(0);
            this.tenBenhNhan.Name = "tenBenhNhan";
            this.tenBenhNhan.Size = new System.Drawing.Size(111, 20);
            this.tenBenhNhan.TabIndex = 1;
            this.tenBenhNhan.Text = "Tên bệnh nhân";
            // 
            // tenBenhNhanBox
            // 
            this.tenBenhNhanBox.Location = new System.Drawing.Point(130, 20);
            this.tenBenhNhanBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenBenhNhanBox.Name = "tenBenhNhanBox";
            this.tenBenhNhanBox.ReadOnly = true;
            this.tenBenhNhanBox.Size = new System.Drawing.Size(224, 22);
            this.tenBenhNhanBox.TabIndex = 0;
            this.tenBenhNhanBox.TextChanged += new System.EventHandler(this.tenBenhNhanBox_TextChanged);
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
            this.Label.Size = new System.Drawing.Size(1173, 36);
            this.Label.TabIndex = 0;
            this.Label.Text = "ĐƠN THUỐC";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.InformationSection, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.benhNhanTable, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.88044F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.1413F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1173, 605);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // InformationSection
            // 
            this.InformationSection.BackColor = System.Drawing.SystemColors.Control;
            this.InformationSection.Controls.Add(this.ngayKeDon1);
            this.InformationSection.Controls.Add(this.ngayKeDonBox);
            this.InformationSection.Controls.Add(this.donThuocButton);
            this.InformationSection.Controls.Add(this.gioiTinh1);
            this.InformationSection.Controls.Add(this.nuRadioButton);
            this.InformationSection.Controls.Add(this.namRadioButton);
            this.InformationSection.Controls.Add(this.tinhTrangDiUngBox);
            this.InformationSection.Controls.Add(this.tinhTrangDiUng1);
            this.InformationSection.Controls.Add(this.thongTinTongQuanBox);
            this.InformationSection.Controls.Add(this.thongTinTongQuan1);
            this.InformationSection.Controls.Add(this.themButton);
            this.InformationSection.Controls.Add(this.diaChiBox);
            this.InformationSection.Controls.Add(this.diaChi1);
            this.InformationSection.Controls.Add(this.ngaySinh1);
            this.InformationSection.Controls.Add(this.ngaySinhBox);
            this.InformationSection.Controls.Add(this.sdt1);
            this.InformationSection.Controls.Add(this.sdtBox);
            this.InformationSection.Controls.Add(this.tenBenhNhan);
            this.InformationSection.Controls.Add(this.tenBenhNhanBox);
            this.InformationSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationSection.Location = new System.Drawing.Point(0, 36);
            this.InformationSection.Margin = new System.Windows.Forms.Padding(0);
            this.InformationSection.Name = "InformationSection";
            this.InformationSection.Size = new System.Drawing.Size(1173, 198);
            this.InformationSection.TabIndex = 1;
            // 
            // ngayKeDon1
            // 
            this.ngayKeDon1.AutoSize = true;
            this.ngayKeDon1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ngayKeDon1.Location = new System.Drawing.Point(993, 36);
            this.ngayKeDon1.Name = "ngayKeDon1";
            this.ngayKeDon1.Size = new System.Drawing.Size(84, 16);
            this.ngayKeDon1.TabIndex = 25;
            this.ngayKeDon1.Text = "Ngày kê đơn";
            // 
            // ngayKeDonBox
            // 
            this.ngayKeDonBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayKeDonBox.Location = new System.Drawing.Point(1092, 32);
            this.ngayKeDonBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngayKeDonBox.Name = "ngayKeDonBox";
            this.ngayKeDonBox.Size = new System.Drawing.Size(113, 22);
            this.ngayKeDonBox.TabIndex = 24;
            this.ngayKeDonBox.ValueChanged += new System.EventHandler(this.ngayKeDonBox_ValueChanged);
            // 
            // donThuocButton
            // 
            this.donThuocButton.BackColor = System.Drawing.Color.Chocolate;
            this.donThuocButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.donThuocButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donThuocButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.donThuocButton.Location = new System.Drawing.Point(993, 130);
            this.donThuocButton.Margin = new System.Windows.Forms.Padding(0);
            this.donThuocButton.Name = "donThuocButton";
            this.donThuocButton.Size = new System.Drawing.Size(164, 54);
            this.donThuocButton.TabIndex = 23;
            this.donThuocButton.Text = "XEM ĐƠN THUỐC";
            this.donThuocButton.UseVisualStyleBackColor = false;
            this.donThuocButton.Click += new System.EventHandler(this.donThuocButton_Click);
            // 
            // gioiTinh1
            // 
            this.gioiTinh1.AutoSize = true;
            this.gioiTinh1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioiTinh1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gioiTinh1.Location = new System.Drawing.Point(60, 154);
            this.gioiTinh1.Margin = new System.Windows.Forms.Padding(0);
            this.gioiTinh1.Name = "gioiTinh1";
            this.gioiTinh1.Size = new System.Drawing.Size(67, 20);
            this.gioiTinh1.TabIndex = 22;
            this.gioiTinh1.Text = "Giới tính";
            // 
            // nuRadioButton
            // 
            this.nuRadioButton.AutoSize = true;
            this.nuRadioButton.Enabled = false;
            this.nuRadioButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nuRadioButton.Location = new System.Drawing.Point(198, 154);
            this.nuRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nuRadioButton.Name = "nuRadioButton";
            this.nuRadioButton.Size = new System.Drawing.Size(45, 20);
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
            this.namRadioButton.Location = new System.Drawing.Point(130, 154);
            this.namRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namRadioButton.Name = "namRadioButton";
            this.namRadioButton.Size = new System.Drawing.Size(57, 20);
            this.namRadioButton.TabIndex = 20;
            this.namRadioButton.TabStop = true;
            this.namRadioButton.Text = "Nam";
            this.namRadioButton.UseVisualStyleBackColor = true;
            // 
            // tinhTrangDiUngBox
            // 
            this.tinhTrangDiUngBox.Location = new System.Drawing.Point(640, 22);
            this.tinhTrangDiUngBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tinhTrangDiUngBox.Name = "tinhTrangDiUngBox";
            this.tinhTrangDiUngBox.ReadOnly = true;
            this.tinhTrangDiUngBox.Size = new System.Drawing.Size(284, 43);
            this.tinhTrangDiUngBox.TabIndex = 19;
            this.tinhTrangDiUngBox.Text = "";
            this.tinhTrangDiUngBox.TextChanged += new System.EventHandler(this.tinhTrangDiUngBox_TextChanged);
            // 
            // tinhTrangDiUng1
            // 
            this.tinhTrangDiUng1.AutoSize = true;
            this.tinhTrangDiUng1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhTrangDiUng1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tinhTrangDiUng1.Location = new System.Drawing.Point(509, 36);
            this.tinhTrangDiUng1.Margin = new System.Windows.Forms.Padding(0);
            this.tinhTrangDiUng1.Name = "tinhTrangDiUng1";
            this.tinhTrangDiUng1.Size = new System.Drawing.Size(128, 20);
            this.tinhTrangDiUng1.TabIndex = 18;
            this.tinhTrangDiUng1.Text = "Tình trạng dị ứng";
            // 
            // thongTinTongQuanBox
            // 
            this.thongTinTongQuanBox.Location = new System.Drawing.Point(640, 82);
            this.thongTinTongQuanBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thongTinTongQuanBox.Name = "thongTinTongQuanBox";
            this.thongTinTongQuanBox.ReadOnly = true;
            this.thongTinTongQuanBox.Size = new System.Drawing.Size(284, 43);
            this.thongTinTongQuanBox.TabIndex = 17;
            this.thongTinTongQuanBox.Text = "";
            this.thongTinTongQuanBox.TextChanged += new System.EventHandler(this.thongTinTongQuanBox_TextChanged);
            // 
            // thongTinTongQuan1
            // 
            this.thongTinTongQuan1.AutoSize = true;
            this.thongTinTongQuan1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongTinTongQuan1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.thongTinTongQuan1.Location = new System.Drawing.Point(487, 96);
            this.thongTinTongQuan1.Margin = new System.Windows.Forms.Padding(0);
            this.thongTinTongQuan1.Name = "thongTinTongQuan1";
            this.thongTinTongQuan1.Size = new System.Drawing.Size(150, 20);
            this.thongTinTongQuan1.TabIndex = 16;
            this.thongTinTongQuan1.Text = "Thông tin tổng quan";
            // 
            // benhNhanTable
            // 
            this.benhNhanTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.benhNhanTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.benhNhanTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.benhNhanTable.Location = new System.Drawing.Point(3, 236);
            this.benhNhanTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.benhNhanTable.Name = "benhNhanTable";
            this.benhNhanTable.ReadOnly = true;
            this.benhNhanTable.RowHeadersWidth = 51;
            this.benhNhanTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.benhNhanTable.Size = new System.Drawing.Size(1167, 367);
            this.benhNhanTable.TabIndex = 2;
            // 
            // DonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DonThuoc";
            this.Size = new System.Drawing.Size(1173, 605);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.InformationSection.ResumeLayout(false);
            this.InformationSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button themButton;
        private RichTextBox diaChiBox;
        private Label diaChi1;
        private Label ngaySinh1;
        private DateTimePicker ngaySinhBox;
        private Label sdt1;
        private TextBox sdtBox;
        private Label tenBenhNhan;
        private TextBox tenBenhNhanBox;
        private Label Label;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel InformationSection;
        private DataGridView benhNhanTable;
        private RichTextBox tinhTrangDiUngBox;
        private Label tinhTrangDiUng1;
        private RichTextBox thongTinTongQuanBox;
        private Label thongTinTongQuan1;
        private Label gioiTinh1;
        private RadioButton nuRadioButton;
        private RadioButton namRadioButton;
        private Button donThuocButton;
        private Label ngayKeDon1;
        private DateTimePicker ngayKeDonBox;
    }
}