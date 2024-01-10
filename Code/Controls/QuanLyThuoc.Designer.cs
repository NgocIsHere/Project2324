using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLPHONGKHAM.Controls
{
    partial class QuanLyThuoc
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Label = new Label();
            InformationSection = new Panel();
            capNhatButton = new Button();
            xoaButton = new Button();
            themButton = new Button();
            ghiChuBox = new RichTextBox();
            ghiChu = new Label();
            hanSuDung = new Label();
            hanSuDungBox = new DateTimePicker();
            soLuong = new Label();
            soLuongBox = new TextBox();
            donVi = new Label();
            donViBox = new TextBox();
            donGia = new Label();
            donGiaBox = new TextBox();
            tenThuoc = new Label();
            tenThuocBox = new TextBox();
            thuocTable = new DataGridView();
            searchThuocButton = new Button();
            searchThuocBox = new TextBox();
            searchThuocLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            InformationSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)thuocTable).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Label, 0, 0);
            tableLayoutPanel1.Controls.Add(InformationSection, 0, 1);
            tableLayoutPanel1.Controls.Add(thuocTable, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54F));
            tableLayoutPanel1.Size = new Size(1079, 736);
            tableLayoutPanel1.TabIndex = 0;
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
            Label.Size = new Size(1079, 44);
            Label.TabIndex = 0;
            Label.Text = "QUẢN LÝ THUỐC";
            Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // InformationSection
            // 
            InformationSection.BackColor = SystemColors.Control;
            InformationSection.Controls.Add(searchThuocButton);
            InformationSection.Controls.Add(searchThuocBox);
            InformationSection.Controls.Add(searchThuocLabel);
            InformationSection.Controls.Add(capNhatButton);
            InformationSection.Controls.Add(xoaButton);
            InformationSection.Controls.Add(themButton);
            InformationSection.Controls.Add(ghiChuBox);
            InformationSection.Controls.Add(ghiChu);
            InformationSection.Controls.Add(hanSuDung);
            InformationSection.Controls.Add(hanSuDungBox);
            InformationSection.Controls.Add(soLuong);
            InformationSection.Controls.Add(soLuongBox);
            InformationSection.Controls.Add(donVi);
            InformationSection.Controls.Add(donViBox);
            InformationSection.Controls.Add(donGia);
            InformationSection.Controls.Add(donGiaBox);
            InformationSection.Controls.Add(tenThuoc);
            InformationSection.Controls.Add(tenThuocBox);
            InformationSection.Dock = DockStyle.Fill;
            InformationSection.Location = new Point(0, 44);
            InformationSection.Margin = new Padding(0);
            InformationSection.Name = "InformationSection";
            InformationSection.Size = new Size(1079, 294);
            InformationSection.TabIndex = 1;
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
            // ghiChuBox
            // 
            ghiChuBox.Location = new Point(497, 75);
            ghiChuBox.Name = "ghiChuBox";
            ghiChuBox.Size = new Size(244, 127);
            ghiChuBox.TabIndex = 12;
            ghiChuBox.Text = "";
            // 
            // ghiChu
            // 
            ghiChu.AutoSize = true;
            ghiChu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ghiChu.ForeColor = SystemColors.WindowText;
            ghiChu.Location = new Point(424, 75);
            ghiChu.Margin = new Padding(0);
            ghiChu.Name = "ghiChu";
            ghiChu.Size = new Size(61, 20);
            ghiChu.TabIndex = 11;
            ghiChu.Text = "Ghi chú";
            // 
            // hanSuDung
            // 
            hanSuDung.AutoSize = true;
            hanSuDung.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hanSuDung.ForeColor = SystemColors.WindowText;
            hanSuDung.Location = new Point(398, 28);
            hanSuDung.Margin = new Padding(0);
            hanSuDung.Name = "hanSuDung";
            hanSuDung.Size = new Size(96, 20);
            hanSuDung.TabIndex = 9;
            hanSuDung.Text = "Hạn sử dụng";
            // 
            // hanSuDungBox
            // 
            hanSuDungBox.CustomFormat = "yyyy-MM-dd";
            hanSuDungBox.Location = new Point(497, 25);
            hanSuDungBox.Name = "hanSuDungBox";
            hanSuDungBox.Size = new Size(244, 27);
            hanSuDungBox.TabIndex = 8;
            hanSuDungBox.Value = new DateTime(2023, 12, 4, 0, 0, 0, 0);
            // 
            // soLuong
            // 
            soLuong.AutoSize = true;
            soLuong.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            soLuong.ForeColor = SystemColors.WindowText;
            soLuong.Location = new Point(16, 178);
            soLuong.Margin = new Padding(0);
            soLuong.Name = "soLuong";
            soLuong.Size = new Size(70, 20);
            soLuong.TabIndex = 7;
            soLuong.Text = "Số lượng";
            // 
            // soLuongBox
            // 
            soLuongBox.Location = new Point(95, 175);
            soLuongBox.Name = "soLuongBox";
            soLuongBox.Size = new Size(224, 27);
            soLuongBox.TabIndex = 6;
            // 
            // donVi
            // 
            donVi.AutoSize = true;
            donVi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            donVi.ForeColor = SystemColors.WindowText;
            donVi.Location = new Point(16, 126);
            donVi.Margin = new Padding(0);
            donVi.Name = "donVi";
            donVi.Size = new Size(54, 20);
            donVi.TabIndex = 5;
            donVi.Text = "Đơn vị";
            // 
            // donViBox
            // 
            donViBox.Location = new Point(95, 123);
            donViBox.Name = "donViBox";
            donViBox.Size = new Size(224, 27);
            donViBox.TabIndex = 4;
            // 
            // donGia
            // 
            donGia.AutoSize = true;
            donGia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            donGia.ForeColor = SystemColors.WindowText;
            donGia.Location = new Point(16, 75);
            donGia.Margin = new Padding(0);
            donGia.Name = "donGia";
            donGia.Size = new Size(63, 20);
            donGia.TabIndex = 3;
            donGia.Text = "Đơn giá";
            // 
            // donGiaBox
            // 
            donGiaBox.Location = new Point(95, 72);
            donGiaBox.Name = "donGiaBox";
            donGiaBox.Size = new Size(224, 27);
            donGiaBox.TabIndex = 2;
            // 
            // tenThuoc
            // 
            tenThuoc.AutoSize = true;
            tenThuoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tenThuoc.ForeColor = SystemColors.WindowText;
            tenThuoc.Location = new Point(16, 28);
            tenThuoc.Margin = new Padding(0);
            tenThuoc.Name = "tenThuoc";
            tenThuoc.Size = new Size(76, 20);
            tenThuoc.TabIndex = 1;
            tenThuoc.Text = "Tên thuốc";
            // 
            // tenThuocBox
            // 
            tenThuocBox.Location = new Point(95, 25);
            tenThuocBox.Name = "tenThuocBox";
            tenThuocBox.Size = new Size(224, 27);
            tenThuocBox.TabIndex = 0;
            // 
            // thuocTable
            // 
            thuocTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            thuocTable.Dock = DockStyle.Fill;
            thuocTable.Location = new Point(3, 341);
            thuocTable.Name = "thuocTable";
            thuocTable.ReadOnly = true;
            thuocTable.RowHeadersWidth = 51;
            thuocTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            thuocTable.Size = new Size(1073, 392);
            thuocTable.TabIndex = 2;
            thuocTable.CellContentClick += thuocTable_CellContentClick;
            // 
            // searchThuocButton
            // 
            searchThuocButton.BackColor = SystemColors.MenuHighlight;
            searchThuocButton.FlatStyle = FlatStyle.Popup;
            searchThuocButton.ForeColor = SystemColors.ButtonHighlight;
            searchThuocButton.Location = new Point(327, 253);
            searchThuocButton.Name = "searchThuocButton";
            searchThuocButton.Size = new Size(87, 29);
            searchThuocButton.TabIndex = 18;
            searchThuocButton.Text = "Tìm";
            searchThuocButton.UseVisualStyleBackColor = false;
            searchThuocButton.Click += searchThuocButton_Click;
            // 
            // searchThuocBox
            // 
            searchThuocBox.Location = new Point(99, 253);
            searchThuocBox.Name = "searchThuocBox";
            searchThuocBox.Size = new Size(206, 27);
            searchThuocBox.TabIndex = 17;
            // 
            // searchThuocLabel
            // 
            searchThuocLabel.AutoSize = true;
            searchThuocLabel.ForeColor = SystemColors.WindowText;
            searchThuocLabel.Location = new Point(16, 256);
            searchThuocLabel.Name = "searchThuocLabel";
            searchThuocLabel.Size = new Size(78, 20);
            searchThuocLabel.TabIndex = 16;
            searchThuocLabel.Text = "Tìm thuốc:";
            // 
            // QuanLyThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            ForeColor = SystemColors.WindowFrame;
            Name = "QuanLyThuoc";
            Size = new Size(1079, 736);
            Load += QuanLyThuoc_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            InformationSection.ResumeLayout(false);
            InformationSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)thuocTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Label;
        private Panel InformationSection;
        private Label tenThuoc;
        private TextBox tenThuocBox;
        private Label donGia;
        private TextBox donGiaBox;
        private DateTimePicker hanSuDungBox;
        private Label soLuong;
        private TextBox soLuongBox;
        private Label donVi;
        private TextBox donViBox;
        private Label hanSuDung;
        private Label ghiChu;
        private RichTextBox ghiChuBox;
        private Button capNhatButton;
        private Button xoaButton;
        private Button themButton;
        private DataGridView thuocTable;
        private Button searchThuocButton;
        private TextBox searchThuocBox;
        private Label searchThuocLabel;
    }
}