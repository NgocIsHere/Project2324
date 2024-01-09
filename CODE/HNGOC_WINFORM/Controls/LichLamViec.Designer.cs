namespace QLPHONGKHAM.Controls
{
    partial class LichLamViec
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lichLamViecTable = new DataGridView();
            Label = new Label();
            InformationSection = new Panel();
            label2 = new Label();
            label1 = new Label();
            locButton = new Button();
            ngayradioButton = new RadioButton();
            tuanradioButton = new RadioButton();
            thangradioButton = new RadioButton();
            NgayKetThucTimePicker = new DateTimePicker();
            ngayBatDauTimePicker = new DateTimePicker();
            locLabel = new Label();
            gioLamViecBox = new DateTimePicker();
            gioLamViec = new Label();
            themButton = new Button();
            ngayLamViec = new Label();
            ngayLamViecBox = new DateTimePicker();
            iDNhaSi = new Label();
            iDNhaSiBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lichLamViecTable).BeginInit();
            InformationSection.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lichLamViecTable, 0, 2);
            tableLayoutPanel1.Controls.Add(Label, 0, 0);
            tableLayoutPanel1.Controls.Add(InformationSection, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.8804359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.141304F));
            tableLayoutPanel1.Size = new Size(1036, 617);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lichLamViecTable
            // 
            lichLamViecTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lichLamViecTable.Dock = DockStyle.Fill;
            lichLamViecTable.Location = new Point(3, 242);
            lichLamViecTable.Name = "lichLamViecTable";
            lichLamViecTable.ReadOnly = true;
            lichLamViecTable.RowHeadersWidth = 51;
            lichLamViecTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lichLamViecTable.Size = new Size(1030, 372);
            lichLamViecTable.TabIndex = 2;
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
            Label.Size = new Size(1036, 37);
            Label.TabIndex = 0;
            Label.Text = "LỊCH LÀM VIỆC";
            Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // InformationSection
            // 
            InformationSection.BackColor = SystemColors.Control;
            InformationSection.Controls.Add(label2);
            InformationSection.Controls.Add(label1);
            InformationSection.Controls.Add(locButton);
            InformationSection.Controls.Add(ngayradioButton);
            InformationSection.Controls.Add(tuanradioButton);
            InformationSection.Controls.Add(thangradioButton);
            InformationSection.Controls.Add(NgayKetThucTimePicker);
            InformationSection.Controls.Add(ngayBatDauTimePicker);
            InformationSection.Controls.Add(locLabel);
            InformationSection.Controls.Add(gioLamViecBox);
            InformationSection.Controls.Add(gioLamViec);
            InformationSection.Controls.Add(themButton);
            InformationSection.Controls.Add(ngayLamViec);
            InformationSection.Controls.Add(ngayLamViecBox);
            InformationSection.Controls.Add(iDNhaSi);
            InformationSection.Controls.Add(iDNhaSiBox);
            InformationSection.Dock = DockStyle.Fill;
            InformationSection.Location = new Point(0, 37);
            InformationSection.Margin = new Padding(0);
            InformationSection.Name = "InformationSection";
            InformationSection.Size = new Size(1036, 202);
            InformationSection.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(16, 170);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 24;
            label2.Text = "Từ ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(235, 170);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 23;
            label1.Text = "đến ngày";
            // 
            // locButton
            // 
            locButton.BackColor = Color.Teal;
            locButton.FlatStyle = FlatStyle.Popup;
            locButton.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            locButton.ForeColor = SystemColors.Window;
            locButton.Location = new Point(734, 162);
            locButton.Margin = new Padding(0);
            locButton.Name = "locButton";
            locButton.Size = new Size(76, 32);
            locButton.TabIndex = 22;
            locButton.Text = "LỌC";
            locButton.UseVisualStyleBackColor = false;
            locButton.Click += locButton_Click;
            // 
            // ngayradioButton
            // 
            ngayradioButton.AutoSize = true;
            ngayradioButton.BackColor = SystemColors.Control;
            ngayradioButton.ForeColor = SystemColors.WindowText;
            ngayradioButton.Location = new Point(643, 166);
            ngayradioButton.Name = "ngayradioButton";
            ngayradioButton.Size = new Size(65, 24);
            ngayradioButton.TabIndex = 21;
            ngayradioButton.TabStop = true;
            ngayradioButton.Text = "Ngày";
            ngayradioButton.UseVisualStyleBackColor = false;
            // 
            // tuanradioButton
            // 
            tuanradioButton.AutoSize = true;
            tuanradioButton.ForeColor = SystemColors.WindowText;
            tuanradioButton.Location = new Point(575, 166);
            tuanradioButton.Name = "tuanradioButton";
            tuanradioButton.Size = new Size(62, 24);
            tuanradioButton.TabIndex = 20;
            tuanradioButton.TabStop = true;
            tuanradioButton.Text = "Tuần";
            tuanradioButton.UseVisualStyleBackColor = true;
            // 
            // thangradioButton
            // 
            thangradioButton.AutoSize = true;
            thangradioButton.ForeColor = SystemColors.WindowText;
            thangradioButton.Location = new Point(498, 166);
            thangradioButton.Name = "thangradioButton";
            thangradioButton.Size = new Size(71, 24);
            thangradioButton.TabIndex = 19;
            thangradioButton.TabStop = true;
            thangradioButton.Text = "Tháng";
            thangradioButton.UseVisualStyleBackColor = true;
            // 
            // NgayKetThucTimePicker
            // 
            NgayKetThucTimePicker.CustomFormat = "dd/MM/yyyy";
            NgayKetThucTimePicker.Format = DateTimePickerFormat.Custom;
            NgayKetThucTimePicker.Location = new Point(310, 165);
            NgayKetThucTimePicker.Name = "NgayKetThucTimePicker";
            NgayKetThucTimePicker.Size = new Size(148, 27);
            NgayKetThucTimePicker.TabIndex = 18;
            // 
            // ngayBatDauTimePicker
            // 
            ngayBatDauTimePicker.CustomFormat = "dd/MM/yyyy";
            ngayBatDauTimePicker.Format = DateTimePickerFormat.Custom;
            ngayBatDauTimePicker.Location = new Point(84, 165);
            ngayBatDauTimePicker.Name = "ngayBatDauTimePicker";
            ngayBatDauTimePicker.Size = new Size(145, 27);
            ngayBatDauTimePicker.TabIndex = 17;
            // 
            // locLabel
            // 
            locLabel.AutoSize = true;
            locLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            locLabel.ForeColor = SystemColors.WindowText;
            locLabel.Location = new Point(16, 128);
            locLabel.Margin = new Padding(0);
            locLabel.Name = "locLabel";
            locLabel.Size = new Size(73, 20);
            locLabel.TabIndex = 16;
            locLabel.Text = "Chọn lịch";
            // 
            // gioLamViecBox
            // 
            gioLamViecBox.CustomFormat = "HH:mm:ss";
            gioLamViecBox.Format = DateTimePickerFormat.Time;
            gioLamViecBox.Location = new Point(565, 67);
            gioLamViecBox.Name = "gioLamViecBox";
            gioLamViecBox.Size = new Size(154, 27);
            gioLamViecBox.TabIndex = 15;
            gioLamViecBox.Value = new DateTime(2024, 1, 2, 17, 17, 0, 0);
            // 
            // gioLamViec
            // 
            gioLamViec.AutoSize = true;
            gioLamViec.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gioLamViec.ForeColor = SystemColors.WindowText;
            gioLamViec.Location = new Point(446, 74);
            gioLamViec.Margin = new Padding(0);
            gioLamViec.Name = "gioLamViec";
            gioLamViec.Size = new Size(92, 20);
            gioLamViec.TabIndex = 14;
            gioLamViec.Text = "Giờ làm việc";
            // 
            // themButton
            // 
            themButton.BackColor = Color.Chocolate;
            themButton.FlatStyle = FlatStyle.System;
            themButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            themButton.ForeColor = SystemColors.ButtonHighlight;
            themButton.Location = new Point(841, 44);
            themButton.Margin = new Padding(0);
            themButton.Name = "themButton";
            themButton.Size = new Size(177, 37);
            themButton.TabIndex = 13;
            themButton.Text = "THÊM";
            themButton.UseVisualStyleBackColor = false;
            themButton.Click += themButton_Click;
            // 
            // ngayLamViec
            // 
            ngayLamViec.AutoSize = true;
            ngayLamViec.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ngayLamViec.ForeColor = SystemColors.WindowText;
            ngayLamViec.Location = new Point(446, 22);
            ngayLamViec.Margin = new Padding(0);
            ngayLamViec.Name = "ngayLamViec";
            ngayLamViec.Size = new Size(106, 20);
            ngayLamViec.TabIndex = 9;
            ngayLamViec.Text = "Ngày làm việc";
            // 
            // ngayLamViecBox
            // 
            ngayLamViecBox.CustomFormat = "yyyy-MM-dd";
            ngayLamViecBox.Location = new Point(565, 17);
            ngayLamViecBox.Name = "ngayLamViecBox";
            ngayLamViecBox.Size = new Size(245, 27);
            ngayLamViecBox.TabIndex = 8;
            ngayLamViecBox.Value = new DateTime(2023, 12, 4, 0, 0, 0, 0);
            // 
            // iDNhaSi
            // 
            iDNhaSi.AutoSize = true;
            iDNhaSi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iDNhaSi.ForeColor = SystemColors.WindowText;
            iDNhaSi.Location = new Point(16, 22);
            iDNhaSi.Margin = new Padding(0);
            iDNhaSi.Name = "iDNhaSi";
            iDNhaSi.Size = new Size(71, 20);
            iDNhaSi.TabIndex = 1;
            iDNhaSi.Text = "ID Nha sĩ";
            // 
            // iDNhaSiBox
            // 
            iDNhaSiBox.Location = new Point(134, 15);
            iDNhaSiBox.Name = "iDNhaSiBox";
            iDNhaSiBox.Size = new Size(224, 27);
            iDNhaSiBox.TabIndex = 0;
            // 
            // LichLamViec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "LichLamViec";
            Size = new Size(1036, 617);
            Load += LichLamViec_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lichLamViecTable).EndInit();
            InformationSection.ResumeLayout(false);
            InformationSection.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Label;
        private Panel InformationSection;
        private Button capNhatButton;
        private Button xoaButton;
        private Button themButton;
        private Label ngayLamViec;
        private DateTimePicker ngayLamViecBox;
        private Label iDNhaSi;
        private TextBox iDNhaSiBox;
        private DataGridView lichLamViecTable;
        private DateTimePicker gioLamViecBox;
        private Label gioLamViec;
        private DateTimePicker NgayKetThucTimePicker;
        private DateTimePicker ngayBatDauTimePicker;
        private Label locLabel;
        private RadioButton ngayradioButton;
        private RadioButton tuanradioButton;
        private RadioButton thangradioButton;
        private Button locButton;
        private Label label2;
        private Label label1;
    }
}
