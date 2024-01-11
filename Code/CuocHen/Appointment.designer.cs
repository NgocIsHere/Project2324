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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            comboBoxNS = new System.Windows.Forms.ComboBox();
            comboBoxTrangThai = new System.Windows.Forms.ComboBox();
            textBoxBN = new System.Windows.Forms.TextBox();
            dateTimePickerngay = new System.Windows.Forms.DateTimePicker();
            dateTimePickergio = new System.Windows.Forms.DateTimePicker();
            comboBoxphong = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            comboBoxLoc = new System.Windows.Forms.ComboBox();
            textBoxLoc = new System.Windows.Forms.TextBox();
            buttonsearch = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            textBoxmach = new System.Windows.Forms.TextBox();
            buttonupdate = new System.Windows.Forms.Button();
            buttonAdd = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            filterDatePickerBox = new System.Windows.Forms.DateTimePicker();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(3, 451);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1193, 440);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(91, 78);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "Ngày Hẹn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(103, 166);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Giờ Hẹn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(397, 166);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 20);
            label3.TabIndex = 3;
            label3.Text = "Nha Sĩ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(397, 74);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(84, 20);
            label4.TabIndex = 4;
            label4.Text = "Bệnh Nhân:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(691, 165);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(78, 20);
            label6.TabIndex = 6;
            label6.Text = "Trạng thái:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(712, 78);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(54, 20);
            label7.TabIndex = 7;
            label7.Text = "Phòng:";
            // 
            // comboBoxNS
            // 
            comboBoxNS.FormattingEnabled = true;
            comboBoxNS.Location = new System.Drawing.Point(491, 161);
            comboBoxNS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBoxNS.Name = "comboBoxNS";
            comboBoxNS.Size = new System.Drawing.Size(180, 28);
            comboBoxNS.TabIndex = 8;
            // 
            // comboBoxTrangThai
            // 
            comboBoxTrangThai.FormattingEnabled = true;
            comboBoxTrangThai.Location = new System.Drawing.Point(767, 161);
            comboBoxTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBoxTrangThai.Name = "comboBoxTrangThai";
            comboBoxTrangThai.Size = new System.Drawing.Size(121, 28);
            comboBoxTrangThai.TabIndex = 9;
            // 
            // textBoxBN
            // 
            textBoxBN.Location = new System.Drawing.Point(491, 74);
            textBoxBN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxBN.Name = "textBoxBN";
            textBoxBN.Size = new System.Drawing.Size(180, 27);
            textBoxBN.TabIndex = 10;
            // 
            // dateTimePickerngay
            // 
            dateTimePickerngay.CustomFormat = "dd/MM/yyyy";
            dateTimePickerngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerngay.Location = new System.Drawing.Point(168, 75);
            dateTimePickerngay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateTimePickerngay.Name = "dateTimePickerngay";
            dateTimePickerngay.Size = new System.Drawing.Size(147, 27);
            dateTimePickerngay.TabIndex = 12;
            dateTimePickerngay.ValueChanged += dateTimePickerngay_ValueChanged;
            // 
            // dateTimePickergio
            // 
            dateTimePickergio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dateTimePickergio.Location = new System.Drawing.Point(168, 165);
            dateTimePickergio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateTimePickergio.Name = "dateTimePickergio";
            dateTimePickergio.Size = new System.Drawing.Size(147, 27);
            dateTimePickergio.TabIndex = 13;
            // 
            // comboBoxphong
            // 
            comboBoxphong.FormattingEnabled = true;
            comboBoxphong.Location = new System.Drawing.Point(767, 72);
            comboBoxphong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBoxphong.Name = "comboBoxphong";
            comboBoxphong.Size = new System.Drawing.Size(78, 28);
            comboBoxphong.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(285, 398);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(69, 20);
            label8.TabIndex = 15;
            label8.Text = "Lọc theo:";
            // 
            // comboBoxLoc
            // 
            comboBoxLoc.FormattingEnabled = true;
            comboBoxLoc.Location = new System.Drawing.Point(352, 394);
            comboBoxLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBoxLoc.Name = "comboBoxLoc";
            comboBoxLoc.Size = new System.Drawing.Size(121, 28);
            comboBoxLoc.TabIndex = 16;
            comboBoxLoc.SelectedIndexChanged += comboBoxLoc_SelectedIndexChanged;
            // 
            // textBoxLoc
            // 
            textBoxLoc.Location = new System.Drawing.Point(479, 396);
            textBoxLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxLoc.Name = "textBoxLoc";
            textBoxLoc.Size = new System.Drawing.Size(120, 27);
            textBoxLoc.TabIndex = 17;
            textBoxLoc.Visible = false;
            textBoxLoc.TextChanged += textBoxLoc_TextChanged;
            // 
            // buttonsearch
            // 
            buttonsearch.Location = new System.Drawing.Point(605, 396);
            buttonsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonsearch.Name = "buttonsearch";
            buttonsearch.Size = new System.Drawing.Size(75, 29);
            buttonsearch.TabIndex = 18;
            buttonsearch.Text = "Tìm Kiếm";
            buttonsearch.UseVisualStyleBackColor = true;
            buttonsearch.Visible = false;
            buttonsearch.Click += buttonsearch_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(397, 250);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(102, 20);
            label9.TabIndex = 19;
            label9.Text = "Mã Cuộc hẹn: ";
            // 
            // textBoxmach
            // 
            textBoxmach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxmach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBoxmach.Location = new System.Drawing.Point(491, 251);
            textBoxmach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxmach.Name = "textBoxmach";
            textBoxmach.ReadOnly = true;
            textBoxmach.Size = new System.Drawing.Size(168, 21);
            textBoxmach.TabIndex = 20;
            // 
            // buttonupdate
            // 
            buttonupdate.Location = new System.Drawing.Point(984, 70);
            buttonupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonupdate.Name = "buttonupdate";
            buttonupdate.Size = new System.Drawing.Size(148, 62);
            buttonupdate.TabIndex = 21;
            buttonupdate.Text = "CẬP NHẬT";
            buttonupdate.UseVisualStyleBackColor = true;
            buttonupdate.Click += buttonupdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new System.Drawing.Point(750, 238);
            buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(148, 46);
            buttonAdd.TabIndex = 22;
            buttonAdd.Text = "Thêm Cuộc Hẹn";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(filterDatePickerBox);
            panel1.Controls.Add(textBoxBN);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonupdate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxmach);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonsearch);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBoxLoc);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboBoxLoc);
            panel1.Controls.Add(comboBoxNS);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(comboBoxTrangThai);
            panel1.Controls.Add(comboBoxphong);
            panel1.Controls.Add(dateTimePickerngay);
            panel1.Controls.Add(dateTimePickergio);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1199, 447);
            panel1.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.LightSeaGreen;
            button1.Location = new System.Drawing.Point(0, 0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(105, 58);
            button1.TabIndex = 25;
            button1.Text = "<< Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(29, 398);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(79, 20);
            label5.TabIndex = 23;
            label5.Text = "Chọn ngày";
            // 
            // filterDatePickerBox
            // 
            filterDatePickerBox.CustomFormat = "dd/MM/yyyy";
            filterDatePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            filterDatePickerBox.Location = new System.Drawing.Point(116, 394);
            filterDatePickerBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            filterDatePickerBox.Name = "filterDatePickerBox";
            filterDatePickerBox.Size = new System.Drawing.Size(147, 27);
            filterDatePickerBox.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1199, 895);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // Appointment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1199, 895);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Appointment";
            Text = "XemCuocHen";
            Load += XemCuocHen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
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