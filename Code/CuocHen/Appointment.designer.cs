namespace QLPHONGKHAM
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 451);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1343, 440);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày Hẹn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giờ Hẹn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nha Sĩ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bệnh Nhân:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(777, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Trạng thái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(801, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phòng:";
            // 
            // comboBoxNS
            // 
            this.comboBoxNS.FormattingEnabled = true;
            this.comboBoxNS.Location = new System.Drawing.Point(552, 161);
            this.comboBoxNS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxNS.Name = "comboBoxNS";
            this.comboBoxNS.Size = new System.Drawing.Size(202, 28);
            this.comboBoxNS.TabIndex = 8;
            // 
            // comboBoxTrangThai
            // 
            this.comboBoxTrangThai.FormattingEnabled = true;
            this.comboBoxTrangThai.Location = new System.Drawing.Point(863, 161);
            this.comboBoxTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTrangThai.Name = "comboBoxTrangThai";
            this.comboBoxTrangThai.Size = new System.Drawing.Size(136, 28);
            this.comboBoxTrangThai.TabIndex = 9;
            // 
            // textBoxBN
            // 
            this.textBoxBN.Location = new System.Drawing.Point(552, 74);
            this.textBoxBN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBN.Name = "textBoxBN";
            this.textBoxBN.Size = new System.Drawing.Size(202, 26);
            this.textBoxBN.TabIndex = 10;
            // 
            // dateTimePickerngay
            // 
            this.dateTimePickerngay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerngay.Location = new System.Drawing.Point(189, 75);
            this.dateTimePickerngay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerngay.Name = "dateTimePickerngay";
            this.dateTimePickerngay.Size = new System.Drawing.Size(165, 26);
            this.dateTimePickerngay.TabIndex = 12;
            this.dateTimePickerngay.ValueChanged += new System.EventHandler(this.dateTimePickerngay_ValueChanged);
            // 
            // dateTimePickergio
            // 
            this.dateTimePickergio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickergio.Location = new System.Drawing.Point(189, 165);
            this.dateTimePickergio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickergio.Name = "dateTimePickergio";
            this.dateTimePickergio.Size = new System.Drawing.Size(165, 26);
            this.dateTimePickergio.TabIndex = 13;
            // 
            // comboBoxphong
            // 
            this.comboBoxphong.FormattingEnabled = true;
            this.comboBoxphong.Location = new System.Drawing.Point(863, 72);
            this.comboBoxphong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxphong.Name = "comboBoxphong";
            this.comboBoxphong.Size = new System.Drawing.Size(87, 28);
            this.comboBoxphong.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lọc theo:";
            // 
            // comboBoxLoc
            // 
            this.comboBoxLoc.FormattingEnabled = true;
            this.comboBoxLoc.Location = new System.Drawing.Point(396, 394);
            this.comboBoxLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxLoc.Name = "comboBoxLoc";
            this.comboBoxLoc.Size = new System.Drawing.Size(136, 28);
            this.comboBoxLoc.TabIndex = 16;
            this.comboBoxLoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoc_SelectedIndexChanged);
            // 
            // textBoxLoc
            // 
            this.textBoxLoc.Location = new System.Drawing.Point(539, 396);
            this.textBoxLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLoc.Name = "textBoxLoc";
            this.textBoxLoc.Size = new System.Drawing.Size(134, 26);
            this.textBoxLoc.TabIndex = 17;
            this.textBoxLoc.Visible = false;
            this.textBoxLoc.TextChanged += new System.EventHandler(this.textBoxLoc_TextChanged);
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(681, 396);
            this.buttonsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(84, 29);
            this.buttonsearch.TabIndex = 18;
            this.buttonsearch.Text = "Tìm Kiếm";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Visible = false;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mã Cuộc hẹn: ";
            // 
            // textBoxmach
            // 
            this.textBoxmach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxmach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmach.Location = new System.Drawing.Point(552, 251);
            this.textBoxmach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxmach.Name = "textBoxmach";
            this.textBoxmach.ReadOnly = true;
            this.textBoxmach.Size = new System.Drawing.Size(189, 25);
            this.textBoxmach.TabIndex = 20;
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(1107, 70);
            this.buttonupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(166, 62);
            this.buttonupdate.TabIndex = 21;
            this.buttonupdate.Text = "CẬP NHẬT";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(844, 238);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(166, 46);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Thêm Cuộc Hẹn";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
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
            this.panel1.Size = new System.Drawing.Size(1349, 447);
            this.panel1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Chọn ngày";
            // 
            // filterDatePickerBox
            // 
            this.filterDatePickerBox.CustomFormat = "dd/MM/yyyy";
            this.filterDatePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.filterDatePickerBox.Location = new System.Drawing.Point(130, 394);
            this.filterDatePickerBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filterDatePickerBox.Name = "filterDatePickerBox";
            this.filterDatePickerBox.Size = new System.Drawing.Size(165, 26);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1349, 895);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 58);
            this.button1.TabIndex = 25;
            this.button1.Text = "<< Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 895);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button button1;
    }
}