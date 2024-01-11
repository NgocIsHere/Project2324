using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLPHONGKHAM
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Label = new System.Windows.Forms.Label();
            this.InformationSection = new System.Windows.Forms.Panel();
            this.searchThuocButton = new System.Windows.Forms.Button();
            this.searchThuocBox = new System.Windows.Forms.TextBox();
            this.searchThuocLabel = new System.Windows.Forms.Label();
            this.capNhatButton = new System.Windows.Forms.Button();
            this.xoaButton = new System.Windows.Forms.Button();
            this.themButton = new System.Windows.Forms.Button();
            this.ghiChuBox = new System.Windows.Forms.RichTextBox();
            this.ghiChu = new System.Windows.Forms.Label();
            this.hanSuDung = new System.Windows.Forms.Label();
            this.hanSuDungBox = new System.Windows.Forms.DateTimePicker();
            this.soLuong = new System.Windows.Forms.Label();
            this.soLuongBox = new System.Windows.Forms.TextBox();
            this.donVi = new System.Windows.Forms.Label();
            this.donViBox = new System.Windows.Forms.TextBox();
            this.donGia = new System.Windows.Forms.Label();
            this.donGiaBox = new System.Windows.Forms.TextBox();
            this.tenThuoc = new System.Windows.Forms.Label();
            this.tenThuocBox = new System.Windows.Forms.TextBox();
            this.thuocTable = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.InformationSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuocTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.InformationSection, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.thuocTable, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1079, 589);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.Label.Size = new System.Drawing.Size(1079, 35);
            this.Label.TabIndex = 0;
            this.Label.Text = "QUẢN LÝ THUỐC";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InformationSection
            // 
            this.InformationSection.BackColor = System.Drawing.SystemColors.Control;
            this.InformationSection.Controls.Add(this.searchThuocButton);
            this.InformationSection.Controls.Add(this.searchThuocBox);
            this.InformationSection.Controls.Add(this.searchThuocLabel);
            this.InformationSection.Controls.Add(this.capNhatButton);
            this.InformationSection.Controls.Add(this.xoaButton);
            this.InformationSection.Controls.Add(this.themButton);
            this.InformationSection.Controls.Add(this.ghiChuBox);
            this.InformationSection.Controls.Add(this.ghiChu);
            this.InformationSection.Controls.Add(this.hanSuDung);
            this.InformationSection.Controls.Add(this.hanSuDungBox);
            this.InformationSection.Controls.Add(this.soLuong);
            this.InformationSection.Controls.Add(this.soLuongBox);
            this.InformationSection.Controls.Add(this.donVi);
            this.InformationSection.Controls.Add(this.donViBox);
            this.InformationSection.Controls.Add(this.donGia);
            this.InformationSection.Controls.Add(this.donGiaBox);
            this.InformationSection.Controls.Add(this.tenThuoc);
            this.InformationSection.Controls.Add(this.tenThuocBox);
            this.InformationSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationSection.Location = new System.Drawing.Point(0, 35);
            this.InformationSection.Margin = new System.Windows.Forms.Padding(0);
            this.InformationSection.Name = "InformationSection";
            this.InformationSection.Size = new System.Drawing.Size(1079, 235);
            this.InformationSection.TabIndex = 1;
            // 
            // searchThuocButton
            // 
            this.searchThuocButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchThuocButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchThuocButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchThuocButton.Location = new System.Drawing.Point(327, 202);
            this.searchThuocButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchThuocButton.Name = "searchThuocButton";
            this.searchThuocButton.Size = new System.Drawing.Size(87, 23);
            this.searchThuocButton.TabIndex = 18;
            this.searchThuocButton.Text = "Tìm";
            this.searchThuocButton.UseVisualStyleBackColor = false;
            // 
            // searchThuocBox
            // 
            this.searchThuocBox.Location = new System.Drawing.Point(99, 202);
            this.searchThuocBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchThuocBox.Name = "searchThuocBox";
            this.searchThuocBox.Size = new System.Drawing.Size(206, 22);
            this.searchThuocBox.TabIndex = 17;
            // 
            // searchThuocLabel
            // 
            this.searchThuocLabel.AutoSize = true;
            this.searchThuocLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.searchThuocLabel.Location = new System.Drawing.Point(16, 205);
            this.searchThuocLabel.Name = "searchThuocLabel";
            this.searchThuocLabel.Size = new System.Drawing.Size(68, 16);
            this.searchThuocLabel.TabIndex = 16;
            this.searchThuocLabel.Text = "Tìm thuốc:";
            // 
            // capNhatButton
            // 
            this.capNhatButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.capNhatButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.capNhatButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capNhatButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.capNhatButton.Location = new System.Drawing.Point(838, 129);
            this.capNhatButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.capNhatButton.Name = "capNhatButton";
            this.capNhatButton.Size = new System.Drawing.Size(177, 30);
            this.capNhatButton.TabIndex = 15;
            this.capNhatButton.Text = "CẬP NHẬT";
            this.capNhatButton.UseVisualStyleBackColor = false;
            // 
            // xoaButton
            // 
            this.xoaButton.BackColor = System.Drawing.Color.LightCoral;
            this.xoaButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.xoaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.xoaButton.Location = new System.Drawing.Point(838, 74);
            this.xoaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xoaButton.Name = "xoaButton";
            this.xoaButton.Size = new System.Drawing.Size(177, 30);
            this.xoaButton.TabIndex = 14;
            this.xoaButton.Text = "XÓA";
            this.xoaButton.UseVisualStyleBackColor = false;
            // 
            // themButton
            // 
            this.themButton.BackColor = System.Drawing.Color.Chocolate;
            this.themButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.themButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.themButton.Location = new System.Drawing.Point(838, 22);
            this.themButton.Margin = new System.Windows.Forms.Padding(0);
            this.themButton.Name = "themButton";
            this.themButton.Size = new System.Drawing.Size(177, 30);
            this.themButton.TabIndex = 13;
            this.themButton.Text = "THÊM";
            this.themButton.UseVisualStyleBackColor = false;
            // 
            // ghiChuBox
            // 
            this.ghiChuBox.Location = new System.Drawing.Point(497, 60);
            this.ghiChuBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ghiChuBox.Name = "ghiChuBox";
            this.ghiChuBox.Size = new System.Drawing.Size(244, 102);
            this.ghiChuBox.TabIndex = 12;
            this.ghiChuBox.Text = "";
            // 
            // ghiChu
            // 
            this.ghiChu.AutoSize = true;
            this.ghiChu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghiChu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ghiChu.Location = new System.Drawing.Point(424, 60);
            this.ghiChu.Margin = new System.Windows.Forms.Padding(0);
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.Size = new System.Drawing.Size(61, 20);
            this.ghiChu.TabIndex = 11;
            this.ghiChu.Text = "Ghi chú";
            // 
            // hanSuDung
            // 
            this.hanSuDung.AutoSize = true;
            this.hanSuDung.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hanSuDung.ForeColor = System.Drawing.SystemColors.WindowText;
            this.hanSuDung.Location = new System.Drawing.Point(398, 22);
            this.hanSuDung.Margin = new System.Windows.Forms.Padding(0);
            this.hanSuDung.Name = "hanSuDung";
            this.hanSuDung.Size = new System.Drawing.Size(96, 20);
            this.hanSuDung.TabIndex = 9;
            this.hanSuDung.Text = "Hạn sử dụng";
            // 
            // hanSuDungBox
            // 
            this.hanSuDungBox.CustomFormat = "yyyy-MM-dd";
            this.hanSuDungBox.Location = new System.Drawing.Point(497, 20);
            this.hanSuDungBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hanSuDungBox.Name = "hanSuDungBox";
            this.hanSuDungBox.Size = new System.Drawing.Size(244, 22);
            this.hanSuDungBox.TabIndex = 8;
            this.hanSuDungBox.Value = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            // 
            // soLuong
            // 
            this.soLuong.AutoSize = true;
            this.soLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.soLuong.Location = new System.Drawing.Point(16, 142);
            this.soLuong.Margin = new System.Windows.Forms.Padding(0);
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(70, 20);
            this.soLuong.TabIndex = 7;
            this.soLuong.Text = "Số lượng";
            // 
            // soLuongBox
            // 
            this.soLuongBox.Location = new System.Drawing.Point(95, 140);
            this.soLuongBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soLuongBox.Name = "soLuongBox";
            this.soLuongBox.Size = new System.Drawing.Size(224, 22);
            this.soLuongBox.TabIndex = 6;
            // 
            // donVi
            // 
            this.donVi.AutoSize = true;
            this.donVi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donVi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.donVi.Location = new System.Drawing.Point(16, 101);
            this.donVi.Margin = new System.Windows.Forms.Padding(0);
            this.donVi.Name = "donVi";
            this.donVi.Size = new System.Drawing.Size(54, 20);
            this.donVi.TabIndex = 5;
            this.donVi.Text = "Đơn vị";
            // 
            // donViBox
            // 
            this.donViBox.Location = new System.Drawing.Point(95, 98);
            this.donViBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.donViBox.Name = "donViBox";
            this.donViBox.Size = new System.Drawing.Size(224, 22);
            this.donViBox.TabIndex = 4;
            // 
            // donGia
            // 
            this.donGia.AutoSize = true;
            this.donGia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donGia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.donGia.Location = new System.Drawing.Point(16, 60);
            this.donGia.Margin = new System.Windows.Forms.Padding(0);
            this.donGia.Name = "donGia";
            this.donGia.Size = new System.Drawing.Size(63, 20);
            this.donGia.TabIndex = 3;
            this.donGia.Text = "Đơn giá";
            // 
            // donGiaBox
            // 
            this.donGiaBox.Location = new System.Drawing.Point(95, 58);
            this.donGiaBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.donGiaBox.Name = "donGiaBox";
            this.donGiaBox.Size = new System.Drawing.Size(224, 22);
            this.donGiaBox.TabIndex = 2;
            // 
            // tenThuoc
            // 
            this.tenThuoc.AutoSize = true;
            this.tenThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenThuoc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tenThuoc.Location = new System.Drawing.Point(16, 22);
            this.tenThuoc.Margin = new System.Windows.Forms.Padding(0);
            this.tenThuoc.Name = "tenThuoc";
            this.tenThuoc.Size = new System.Drawing.Size(76, 20);
            this.tenThuoc.TabIndex = 1;
            this.tenThuoc.Text = "Tên thuốc";
            // 
            // tenThuocBox
            // 
            this.tenThuocBox.Location = new System.Drawing.Point(95, 20);
            this.tenThuocBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenThuocBox.Name = "tenThuocBox";
            this.tenThuocBox.Size = new System.Drawing.Size(224, 22);
            this.tenThuocBox.TabIndex = 0;
            // 
            // thuocTable
            // 
            this.thuocTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thuocTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thuocTable.Location = new System.Drawing.Point(3, 272);
            this.thuocTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thuocTable.Name = "thuocTable";
            this.thuocTable.ReadOnly = true;
            this.thuocTable.RowHeadersWidth = 51;
            this.thuocTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.thuocTable.Size = new System.Drawing.Size(1073, 315);
            this.thuocTable.TabIndex = 2;
            // 
            // QuanLyThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyThuoc";
            this.Size = new System.Drawing.Size(1079, 589);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.InformationSection.ResumeLayout(false);
            this.InformationSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuocTable)).EndInit();
            this.ResumeLayout(false);

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