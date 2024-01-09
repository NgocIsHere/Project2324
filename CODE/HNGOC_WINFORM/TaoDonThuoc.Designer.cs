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
            buttonPanel = new Panel();
            huyButton = new Button();
            hoanThanhButton = new Button();
            donThuocControlPanel = new Panel();
            searchThuocButton = new Button();
            searchThuocBox = new TextBox();
            searchThuocLabel = new Label();
            tenThuocBox = new TextBox();
            xoaThuocButton = new Button();
            themThuocButton = new Button();
            maDonThuocBox = new TextBox();
            maDonThuoc1 = new Label();
            soLuongThuocBox = new TextBox();
            soLuongThuoc1 = new Label();
            tenThuoc1 = new Label();
            chiTietDonTable = new DataGridView();
            thongTinBenhAn = new Panel();
            InformationSection = new Panel();
            ngayKeDon1 = new Label();
            ngayKeDonBox = new DateTimePicker();
            gioiTinh1 = new Label();
            nuRadioButton = new RadioButton();
            namRadioButton = new RadioButton();
            tinhTrangDiUngBox = new RichTextBox();
            tinhTrangDiUng1 = new Label();
            thongTinTongQuanBox = new RichTextBox();
            thongTinTongQuan1 = new Label();
            diaChiBox = new RichTextBox();
            diaChi1 = new Label();
            ngaySinh1 = new Label();
            ngaySinhBox = new DateTimePicker();
            sdt1 = new Label();
            sdtBox = new TextBox();
            tenBenhNhan = new Label();
            tenBenhNhanBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            searchThuocTable = new DataGridView();
            ghiChuThuocLabel = new Label();
            ghiChuThuocBox = new RichTextBox();
            buttonPanel.SuspendLayout();
            donThuocControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chiTietDonTable).BeginInit();
            thongTinBenhAn.SuspendLayout();
            InformationSection.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchThuocTable).BeginInit();
            SuspendLayout();
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = SystemColors.ActiveCaption;
            buttonPanel.Controls.Add(huyButton);
            buttonPanel.Controls.Add(hoanThanhButton);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(0, 634);
            buttonPanel.Margin = new Padding(0);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(1492, 71);
            buttonPanel.TabIndex = 3;
            // 
            // huyButton
            // 
            huyButton.Location = new Point(853, 17);
            huyButton.Margin = new Padding(0);
            huyButton.Name = "huyButton";
            huyButton.Size = new Size(124, 34);
            huyButton.TabIndex = 1;
            huyButton.Text = "Hủy";
            huyButton.UseVisualStyleBackColor = true;
            huyButton.Click += huyButton_Click;
            // 
            // hoanThanhButton
            // 
            hoanThanhButton.Location = new Point(1018, 17);
            hoanThanhButton.Margin = new Padding(0);
            hoanThanhButton.Name = "hoanThanhButton";
            hoanThanhButton.Size = new Size(136, 34);
            hoanThanhButton.TabIndex = 0;
            hoanThanhButton.Text = "Hoàn thành";
            hoanThanhButton.UseVisualStyleBackColor = true;
            hoanThanhButton.Click += hoanThanhButton_Click;
            // 
            // donThuocControlPanel
            // 
            donThuocControlPanel.BackColor = SystemColors.ActiveCaption;
            donThuocControlPanel.Controls.Add(ghiChuThuocBox);
            donThuocControlPanel.Controls.Add(ghiChuThuocLabel);
            donThuocControlPanel.Controls.Add(searchThuocButton);
            donThuocControlPanel.Controls.Add(searchThuocBox);
            donThuocControlPanel.Controls.Add(searchThuocLabel);
            donThuocControlPanel.Controls.Add(tenThuocBox);
            donThuocControlPanel.Controls.Add(xoaThuocButton);
            donThuocControlPanel.Controls.Add(themThuocButton);
            donThuocControlPanel.Controls.Add(maDonThuocBox);
            donThuocControlPanel.Controls.Add(maDonThuoc1);
            donThuocControlPanel.Controls.Add(soLuongThuocBox);
            donThuocControlPanel.Controls.Add(soLuongThuoc1);
            donThuocControlPanel.Controls.Add(tenThuoc1);
            donThuocControlPanel.Dock = DockStyle.Fill;
            donThuocControlPanel.Location = new Point(0, 211);
            donThuocControlPanel.Margin = new Padding(0);
            donThuocControlPanel.Name = "donThuocControlPanel";
            donThuocControlPanel.Size = new Size(1492, 141);
            donThuocControlPanel.TabIndex = 1;
            // 
            // searchThuocButton
            // 
            searchThuocButton.BackColor = SystemColors.MenuHighlight;
            searchThuocButton.FlatStyle = FlatStyle.Popup;
            searchThuocButton.ForeColor = SystemColors.ButtonHighlight;
            searchThuocButton.Location = new Point(1382, 79);
            searchThuocButton.Name = "searchThuocButton";
            searchThuocButton.Size = new Size(87, 29);
            searchThuocButton.TabIndex = 11;
            searchThuocButton.Text = "Tìm";
            searchThuocButton.UseVisualStyleBackColor = false;
            searchThuocButton.Click += searchThuocButton_Click;
            // 
            // searchThuocBox
            // 
            searchThuocBox.Location = new Point(1154, 79);
            searchThuocBox.Name = "searchThuocBox";
            searchThuocBox.Size = new Size(206, 27);
            searchThuocBox.TabIndex = 10;
            // 
            // searchThuocLabel
            // 
            searchThuocLabel.AutoSize = true;
            searchThuocLabel.ForeColor = SystemColors.WindowText;
            searchThuocLabel.Location = new Point(1150, 46);
            searchThuocLabel.Name = "searchThuocLabel";
            searchThuocLabel.Size = new Size(78, 20);
            searchThuocLabel.TabIndex = 9;
            searchThuocLabel.Text = "Tìm thuốc:";
            // 
            // tenThuocBox
            // 
            tenThuocBox.Location = new Point(657, 43);
            tenThuocBox.Name = "tenThuocBox";
            tenThuocBox.Size = new Size(203, 27);
            tenThuocBox.TabIndex = 8;
            // 
            // xoaThuocButton
            // 
            xoaThuocButton.ForeColor = SystemColors.WindowText;
            xoaThuocButton.Location = new Point(379, 46);
            xoaThuocButton.Name = "xoaThuocButton";
            xoaThuocButton.Size = new Size(143, 60);
            xoaThuocButton.TabIndex = 7;
            xoaThuocButton.Text = "Xóa thuốc";
            xoaThuocButton.UseVisualStyleBackColor = true;
            xoaThuocButton.Click += xoaThuocButton_Click;
            // 
            // themThuocButton
            // 
            themThuocButton.ForeColor = SystemColors.WindowText;
            themThuocButton.Location = new Point(204, 46);
            themThuocButton.Name = "themThuocButton";
            themThuocButton.Size = new Size(150, 60);
            themThuocButton.TabIndex = 6;
            themThuocButton.Text = "Thêm thuốc";
            themThuocButton.UseVisualStyleBackColor = true;
            themThuocButton.Click += themThuocButton_Click;
            // 
            // maDonThuocBox
            // 
            maDonThuocBox.BackColor = SystemColors.ActiveCaption;
            maDonThuocBox.BorderStyle = BorderStyle.None;
            maDonThuocBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maDonThuocBox.Location = new Point(9, 62);
            maDonThuocBox.Margin = new Padding(0);
            maDonThuocBox.Name = "maDonThuocBox";
            maDonThuocBox.Size = new Size(176, 24);
            maDonThuocBox.TabIndex = 5;
            // 
            // maDonThuoc1
            // 
            maDonThuoc1.AutoSize = true;
            maDonThuoc1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maDonThuoc1.ForeColor = SystemColors.WindowText;
            maDonThuoc1.Location = new Point(12, 15);
            maDonThuoc1.Name = "maDonThuoc1";
            maDonThuoc1.Size = new Size(146, 28);
            maDonThuoc1.TabIndex = 4;
            maDonThuoc1.Text = "Mã đơn thuốc";
            // 
            // soLuongThuocBox
            // 
            soLuongThuocBox.Location = new Point(657, 79);
            soLuongThuocBox.Name = "soLuongThuocBox";
            soLuongThuocBox.Size = new Size(203, 27);
            soLuongThuocBox.TabIndex = 3;
            // 
            // soLuongThuoc1
            // 
            soLuongThuoc1.AutoSize = true;
            soLuongThuoc1.Location = new Point(557, 82);
            soLuongThuoc1.Name = "soLuongThuoc1";
            soLuongThuoc1.Size = new Size(69, 20);
            soLuongThuoc1.TabIndex = 2;
            soLuongThuoc1.Text = "Số lượng";
            soLuongThuoc1.Click += soLuongThuoc1_Click;
            // 
            // tenThuoc1
            // 
            tenThuoc1.AutoSize = true;
            tenThuoc1.ForeColor = SystemColors.WindowText;
            tenThuoc1.Location = new Point(553, 46);
            tenThuoc1.Name = "tenThuoc1";
            tenThuoc1.Size = new Size(73, 20);
            tenThuoc1.TabIndex = 0;
            tenThuoc1.Text = "Tên thuốc";
            // 
            // chiTietDonTable
            // 
            chiTietDonTable.AllowUserToOrderColumns = true;
            chiTietDonTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            chiTietDonTable.Dock = DockStyle.Fill;
            chiTietDonTable.Location = new Point(0, 0);
            chiTietDonTable.Margin = new Padding(0);
            chiTietDonTable.Name = "chiTietDonTable";
            chiTietDonTable.ReadOnly = true;
            chiTietDonTable.RowHeadersWidth = 51;
            chiTietDonTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            chiTietDonTable.Size = new Size(743, 276);
            chiTietDonTable.TabIndex = 2;
            chiTietDonTable.CellContentClick += chiTietDonTable_CellContentClick;
            // 
            // thongTinBenhAn
            // 
            thongTinBenhAn.Controls.Add(InformationSection);
            thongTinBenhAn.Dock = DockStyle.Fill;
            thongTinBenhAn.Location = new Point(0, 0);
            thongTinBenhAn.Margin = new Padding(0);
            thongTinBenhAn.Name = "thongTinBenhAn";
            thongTinBenhAn.Size = new Size(1492, 211);
            thongTinBenhAn.TabIndex = 0;
            // 
            // InformationSection
            // 
            InformationSection.BackColor = SystemColors.Control;
            InformationSection.Controls.Add(ngayKeDon1);
            InformationSection.Controls.Add(ngayKeDonBox);
            InformationSection.Controls.Add(gioiTinh1);
            InformationSection.Controls.Add(nuRadioButton);
            InformationSection.Controls.Add(namRadioButton);
            InformationSection.Controls.Add(tinhTrangDiUngBox);
            InformationSection.Controls.Add(tinhTrangDiUng1);
            InformationSection.Controls.Add(thongTinTongQuanBox);
            InformationSection.Controls.Add(thongTinTongQuan1);
            InformationSection.Controls.Add(diaChiBox);
            InformationSection.Controls.Add(diaChi1);
            InformationSection.Controls.Add(ngaySinh1);
            InformationSection.Controls.Add(ngaySinhBox);
            InformationSection.Controls.Add(sdt1);
            InformationSection.Controls.Add(sdtBox);
            InformationSection.Controls.Add(tenBenhNhan);
            InformationSection.Controls.Add(tenBenhNhanBox);
            InformationSection.Dock = DockStyle.Fill;
            InformationSection.Location = new Point(0, 0);
            InformationSection.Margin = new Padding(0);
            InformationSection.Name = "InformationSection";
            InformationSection.Size = new Size(1492, 211);
            InformationSection.TabIndex = 2;
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
            ngayKeDonBox.Enabled = false;
            ngayKeDonBox.Format = DateTimePickerFormat.Custom;
            ngayKeDonBox.Location = new Point(993, 75);
            ngayKeDonBox.Name = "ngayKeDonBox";
            ngayKeDonBox.Size = new Size(129, 27);
            ngayKeDonBox.TabIndex = 24;
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
            nuRadioButton.Enabled = false;
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
            namRadioButton.Enabled = false;
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
            tinhTrangDiUngBox.ReadOnly = true;
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
            thongTinTongQuanBox.ReadOnly = true;
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
            // diaChiBox
            // 
            diaChiBox.Location = new Point(640, 177);
            diaChiBox.Name = "diaChiBox";
            diaChiBox.ReadOnly = true;
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
            ngaySinhBox.Enabled = false;
            ngaySinhBox.Format = DateTimePickerFormat.Custom;
            ngaySinhBox.Location = new Point(130, 128);
            ngaySinhBox.Name = "ngaySinhBox";
            ngaySinhBox.Size = new Size(133, 27);
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
            sdtBox.ReadOnly = true;
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
            tenBenhNhanBox.ReadOnly = true;
            tenBenhNhanBox.Size = new Size(224, 27);
            tenBenhNhanBox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(thongTinBenhAn, 0, 0);
            tableLayoutPanel1.Controls.Add(donThuocControlPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonPanel, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1492, 705);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(chiTietDonTable, 0, 0);
            tableLayoutPanel2.Controls.Add(searchThuocTable, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 355);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1486, 276);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // searchThuocTable
            // 
            searchThuocTable.AllowUserToAddRows = false;
            searchThuocTable.AllowUserToDeleteRows = false;
            searchThuocTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchThuocTable.Dock = DockStyle.Fill;
            searchThuocTable.GridColor = Color.Thistle;
            searchThuocTable.Location = new Point(748, 0);
            searchThuocTable.Margin = new Padding(5, 0, 0, 0);
            searchThuocTable.MultiSelect = false;
            searchThuocTable.Name = "searchThuocTable";
            searchThuocTable.ReadOnly = true;
            searchThuocTable.RowHeadersWidth = 51;
            searchThuocTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchThuocTable.Size = new Size(738, 276);
            searchThuocTable.TabIndex = 3;
            searchThuocTable.CellContentClick += searchThuocTable_CellContentClick;
            // 
            // ghiChuThuocLabel
            // 
            ghiChuThuocLabel.AutoSize = true;
            ghiChuThuocLabel.Location = new Point(896, 46);
            ghiChuThuocLabel.Name = "ghiChuThuocLabel";
            ghiChuThuocLabel.Size = new Size(58, 20);
            ghiChuThuocLabel.TabIndex = 12;
            ghiChuThuocLabel.Text = "Ghi chú";
            // 
            // ghiChuThuocBox
            // 
            ghiChuThuocBox.Location = new Point(962, 44);
            ghiChuThuocBox.Name = "ghiChuThuocBox";
            ghiChuThuocBox.Size = new Size(160, 63);
            ghiChuThuocBox.TabIndex = 13;
            ghiChuThuocBox.Text = "";
            // 
            // TaoDonThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 705);
            Controls.Add(tableLayoutPanel1);
            Name = "TaoDonThuoc";
            Text = "CHI TIẾT ĐƠN";
            FormClosed += TaoDonThuoc_FormClosed;
            Load += TaoDonThuoc_Load;
            buttonPanel.ResumeLayout(false);
            donThuocControlPanel.ResumeLayout(false);
            donThuocControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chiTietDonTable).EndInit();
            thongTinBenhAn.ResumeLayout(false);
            InformationSection.ResumeLayout(false);
            InformationSection.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)searchThuocTable).EndInit();
            ResumeLayout(false);
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