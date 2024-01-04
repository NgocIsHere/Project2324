namespace QLPHONGKHAM
{
    partial class QTV
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
            panel1 = new Panel();
            LLVButton = new Button();
            NSButton = new Button();
            NVButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            donThuocButton = new Button();
            thuocButton = new Button();
            content = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 40, 45);
            panel1.Controls.Add(LLVButton);
            panel1.Controls.Add(NSButton);
            panel1.Controls.Add(NVButton);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 655);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // LLVButton
            // 
            LLVButton.BackColor = Color.FromArgb(35, 40, 45);
            LLVButton.FlatStyle = FlatStyle.Popup;
            LLVButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            LLVButton.ForeColor = SystemColors.HighlightText;
            LLVButton.ImageAlign = ContentAlignment.MiddleLeft;
            LLVButton.Location = new Point(0, 461);
            LLVButton.Name = "LLVButton";
            LLVButton.Size = new Size(173, 99);
            LLVButton.TabIndex = 4;
            LLVButton.Text = "Lịch làm việc";
            LLVButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            LLVButton.UseVisualStyleBackColor = false;
            LLVButton.Click += LLVButton_Click;
            // 
            // NSButton
            // 
            NSButton.BackColor = Color.FromArgb(35, 40, 45);
            NSButton.FlatStyle = FlatStyle.Popup;
            NSButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            NSButton.ForeColor = SystemColors.HighlightText;
            NSButton.ImageAlign = ContentAlignment.MiddleLeft;
            NSButton.Location = new Point(0, 271);
            NSButton.Name = "NSButton";
            NSButton.Size = new Size(173, 99);
            NSButton.TabIndex = 2;
            NSButton.Text = "Nha Sĩ";
            NSButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            NSButton.UseVisualStyleBackColor = false;
            NSButton.Click += NSButton_Click;
            // 
            // NVButton
            // 
            NVButton.BackColor = Color.FromArgb(35, 40, 45);
            NVButton.FlatStyle = FlatStyle.Popup;
            NVButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            NVButton.ForeColor = SystemColors.HighlightText;
            NVButton.ImageAlign = ContentAlignment.MiddleLeft;
            NVButton.Location = new Point(0, 366);
            NVButton.Name = "NVButton";
            NVButton.Size = new Size(173, 99);
            NVButton.TabIndex = 3;
            NVButton.Text = "Nhân viên";
            NVButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            NVButton.UseVisualStyleBackColor = false;
            NVButton.Click += NVButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(donThuocButton, 0, 1);
            tableLayoutPanel1.Controls.Add(thuocButton, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.83582F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.3283577F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(173, 268);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // donThuocButton
            // 
            donThuocButton.BackColor = Color.Transparent;
            donThuocButton.Dock = DockStyle.Fill;
            donThuocButton.FlatStyle = FlatStyle.Popup;
            donThuocButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            donThuocButton.ForeColor = SystemColors.HighlightText;
            donThuocButton.ImageAlign = ContentAlignment.MiddleLeft;
            donThuocButton.Location = new Point(0, 88);
            donThuocButton.Margin = new Padding(0);
            donThuocButton.Name = "donThuocButton";
            donThuocButton.Size = new Size(173, 87);
            donThuocButton.TabIndex = 2;
            donThuocButton.Text = "Đơn thuốc";
            donThuocButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            donThuocButton.UseVisualStyleBackColor = false;
            donThuocButton.Click += donThuocButton_Click;
            // 
            // thuocButton
            // 
            thuocButton.BackColor = Color.Transparent;
            thuocButton.Dock = DockStyle.Fill;
            thuocButton.FlatStyle = FlatStyle.Popup;
            thuocButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            thuocButton.ForeColor = SystemColors.HighlightText;
            thuocButton.ImageAlign = ContentAlignment.MiddleLeft;
            thuocButton.Location = new Point(0, 175);
            thuocButton.Margin = new Padding(0);
            thuocButton.Name = "thuocButton";
            thuocButton.Size = new Size(173, 93);
            thuocButton.TabIndex = 0;
            thuocButton.Text = "Thuốc";
            thuocButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            thuocButton.UseVisualStyleBackColor = false;
            thuocButton.Click += thuocButton_Click;
            // 
            // content
            // 
            content.Dock = DockStyle.Fill;
            content.ForeColor = Color.White;
            content.Location = new Point(173, 0);
            content.Name = "content";
            content.Size = new Size(916, 655);
            content.TabIndex = 1;
            content.Paint += content_Paint;
            // 
            // QTV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1089, 655);
            Controls.Add(content);
            Controls.Add(panel1);
            Name = "QTV";
            Text = "QTV";
            Load += QTV_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button thuocButton;
        private Button donThuocButton;
        private Button nhasiButton;
        private Panel content;
        private Button NSButton;
        private Button NVButton;
        private Button LLVButton;
    }
}