﻿namespace Code
{
    partial class Appointment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxNS = new System.Windows.Forms.ComboBox();
            this.comboBoxTrangThai = new System.Windows.Forms.ComboBox();
            this.textBoxBN = new System.Windows.Forms.TextBox();
            this.dateTimePickerngay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickergio = new System.Windows.Forms.DateTimePicker();
            this.comboBoxphong = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxLoc = new System.Windows.Forms.ComboBox();
            this.textBoxLoc = new System.Windows.Forms.TextBox();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxmach = new System.Windows.Forms.TextBox();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.filterDatePickerBox = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1193, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày Hẹn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giờ Hẹn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nha Sĩ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bệnh Nhân:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(691, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Trạng thái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(712, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phòng:";
            // 
            // comboBoxNS
            // 
            this.comboBoxNS.FormattingEnabled = true;
            this.comboBoxNS.Location = new System.Drawing.Point(491, 129);
            this.comboBoxNS.Name = "comboBoxNS";
            this.comboBoxNS.Size = new System.Drawing.Size(180, 24);
            this.comboBoxNS.TabIndex = 8;
            // 
            // comboBoxTrangThai
            // 
            this.comboBoxTrangThai.FormattingEnabled = true;
            this.comboBoxTrangThai.Location = new System.Drawing.Point(767, 129);
            this.comboBoxTrangThai.Name = "comboBoxTrangThai";
            this.comboBoxTrangThai.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTrangThai.TabIndex = 9;
            // 
            // textBoxBN
            // 
            this.textBoxBN.Location = new System.Drawing.Point(491, 59);
            this.textBoxBN.Name = "textBoxBN";
            this.textBoxBN.Size = new System.Drawing.Size(180, 22);
            this.textBoxBN.TabIndex = 10;
            // 
            // dateTimePickerngay
            // 
            this.dateTimePickerngay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerngay.Location = new System.Drawing.Point(168, 60);
            this.dateTimePickerngay.Name = "dateTimePickerngay";
            this.dateTimePickerngay.Size = new System.Drawing.Size(147, 22);
            this.dateTimePickerngay.TabIndex = 12;
            this.dateTimePickerngay.ValueChanged += new System.EventHandler(this.dateTimePickerngay_ValueChanged);
            // 
            // dateTimePickergio
            // 
            this.dateTimePickergio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickergio.Location = new System.Drawing.Point(168, 132);
            this.dateTimePickergio.Name = "dateTimePickergio";
            this.dateTimePickergio.Size = new System.Drawing.Size(147, 22);
            this.dateTimePickergio.TabIndex = 13;
            // 
            // comboBoxphong
            // 
            this.comboBoxphong.FormattingEnabled = true;
            this.comboBoxphong.Location = new System.Drawing.Point(767, 58);
            this.comboBoxphong.Name = "comboBoxphong";
            this.comboBoxphong.Size = new System.Drawing.Size(78, 24);
            this.comboBoxphong.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lọc theo:";
            // 
            // comboBoxLoc
            // 
            this.comboBoxLoc.FormattingEnabled = true;
            this.comboBoxLoc.Location = new System.Drawing.Point(352, 315);
            this.comboBoxLoc.Name = "comboBoxLoc";
            this.comboBoxLoc.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLoc.TabIndex = 16;
            this.comboBoxLoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoc_SelectedIndexChanged);
            // 
            // textBoxLoc
            // 
            this.textBoxLoc.Location = new System.Drawing.Point(479, 317);
            this.textBoxLoc.Name = "textBoxLoc";
            this.textBoxLoc.Size = new System.Drawing.Size(120, 22);
            this.textBoxLoc.TabIndex = 17;
            this.textBoxLoc.Visible = false;
            this.textBoxLoc.TextChanged += new System.EventHandler(this.textBoxLoc_TextChanged);
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(605, 317);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(75, 23);
            this.buttonsearch.TabIndex = 18;
            this.buttonsearch.Text = "Tìm Kiếm";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Visible = false;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mã Cuộc hẹn: ";
            // 
            // textBoxmach
            // 
            this.textBoxmach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxmach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmach.Location = new System.Drawing.Point(491, 201);
            this.textBoxmach.Name = "textBoxmach";
            this.textBoxmach.ReadOnly = true;
            this.textBoxmach.Size = new System.Drawing.Size(168, 21);
            this.textBoxmach.TabIndex = 20;
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(984, 56);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(148, 50);
            this.buttonupdate.TabIndex = 21;
            this.buttonupdate.Text = "CẬP NHẬT";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(750, 190);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(148, 37);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Thêm Cuộc Hẹn";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.filterDatePickerBox);
            this.panel1.Controls.Add(this.textBoxBN);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonupdate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxmach);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonsearch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxLoc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBoxLoc);
            this.panel1.Controls.Add(this.comboBoxNS);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBoxTrangThai);
            this.panel1.Controls.Add(this.comboBoxphong);
            this.panel1.Controls.Add(this.dateTimePickerngay);
            this.panel1.Controls.Add(this.dateTimePickergio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 358);
            this.panel1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Chọn ngày";
            // 
            // filterDatePickerBox
            // 
            this.filterDatePickerBox.CustomFormat = "dd/MM/yyyy";
            this.filterDatePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.filterDatePickerBox.Location = new System.Drawing.Point(116, 315);
            this.filterDatePickerBox.Name = "filterDatePickerBox";
            this.filterDatePickerBox.Size = new System.Drawing.Size(147, 22);
            this.filterDatePickerBox.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1199, 716);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 716);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Appointment";
            this.Text = "XemCuocHen";
            this.Load += new System.EventHandler(this.XemCuocHen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxNS;
        private System.Windows.Forms.ComboBox comboBoxTrangThai;
        private System.Windows.Forms.TextBox textBoxBN;
        private System.Windows.Forms.DateTimePicker dateTimePickerngay;
        private System.Windows.Forms.DateTimePicker dateTimePickergio;
        private System.Windows.Forms.ComboBox comboBoxphong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxLoc;
        private System.Windows.Forms.TextBox textBoxLoc;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxmach;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker filterDatePickerBox;
    }
}