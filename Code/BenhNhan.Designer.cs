namespace Code
{
    partial class BenhNhan
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liệuTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchThanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bENHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGKHAM_DBDataSet = new Code.PHONGKHAM_DBDataSet();
            this.bENHANTableAdapter = new Code.PHONGKHAM_DBDataSetTableAdapters.BENHANTableAdapter();
            this.hoten = new System.Windows.Forms.TextBox();
            this.ngaysinh = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.TextBox();
            this.gioitinh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cuộcHẹnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.đơnThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bENHANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGKHAM_DBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.liệuTrìnhToolStripMenuItem,
            this.danhSáchThanhToánToolStripMenuItem,
            this.cuộcHẹnToolStripMenuItem,
            this.đơnThuốcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1297, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(104, 32);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // liệuTrìnhToolStripMenuItem
            // 
            this.liệuTrìnhToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.liệuTrìnhToolStripMenuItem.Name = "liệuTrìnhToolStripMenuItem";
            this.liệuTrìnhToolStripMenuItem.Size = new System.Drawing.Size(160, 29);
            this.liệuTrìnhToolStripMenuItem.Text = "Kế hoạch điều trị";
            this.liệuTrìnhToolStripMenuItem.Click += new System.EventHandler(this.liệuTrìnhToolStripMenuItem_Click);
            // 
            // danhSáchThanhToánToolStripMenuItem
            // 
            this.danhSáchThanhToánToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.danhSáchThanhToánToolStripMenuItem.Name = "danhSáchThanhToánToolStripMenuItem";
            this.danhSáchThanhToánToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.danhSáchThanhToánToolStripMenuItem.Text = "Thanh toán";
            this.danhSáchThanhToánToolStripMenuItem.Click += new System.EventHandler(this.danhSáchThanhToánToolStripMenuItem_Click);
            // 
            // bENHANBindingSource
            // 
            this.bENHANBindingSource.DataMember = "BENHAN";
            this.bENHANBindingSource.DataSource = this.pHONGKHAM_DBDataSet;
            // 
            // pHONGKHAM_DBDataSet
            // 
            this.pHONGKHAM_DBDataSet.DataSetName = "PHONGKHAM_DBDataSet";
            this.pHONGKHAM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bENHANTableAdapter
            // 
            this.bENHANTableAdapter.ClearBeforeFill = true;
            // 
            // hoten
            // 
            this.hoten.Location = new System.Drawing.Point(104, 102);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(201, 26);
            this.hoten.TabIndex = 6;
            this.hoten.TextChanged += new System.EventHandler(this.hoten_TextChanged);
            // 
            // ngaysinh
            // 
            this.ngaysinh.Location = new System.Drawing.Point(104, 163);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(119, 26);
            this.ngaysinh.TabIndex = 7;
            this.ngaysinh.TextChanged += new System.EventHandler(this.ngaysinh_TextChanged);
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(104, 223);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(474, 26);
            this.diachi.TabIndex = 8;
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(104, 277);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(119, 26);
            this.sdt.TabIndex = 9;
            // 
            // gioitinh
            // 
            this.gioitinh.Location = new System.Drawing.Point(104, 324);
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Size = new System.Drawing.Size(80, 26);
            this.gioitinh.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(137, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Giới tính";
            // 
            // cuộcHẹnToolStripMenuItem
            // 
            this.cuộcHẹnToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cuộcHẹnToolStripMenuItem.Name = "cuộcHẹnToolStripMenuItem";
            this.cuộcHẹnToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.cuộcHẹnToolStripMenuItem.Text = "Cuộc hẹn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.gioitinh);
            this.groupBox1.Controls.Add(this.sdt);
            this.groupBox1.Controls.Add(this.diachi);
            this.groupBox1.Controls.Add(this.ngaysinh);
            this.groupBox1.Controls.Add(this.hoten);
            this.groupBox1.Location = new System.Drawing.Point(107, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 494);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // đơnThuốcToolStripMenuItem
            // 
            this.đơnThuốcToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.đơnThuốcToolStripMenuItem.Name = "đơnThuốcToolStripMenuItem";
            this.đơnThuốcToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.đơnThuốcToolStripMenuItem.Text = "Đơn thuốc";
            // 
            // BenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1297, 654);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "BenhNhan";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bENHANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGKHAM_DBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liệuTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchThanhToánToolStripMenuItem;
        private System.Windows.Forms.BindingSource bENHANBindingSource;
        private PHONGKHAM_DBDataSet pHONGKHAM_DBDataSet;
        private PHONGKHAM_DBDataSetTableAdapters.BENHANTableAdapter bENHANTableAdapter;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.TextBox ngaysinh;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox gioitinh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem cuộcHẹnToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem đơnThuốcToolStripMenuItem;
    }
}
