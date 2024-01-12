using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLPHONGKHAM
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lichLamViecTable = new System.Windows.Forms.DataGridView();
            this.Label = new System.Windows.Forms.Label();
            this.InformationSection = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.idNhaSiSearchBox = new System.Windows.Forms.TextBox();
            this.gioKetThucBox = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.locButton = new System.Windows.Forms.Button();
            this.ngayradioButton = new System.Windows.Forms.RadioButton();
            this.tuanradioButton = new System.Windows.Forms.RadioButton();
            this.thangradioButton = new System.Windows.Forms.RadioButton();
            this.NgayKetThucTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ngayBatDauTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locLabel = new System.Windows.Forms.Label();
            this.gioBatDauBox = new System.Windows.Forms.DateTimePicker();
            this.gioLamViec = new System.Windows.Forms.Label();
            this.themButton = new System.Windows.Forms.Button();
            this.ngayLamViec = new System.Windows.Forms.Label();
            this.ngayLamViecBox = new System.Windows.Forms.DateTimePicker();
            this.iDNhaSi = new System.Windows.Forms.Label();
            this.iDNhaSiBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lichLamViecTable)).BeginInit();
            this.InformationSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lichLamViecTable, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.InformationSection, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.88044F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.1413F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1166, 617);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lichLamViecTable
            // 
            this.lichLamViecTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lichLamViecTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lichLamViecTable.Location = new System.Drawing.Point(3, 242);
            this.lichLamViecTable.Name = "lichLamViecTable";
            this.lichLamViecTable.ReadOnly = true;
            this.lichLamViecTable.RowHeadersWidth = 51;
            this.lichLamViecTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lichLamViecTable.Size = new System.Drawing.Size(1160, 372);
            this.lichLamViecTable.TabIndex = 2;
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
            this.Label.Size = new System.Drawing.Size(1166, 37);
            this.Label.TabIndex = 0;
            this.Label.Text = "LỊCH LÀM VIỆC";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InformationSection
            // 
            this.InformationSection.BackColor = System.Drawing.SystemColors.Control;
            this.InformationSection.Controls.Add(this.label4);
            this.InformationSection.Controls.Add(this.idNhaSiSearchBox);
            this.InformationSection.Controls.Add(this.gioKetThucBox);
            this.InformationSection.Controls.Add(this.label3);
            this.InformationSection.Controls.Add(this.label2);
            this.InformationSection.Controls.Add(this.label1);
            this.InformationSection.Controls.Add(this.locButton);
            this.InformationSection.Controls.Add(this.ngayradioButton);
            this.InformationSection.Controls.Add(this.tuanradioButton);
            this.InformationSection.Controls.Add(this.thangradioButton);
            this.InformationSection.Controls.Add(this.NgayKetThucTimePicker);
            this.InformationSection.Controls.Add(this.ngayBatDauTimePicker);
            this.InformationSection.Controls.Add(this.locLabel);
            this.InformationSection.Controls.Add(this.gioBatDauBox);
            this.InformationSection.Controls.Add(this.gioLamViec);
            this.InformationSection.Controls.Add(this.themButton);
            this.InformationSection.Controls.Add(this.ngayLamViec);
            this.InformationSection.Controls.Add(this.ngayLamViecBox);
            this.InformationSection.Controls.Add(this.iDNhaSi);
            this.InformationSection.Controls.Add(this.iDNhaSiBox);
            this.InformationSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationSection.Location = new System.Drawing.Point(0, 37);
            this.InformationSection.Margin = new System.Windows.Forms.Padding(0);
            this.InformationSection.Name = "InformationSection";
            this.InformationSection.Size = new System.Drawing.Size(1166, 202);
            this.InformationSection.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(18, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "ID Nha sĩ";
            // 
            // idNhaSiSearchBox
            // 
            this.idNhaSiSearchBox.Location = new System.Drawing.Point(112, 162);
            this.idNhaSiSearchBox.Name = "idNhaSiSearchBox";
            this.idNhaSiSearchBox.Size = new System.Drawing.Size(142, 26);
            this.idNhaSiSearchBox.TabIndex = 27;
            // 
            // gioKetThucBox
            // 
            this.gioKetThucBox.CustomFormat = "HH:mm:ss";
            this.gioKetThucBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.gioKetThucBox.Location = new System.Drawing.Point(603, 65);
            this.gioKetThucBox.Name = "gioKetThucBox";
            this.gioKetThucBox.Size = new System.Drawing.Size(173, 26);
            this.gioKetThucBox.TabIndex = 26;
            this.gioKetThucBox.Value = new System.DateTime(2024, 1, 2, 20, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(458, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Giờ kết thúc làm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(262, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Từ ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(508, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "đến ngày";
            // 
            // locButton
            // 
            this.locButton.BackColor = System.Drawing.Color.Teal;
            this.locButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.locButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locButton.ForeColor = System.Drawing.SystemColors.Window;
            this.locButton.Location = new System.Drawing.Point(1070, 158);
            this.locButton.Margin = new System.Windows.Forms.Padding(0);
            this.locButton.Name = "locButton";
            this.locButton.Size = new System.Drawing.Size(86, 32);
            this.locButton.TabIndex = 22;
            this.locButton.Text = "LỌC";
            this.locButton.UseVisualStyleBackColor = false;
            this.locButton.Click += new System.EventHandler(this.locButton_Click);
            // 
            // ngayradioButton
            // 
            this.ngayradioButton.AutoSize = true;
            this.ngayradioButton.BackColor = System.Drawing.SystemColors.Control;
            this.ngayradioButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ngayradioButton.Location = new System.Drawing.Point(968, 162);
            this.ngayradioButton.Name = "ngayradioButton";
            this.ngayradioButton.Size = new System.Drawing.Size(70, 24);
            this.ngayradioButton.TabIndex = 21;
            this.ngayradioButton.TabStop = true;
            this.ngayradioButton.Text = "Ngày";
            this.ngayradioButton.UseVisualStyleBackColor = false;
            // 
            // tuanradioButton
            // 
            this.tuanradioButton.AutoSize = true;
            this.tuanradioButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tuanradioButton.Location = new System.Drawing.Point(891, 162);
            this.tuanradioButton.Name = "tuanradioButton";
            this.tuanradioButton.Size = new System.Drawing.Size(70, 24);
            this.tuanradioButton.TabIndex = 20;
            this.tuanradioButton.TabStop = true;
            this.tuanradioButton.Text = "Tuần";
            this.tuanradioButton.UseVisualStyleBackColor = true;
            // 
            // thangradioButton
            // 
            this.thangradioButton.AutoSize = true;
            this.thangradioButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.thangradioButton.Location = new System.Drawing.Point(804, 162);
            this.thangradioButton.Name = "thangradioButton";
            this.thangradioButton.Size = new System.Drawing.Size(79, 24);
            this.thangradioButton.TabIndex = 19;
            this.thangradioButton.TabStop = true;
            this.thangradioButton.Text = "Tháng";
            this.thangradioButton.UseVisualStyleBackColor = true;
            // 
            // NgayKetThucTimePicker
            // 
            this.NgayKetThucTimePicker.CustomFormat = "dd/MM/yyyy";
            this.NgayKetThucTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayKetThucTimePicker.Location = new System.Drawing.Point(593, 161);
            this.NgayKetThucTimePicker.Name = "NgayKetThucTimePicker";
            this.NgayKetThucTimePicker.Size = new System.Drawing.Size(166, 26);
            this.NgayKetThucTimePicker.TabIndex = 18;
            // 
            // ngayBatDauTimePicker
            // 
            this.ngayBatDauTimePicker.CustomFormat = "dd/MM/yyyy";
            this.ngayBatDauTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayBatDauTimePicker.Location = new System.Drawing.Point(339, 161);
            this.ngayBatDauTimePicker.Name = "ngayBatDauTimePicker";
            this.ngayBatDauTimePicker.Size = new System.Drawing.Size(163, 26);
            this.ngayBatDauTimePicker.TabIndex = 17;
            // 
            // locLabel
            // 
            this.locLabel.AutoSize = true;
            this.locLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.locLabel.Location = new System.Drawing.Point(18, 128);
            this.locLabel.Margin = new System.Windows.Forms.Padding(0);
            this.locLabel.Name = "locLabel";
            this.locLabel.Size = new System.Drawing.Size(88, 25);
            this.locLabel.TabIndex = 16;
            this.locLabel.Text = "Chọn lịch";
            // 
            // gioBatDauBox
            // 
            this.gioBatDauBox.CustomFormat = "HH:mm:ss";
            this.gioBatDauBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.gioBatDauBox.Location = new System.Drawing.Point(603, 17);
            this.gioBatDauBox.Name = "gioBatDauBox";
            this.gioBatDauBox.Size = new System.Drawing.Size(173, 26);
            this.gioBatDauBox.TabIndex = 15;
            this.gioBatDauBox.Value = new System.DateTime(2024, 1, 2, 7, 0, 0, 0);
            // 
            // gioLamViec
            // 
            this.gioLamViec.AutoSize = true;
            this.gioLamViec.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioLamViec.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gioLamViec.Location = new System.Drawing.Point(458, 20);
            this.gioLamViec.Margin = new System.Windows.Forms.Padding(0);
            this.gioLamViec.Name = "gioLamViec";
            this.gioLamViec.Size = new System.Drawing.Size(144, 25);
            this.gioLamViec.TabIndex = 14;
            this.gioLamViec.Text = "Giờ bắt đầu làm";
            // 
            // themButton
            // 
            this.themButton.BackColor = System.Drawing.Color.Chocolate;
            this.themButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.themButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.themButton.Location = new System.Drawing.Point(849, 11);
            this.themButton.Margin = new System.Windows.Forms.Padding(0);
            this.themButton.Name = "themButton";
            this.themButton.Size = new System.Drawing.Size(199, 37);
            this.themButton.TabIndex = 13;
            this.themButton.Text = "THÊM";
            this.themButton.UseVisualStyleBackColor = false;
            this.themButton.Click += new System.EventHandler(this.themButton_Click);
            // 
            // ngayLamViec
            // 
            this.ngayLamViec.AutoSize = true;
            this.ngayLamViec.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayLamViec.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ngayLamViec.Location = new System.Drawing.Point(21, 72);
            this.ngayLamViec.Margin = new System.Windows.Forms.Padding(0);
            this.ngayLamViec.Name = "ngayLamViec";
            this.ngayLamViec.Size = new System.Drawing.Size(127, 25);
            this.ngayLamViec.TabIndex = 9;
            this.ngayLamViec.Text = "Ngày làm việc";
            // 
            // ngayLamViecBox
            // 
            this.ngayLamViecBox.CustomFormat = "yyyy-MM-dd";
            this.ngayLamViecBox.Location = new System.Drawing.Point(155, 67);
            this.ngayLamViecBox.Name = "ngayLamViecBox";
            this.ngayLamViecBox.Size = new System.Drawing.Size(275, 26);
            this.ngayLamViecBox.TabIndex = 8;
            this.ngayLamViecBox.Value = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            // 
            // iDNhaSi
            // 
            this.iDNhaSi.AutoSize = true;
            this.iDNhaSi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDNhaSi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.iDNhaSi.Location = new System.Drawing.Point(61, 17);
            this.iDNhaSi.Margin = new System.Windows.Forms.Padding(0);
            this.iDNhaSi.Name = "iDNhaSi";
            this.iDNhaSi.Size = new System.Drawing.Size(86, 25);
            this.iDNhaSi.TabIndex = 1;
            this.iDNhaSi.Text = "ID Nha sĩ";
            // 
            // iDNhaSiBox
            // 
            this.iDNhaSiBox.Location = new System.Drawing.Point(155, 15);
            this.iDNhaSiBox.Name = "iDNhaSiBox";
            this.iDNhaSiBox.Size = new System.Drawing.Size(252, 26);
            this.iDNhaSiBox.TabIndex = 0;
            // 
            // LichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LichLamViec";
            this.Size = new System.Drawing.Size(1166, 617);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lichLamViecTable)).EndInit();
            this.InformationSection.ResumeLayout(false);
            this.InformationSection.PerformLayout();
            this.ResumeLayout(false);

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
        private DateTimePicker gioBatDauBox;
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
        private DateTimePicker gioKetThucBox;
        private Label label3;
        private Label label4;
        private TextBox idNhaSiSearchBox;
    }
}
