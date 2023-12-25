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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            themButton = new Button();
            diaChiBox = new RichTextBox();
            diaChi1 = new Label();
            ngaySinh1 = new Label();
            ngaySinhBox = new DateTimePicker();
            sdt1 = new Label();
            sdtBox = new TextBox();
            tenBenhNhan = new Label();
            tenBenhNhanBox = new TextBox();
            Label = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            InformationSection = new Panel();
            ngayKeDon1 = new Label();
            ngayKeDonBox = new DateTimePicker();
            donThuocButton = new Button();
            gioiTinh1 = new Label();
            nuRadioButton = new RadioButton();
            namRadioButton = new RadioButton();
            tinhTrangDiUngBox = new RichTextBox();
            tinhTrangDiUng1 = new Label();
            thongTinTongQuanBox = new RichTextBox();
            thongTinTongQuan1 = new Label();
            benhNhanTable = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            InformationSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)benhNhanTable).BeginInit();
            SuspendLayout();
            // 
            // themButton
            // 
            themButton.BackColor = Color.Chocolate;
            themButton.FlatStyle = FlatStyle.System;
            themButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            themButton.ForeColor = SystemColors.ButtonHighlight;
            themButton.Location = new Point(993, 85);
            themButton.Margin = new Padding(0);
            themButton.Name = "themButton";
            themButton.Size = new Size(164, 54);
            themButton.TabIndex = 13;
            themButton.Text = "KÊ ĐƠN";
            themButton.UseVisualStyleBackColor = false;
            themButton.Click += themButton_Click;
            // 
            // diaChiBox
            // 
            diaChiBox.Location = new Point(640, 177);
            diaChiBox.Name = "diaChiBox";
            diaChiBox.Size = new Size(284, 53);
            diaChiBox.TabIndex = 12;
            diaChiBox.Text = "";
            // 
            // diaChi1
            // 
            diaChi1.AutoSize = true;
            diaChi1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            diaChi1.ForeColor = SystemColors.WindowText;
            diaChi1.Location = new Point(581, 196);
            diaChi1.Margin = new Padding(0);
            diaChi1.Name = "diaChi1";
            diaChi1.Size = new Size(56, 20);
            diaChi1.TabIndex = 11;
            diaChi1.Text = "Địa chỉ";
            // 
            // ngaySinh1
            // 
            ngaySinh1.AutoSize = true;
            ngaySinh1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ngaySinh1.ForeColor = SystemColors.WindowText;
            ngaySinh1.Location = new Point(49, 133);
            ngaySinh1.Margin = new Padding(0);
            ngaySinh1.Name = "ngaySinh1";
            ngaySinh1.Size = new Size(78, 20);
            ngaySinh1.TabIndex = 9;
            ngaySinh1.Text = "Ngày sinh";
            // 
            // ngaySinhBox
            // 
            ngaySinhBox.CustomFormat = "yyyy-MM-dd";
            ngaySinhBox.Format = DateTimePickerFormat.Custom;
            ngaySinhBox.Location = new Point(130, 128);
            ngaySinhBox.Name = "ngaySinhBox";
            ngaySinhBox.Size = new Size(126, 27);
            ngaySinhBox.TabIndex = 8;
            ngaySinhBox.Value = new DateTime(2023, 12, 4, 0, 0, 0, 0);
            // 
            // sdt1
            // 
            sdt1.AutoSize = true;
            sdt1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sdt1.ForeColor = SystemColors.WindowText;
            sdt1.Location = new Point(28, 75);
            sdt1.Margin = new Padding(0);
            sdt1.Name = "sdt1";
            sdt1.Size = new Size(99, 20);
            sdt1.TabIndex = 3;
            sdt1.Text = "Số điện thoại";
            // 
            // sdtBox
            // 
            sdtBox.Location = new Point(130, 72);
            sdtBox.Name = "sdtBox";
            sdtBox.Size = new Size(224, 27);
            sdtBox.TabIndex = 2;
            // 
            // tenBenhNhan
            // 
            tenBenhNhan.AutoSize = true;
            tenBenhNhan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tenBenhNhan.ForeColor = SystemColors.WindowText;
            tenBenhNhan.Location = new Point(16, 28);
            tenBenhNhan.Margin = new Padding(0);
            tenBenhNhan.Name = "tenBenhNhan";
            tenBenhNhan.Size = new Size(111, 20);
            tenBenhNhan.TabIndex = 1;
            tenBenhNhan.Text = "Tên bệnh nhân";
            // 
            // tenBenhNhanBox
            // 
            tenBenhNhanBox.Location = new Point(130, 25);
            tenBenhNhanBox.Name = "tenBenhNhanBox";
            tenBenhNhanBox.Size = new Size(224, 27);
            tenBenhNhanBox.TabIndex = 0;
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
            Label.Size = new Size(1173, 45);
            Label.TabIndex = 0;
            Label.Text = "ĐƠN THUỐC";
            Label.TextAlign = ContentAlignment.MiddleLeft;
            Label.Click += Label_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Label, 0, 0);
            tableLayoutPanel1.Controls.Add(InformationSection, 0, 1);
            tableLayoutPanel1.Controls.Add(benhNhanTable, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.8804359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.141304F));
            tableLayoutPanel1.Size = new Size(1173, 756);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // InformationSection
            // 
            InformationSection.BackColor = SystemColors.Control;
            InformationSection.Controls.Add(ngayKeDon1);
            InformationSection.Controls.Add(ngayKeDonBox);
            InformationSection.Controls.Add(donThuocButton);
            InformationSection.Controls.Add(gioiTinh1);
            InformationSection.Controls.Add(nuRadioButton);
            InformationSection.Controls.Add(namRadioButton);
            InformationSection.Controls.Add(tinhTrangDiUngBox);
            InformationSection.Controls.Add(tinhTrangDiUng1);
            InformationSection.Controls.Add(thongTinTongQuanBox);
            InformationSection.Controls.Add(thongTinTongQuan1);
            InformationSection.Controls.Add(themButton);
            InformationSection.Controls.Add(diaChiBox);
            InformationSection.Controls.Add(diaChi1);
            InformationSection.Controls.Add(ngaySinh1);
            InformationSection.Controls.Add(ngaySinhBox);
            InformationSection.Controls.Add(sdt1);
            InformationSection.Controls.Add(sdtBox);
            InformationSection.Controls.Add(tenBenhNhan);
            InformationSection.Controls.Add(tenBenhNhanBox);
            InformationSection.Dock = DockStyle.Fill;
            InformationSection.Location = new Point(0, 45);
            InformationSection.Margin = new Padding(0);
            InformationSection.Name = "InformationSection";
            InformationSection.Size = new Size(1173, 248);
            InformationSection.TabIndex = 1;
            // 
            // ngayKeDon1
            // 
            ngayKeDon1.AutoSize = true;
            ngayKeDon1.ForeColor = SystemColors.WindowText;
            ngayKeDon1.Location = new Point(993, 45);
            ngayKeDon1.Name = "ngayKeDon1";
            ngayKeDon1.Size = new Size(93, 20);
            ngayKeDon1.TabIndex = 25;
            ngayKeDon1.Text = "Ngày kê đơn";
            // 
            // ngayKeDonBox
            // 
            ngayKeDonBox.Format = DateTimePickerFormat.Custom;
            ngayKeDonBox.Location = new Point(1092, 40);
            ngayKeDonBox.Name = "ngayKeDonBox";
            ngayKeDonBox.Size = new Size(113, 27);
            ngayKeDonBox.TabIndex = 24;
            // 
            // donThuocButton
            // 
            donThuocButton.BackColor = Color.Chocolate;
            donThuocButton.FlatStyle = FlatStyle.System;
            donThuocButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            donThuocButton.ForeColor = SystemColors.ButtonHighlight;
            donThuocButton.Location = new Point(993, 162);
            donThuocButton.Margin = new Padding(0);
            donThuocButton.Name = "donThuocButton";
            donThuocButton.Size = new Size(164, 68);
            donThuocButton.TabIndex = 23;
            donThuocButton.Text = "XEM ĐƠN THUỐC";
            donThuocButton.UseVisualStyleBackColor = false;
            donThuocButton.Click += donThuocButton_Click;
            // 
            // gioiTinh1
            // 
            gioiTinh1.AutoSize = true;
            gioiTinh1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gioiTinh1.ForeColor = SystemColors.WindowText;
            gioiTinh1.Location = new Point(60, 193);
            gioiTinh1.Margin = new Padding(0);
            gioiTinh1.Name = "gioiTinh1";
            gioiTinh1.Size = new Size(67, 20);
            gioiTinh1.TabIndex = 22;
            gioiTinh1.Text = "Giới tính";
            // 
            // nuRadioButton
            // 
            nuRadioButton.AutoSize = true;
            nuRadioButton.ForeColor = SystemColors.WindowText;
            nuRadioButton.Location = new Point(198, 193);
            nuRadioButton.Name = "nuRadioButton";
            nuRadioButton.Size = new Size(50, 24);
            nuRadioButton.TabIndex = 21;
            nuRadioButton.TabStop = true;
            nuRadioButton.Text = "Nữ";
            nuRadioButton.UseVisualStyleBackColor = true;
            // 
            // namRadioButton
            // 
            namRadioButton.AutoSize = true;
            namRadioButton.ForeColor = SystemColors.WindowText;
            namRadioButton.Location = new Point(130, 192);
            namRadioButton.Name = "namRadioButton";
            namRadioButton.Size = new Size(62, 24);
            namRadioButton.TabIndex = 20;
            namRadioButton.TabStop = true;
            namRadioButton.Text = "Nam";
            namRadioButton.UseVisualStyleBackColor = true;
            // 
            // tinhTrangDiUngBox
            // 
            tinhTrangDiUngBox.Location = new Point(640, 28);
            tinhTrangDiUngBox.Name = "tinhTrangDiUngBox";
            tinhTrangDiUngBox.Size = new Size(284, 53);
            tinhTrangDiUngBox.TabIndex = 19;
            tinhTrangDiUngBox.Text = "";
            // 
            // tinhTrangDiUng1
            // 
            tinhTrangDiUng1.AutoSize = true;
            tinhTrangDiUng1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tinhTrangDiUng1.ForeColor = SystemColors.WindowText;
            tinhTrangDiUng1.Location = new Point(509, 45);
            tinhTrangDiUng1.Margin = new Padding(0);
            tinhTrangDiUng1.Name = "tinhTrangDiUng1";
            tinhTrangDiUng1.Size = new Size(128, 20);
            tinhTrangDiUng1.TabIndex = 18;
            tinhTrangDiUng1.Text = "Tình trạng dị ứng";
            // 
            // thongTinTongQuanBox
            // 
            thongTinTongQuanBox.Location = new Point(640, 102);
            thongTinTongQuanBox.Name = "thongTinTongQuanBox";
            thongTinTongQuanBox.Size = new Size(284, 53);
            thongTinTongQuanBox.TabIndex = 17;
            thongTinTongQuanBox.Text = "";
            // 
            // thongTinTongQuan1
            // 
            thongTinTongQuan1.AutoSize = true;
            thongTinTongQuan1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            thongTinTongQuan1.ForeColor = SystemColors.WindowText;
            thongTinTongQuan1.Location = new Point(487, 120);
            thongTinTongQuan1.Margin = new Padding(0);
            thongTinTongQuan1.Name = "thongTinTongQuan1";
            thongTinTongQuan1.Size = new Size(150, 20);
            thongTinTongQuan1.TabIndex = 16;
            thongTinTongQuan1.Text = "Thông tin tổng quan";
            // 
            // benhNhanTable
            // 
            benhNhanTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            benhNhanTable.DefaultCellStyle = dataGridViewCellStyle1;
            benhNhanTable.Dock = DockStyle.Fill;
            benhNhanTable.Location = new Point(3, 296);
            benhNhanTable.Name = "benhNhanTable";
            benhNhanTable.ReadOnly = true;
            benhNhanTable.RowHeadersWidth = 51;
            benhNhanTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            benhNhanTable.Size = new Size(1167, 457);
            benhNhanTable.TabIndex = 2;
            benhNhanTable.CellContentClick += benhNhanTable_CellContentClick;
            // 
            // DonThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "DonThuoc";
            Size = new Size(1173, 756);
            Load += DonThuoc_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            InformationSection.ResumeLayout(false);
            InformationSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)benhNhanTable).EndInit();
            ResumeLayout(false);
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