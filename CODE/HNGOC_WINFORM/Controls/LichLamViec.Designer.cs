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
            gioLamViecBox = new DateTimePicker();
            gioLamViec = new Label();
            themButton = new Button();
            hoVaTenBox = new RichTextBox();
            hoVaTen = new Label();
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
            lichLamViecTable.CellContentClick += lichLamViecTable_CellContentClick;
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
            InformationSection.Controls.Add(gioLamViecBox);
            InformationSection.Controls.Add(gioLamViec);
            InformationSection.Controls.Add(themButton);
            InformationSection.Controls.Add(hoVaTenBox);
            InformationSection.Controls.Add(hoVaTen);
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
            InformationSection.Paint += InformationSection_Paint;
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
            gioLamViecBox.ValueChanged += dateTimePicker1_ValueChanged;
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
            // hoVaTenBox
            // 
            hoVaTenBox.Location = new Point(134, 70);
            hoVaTenBox.Name = "hoVaTenBox";
            hoVaTenBox.Size = new Size(223, 24);
            hoVaTenBox.TabIndex = 12;
            hoVaTenBox.Text = "";
            hoVaTenBox.TextChanged += hoVaTenBox_TextChanged;
            // 
            // hoVaTen
            // 
            hoVaTen.AutoSize = true;
            hoVaTen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hoVaTen.ForeColor = SystemColors.WindowText;
            hoVaTen.Location = new Point(16, 74);
            hoVaTen.Margin = new Padding(0);
            hoVaTen.Name = "hoVaTen";
            hoVaTen.Size = new Size(75, 20);
            hoVaTen.TabIndex = 11;
            hoVaTen.Text = "Họ và tên";
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
            ngayLamViecBox.Size = new Size(224, 27);
            ngayLamViecBox.TabIndex = 8;
            ngayLamViecBox.Value = new DateTime(2023, 12, 4, 0, 0, 0, 0);
            ngayLamViecBox.ValueChanged += ngaySinhBox_ValueChanged;
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
        private RichTextBox hoVaTenBox;
        private Label hoVaTen;
        private Label ngayLamViec;
        private DateTimePicker ngayLamViecBox;
        private Label iDNhaSi;
        private TextBox iDNhaSiBox;
        private DataGridView lichLamViecTable;
        private DateTimePicker gioLamViecBox;
        private Label gioLamViec;
    }
}
