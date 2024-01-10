using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLPHONGKHAM.Controls
{
    partial class NhaSi
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
            nhaSiTable = new DataGridView();
            capNhatButton = new Button();
            xoaButton = new Button();
            themButton = new Button();
            hoVaTenBox = new RichTextBox();
            hoVaTen = new Label();
            ngaySinh = new Label();
            ngaySinhBox = new DateTimePicker();
            Label = new Label();
            soDienThoai = new Label();
            soDienThoaiBox = new TextBox();
            diaChi = new Label();
            diaChiBox = new TextBox();
            matKhau = new Label();
            matKhauBox = new TextBox();
            iDNhaSi = new Label();
            iDNhaSiBox = new TextBox();
            InformationSection = new Panel();
            gioiTinh = new Label();
            nuRadioButton = new RadioButton();
            namRadioButton = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)nhaSiTable).BeginInit();
            InformationSection.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // nhaSiTable
            // 
            nhaSiTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nhaSiTable.Dock = DockStyle.Fill;
            nhaSiTable.Location = new Point(3, 257);
            nhaSiTable.Name = "nhaSiTable";
            nhaSiTable.ReadOnly = true;
            nhaSiTable.RowHeadersWidth = 51;
            nhaSiTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            nhaSiTable.Size = new Size(1145, 396);
            nhaSiTable.TabIndex = 2;
            nhaSiTable.CellContentClick += nhaSiTable_CellContentClick;
            // 
            // capNhatButton
            // 
            capNhatButton.BackColor = Color.DarkTurquoise;
            capNhatButton.FlatStyle = FlatStyle.System;
            capNhatButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            capNhatButton.ForeColor = SystemColors.ActiveCaptionText;
            capNhatButton.Location = new Point(838, 161);
            capNhatButton.Name = "capNhatButton";
            capNhatButton.Size = new Size(177, 37);
            capNhatButton.TabIndex = 15;
            capNhatButton.Text = "CẬP NHẬT";
            capNhatButton.UseVisualStyleBackColor = false;
            capNhatButton.Click += capNhatButton_Click;
            // 
            // xoaButton
            // 
            xoaButton.BackColor = Color.LightCoral;
            xoaButton.FlatStyle = FlatStyle.System;
            xoaButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xoaButton.ForeColor = SystemColors.ControlLightLight;
            xoaButton.Location = new Point(838, 93);
            xoaButton.Name = "xoaButton";
            xoaButton.Size = new Size(177, 37);
            xoaButton.TabIndex = 14;
            xoaButton.Text = "XÓA";
            xoaButton.UseVisualStyleBackColor = false;
            xoaButton.Click += xoaButton_Click;
            // 
            // themButton
            // 
            themButton.BackColor = Color.Chocolate;
            themButton.FlatStyle = FlatStyle.System;
            themButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            themButton.ForeColor = SystemColors.ButtonHighlight;
            themButton.Location = new Point(838, 27);
            themButton.Margin = new Padding(0);
            themButton.Name = "themButton";
            themButton.Size = new Size(177, 37);
            themButton.TabIndex = 13;
            themButton.Text = "THÊM";
            themButton.UseVisualStyleBackColor = false;
            themButton.Click += themButton_Click;
            // 
            // hoVaTenBox
            // 
            hoVaTenBox.Location = new Point(534, 29);
            hoVaTenBox.Name = "hoVaTenBox";
            hoVaTenBox.Size = new Size(244, 24);
            hoVaTenBox.TabIndex = 12;
            hoVaTenBox.Text = "";
            // 
            // hoVaTen
            // 
            hoVaTen.AutoSize = true;
            hoVaTen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hoVaTen.ForeColor = SystemColors.WindowText;
            hoVaTen.Location = new Point(424, 32);
            hoVaTen.Margin = new Padding(0);
            hoVaTen.Name = "hoVaTen";
            hoVaTen.Size = new Size(75, 20);
            hoVaTen.TabIndex = 11;
            hoVaTen.Text = "Họ và tên";
            // 
            // ngaySinh
            // 
            ngaySinh.AutoSize = true;
            ngaySinh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ngaySinh.ForeColor = SystemColors.WindowText;
            ngaySinh.Location = new Point(424, 79);
            ngaySinh.Margin = new Padding(0);
            ngaySinh.Name = "ngaySinh";
            ngaySinh.Size = new Size(78, 20);
            ngaySinh.TabIndex = 9;
            ngaySinh.Text = "Ngày sinh";
            // 
            // ngaySinhBox
            // 
            ngaySinhBox.CustomFormat = "yyyy-MM-dd";
            ngaySinhBox.Location = new Point(534, 77);
            ngaySinhBox.Name = "ngaySinhBox";
            ngaySinhBox.Size = new Size(244, 27);
            ngaySinhBox.TabIndex = 8;
            ngaySinhBox.Value = new DateTime(2023, 12, 4, 0, 0, 0, 0);
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.BackColor = Color.Teal;
            Label.Dock = DockStyle.Fill;
            Label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label.ForeColor = Color.GhostWhite;
            Label.Location = new Point(0, 0);
            Label.Margin = new Padding(0);
            Label.Name = "Label";
            Label.Size = new Size(1151, 39);
            Label.TabIndex = 0;
            Label.Text = "NHA SĨ";
            Label.TextAlign = ContentAlignment.MiddleLeft;
            Label.Click += Label_Click;
            // 
            // soDienThoai
            // 
            soDienThoai.AutoSize = true;
            soDienThoai.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            soDienThoai.ForeColor = SystemColors.WindowText;
            soDienThoai.Location = new Point(16, 178);
            soDienThoai.Margin = new Padding(0);
            soDienThoai.Name = "soDienThoai";
            soDienThoai.Size = new Size(99, 20);
            soDienThoai.TabIndex = 7;
            soDienThoai.Text = "Số điện thoại";
            // 
            // soDienThoaiBox
            // 
            soDienThoaiBox.Location = new Point(156, 175);
            soDienThoaiBox.Name = "soDienThoaiBox";
            soDienThoaiBox.Size = new Size(224, 27);
            soDienThoaiBox.TabIndex = 6;
            // 
            // diaChi
            // 
            diaChi.AutoSize = true;
            diaChi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            diaChi.ForeColor = SystemColors.WindowText;
            diaChi.Location = new Point(16, 126);
            diaChi.Margin = new Padding(0);
            diaChi.Name = "diaChi";
            diaChi.Size = new Size(56, 20);
            diaChi.TabIndex = 5;
            diaChi.Text = "Địa chỉ";
            // 
            // diaChiBox
            // 
            diaChiBox.Location = new Point(156, 123);
            diaChiBox.Name = "diaChiBox";
            diaChiBox.Size = new Size(224, 27);
            diaChiBox.TabIndex = 4;
            // 
            // matKhau
            // 
            matKhau.AutoSize = true;
            matKhau.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            matKhau.ForeColor = SystemColors.WindowText;
            matKhau.Location = new Point(16, 75);
            matKhau.Margin = new Padding(0);
            matKhau.Name = "matKhau";
            matKhau.Size = new Size(74, 20);
            matKhau.TabIndex = 3;
            matKhau.Text = "Mật khẩu";
            // 
            // matKhauBox
            // 
            matKhauBox.Location = new Point(156, 72);
            matKhauBox.Name = "matKhauBox";
            matKhauBox.Size = new Size(224, 27);
            matKhauBox.TabIndex = 2;
            // 
            // iDNhaSi
            // 
            iDNhaSi.AutoSize = true;
            iDNhaSi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iDNhaSi.ForeColor = SystemColors.WindowText;
            iDNhaSi.Location = new Point(16, 28);
            iDNhaSi.Margin = new Padding(0);
            iDNhaSi.Name = "iDNhaSi";
            iDNhaSi.Size = new Size(71, 20);
            iDNhaSi.TabIndex = 1;
            iDNhaSi.Text = "ID Nha sĩ";
            // 
            // iDNhaSiBox
            // 
            iDNhaSiBox.Location = new Point(156, 25);
            iDNhaSiBox.Name = "iDNhaSiBox";
            iDNhaSiBox.Size = new Size(224, 27);
            iDNhaSiBox.TabIndex = 0;
            // 
            // InformationSection
            // 
            InformationSection.BackColor = SystemColors.Control;
            InformationSection.Controls.Add(gioiTinh);
            InformationSection.Controls.Add(nuRadioButton);
            InformationSection.Controls.Add(namRadioButton);
            InformationSection.Controls.Add(capNhatButton);
            InformationSection.Controls.Add(xoaButton);
            InformationSection.Controls.Add(themButton);
            InformationSection.Controls.Add(hoVaTenBox);
            InformationSection.Controls.Add(hoVaTen);
            InformationSection.Controls.Add(ngaySinh);
            InformationSection.Controls.Add(ngaySinhBox);
            InformationSection.Controls.Add(soDienThoai);
            InformationSection.Controls.Add(soDienThoaiBox);
            InformationSection.Controls.Add(diaChi);
            InformationSection.Controls.Add(diaChiBox);
            InformationSection.Controls.Add(matKhau);
            InformationSection.Controls.Add(matKhauBox);
            InformationSection.Controls.Add(iDNhaSi);
            InformationSection.Controls.Add(iDNhaSiBox);
            InformationSection.Dock = DockStyle.Fill;
            InformationSection.Location = new Point(0, 39);
            InformationSection.Margin = new Padding(0);
            InformationSection.Name = "InformationSection";
            InformationSection.Size = new Size(1151, 215);
            InformationSection.TabIndex = 1;
            InformationSection.Paint += InformationSection_Paint;
            // 
            // gioiTinh
            // 
            gioiTinh.AutoSize = true;
            gioiTinh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gioiTinh.ForeColor = SystemColors.WindowText;
            gioiTinh.Location = new Point(424, 124);
            gioiTinh.Margin = new Padding(0);
            gioiTinh.Name = "gioiTinh";
            gioiTinh.Size = new Size(67, 20);
            gioiTinh.TabIndex = 25;
            gioiTinh.Text = "Giới tính";
            // 
            // nuRadioButton
            // 
            nuRadioButton.AutoSize = true;
            nuRadioButton.ForeColor = SystemColors.WindowText;
            nuRadioButton.Location = new Point(612, 123);
            nuRadioButton.Name = "nuRadioButton";
            nuRadioButton.Size = new Size(50, 24);
            nuRadioButton.TabIndex = 24;
            nuRadioButton.TabStop = true;
            nuRadioButton.Text = "Nữ";
            nuRadioButton.UseVisualStyleBackColor = true;
            // 
            // namRadioButton
            // 
            namRadioButton.AutoSize = true;
            namRadioButton.ForeColor = SystemColors.WindowText;
            namRadioButton.Location = new Point(534, 122);
            namRadioButton.Name = "namRadioButton";
            namRadioButton.Size = new Size(62, 24);
            namRadioButton.TabIndex = 23;
            namRadioButton.TabStop = true;
            namRadioButton.Text = "Nam";
            namRadioButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Label, 0, 0);
            tableLayoutPanel1.Controls.Add(InformationSection, 0, 1);
            tableLayoutPanel1.Controls.Add(nhaSiTable, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.8804359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.141304F));
            tableLayoutPanel1.Size = new Size(1151, 656);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // NhaSi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "NhaSi";
            Size = new Size(1151, 656);
            Load += NhaSi_Load;
            ((System.ComponentModel.ISupportInitialize)nhaSiTable).EndInit();
            InformationSection.ResumeLayout(false);
            InformationSection.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView nhaSiTable;
        private Button capNhatButton;
        private Button xoaButton;
        private Button themButton;
        private RichTextBox hoVaTenBox;
        private Label hoVaTen;
        private Label ngaySinh;
        private DateTimePicker ngaySinhBox;
        private Label Label;
        private Label soDienThoai;
        private TextBox soDienThoaiBox;
        private Label diaChi;
        private TextBox diaChiBox;
        private Label matKhau;
        private TextBox matKhauBox;
        private Label iDNhaSi;
        private TextBox iDNhaSiBox;
        private Panel InformationSection;
        private TableLayoutPanel tableLayoutPanel1;
        private Label gioiTinh;
        private RadioButton nuRadioButton;
        private RadioButton namRadioButton;
    }
}
