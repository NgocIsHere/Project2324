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
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 604);
            panel1.TabIndex = 0;
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(157, 201);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // donThuocButton
            // 
            donThuocButton.BackColor = Color.Transparent;
            donThuocButton.Dock = DockStyle.Fill;
            donThuocButton.FlatStyle = FlatStyle.Popup;
            donThuocButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            donThuocButton.ForeColor = SystemColors.HighlightText;
            donThuocButton.ImageAlign = ContentAlignment.MiddleLeft;
            donThuocButton.Location = new Point(0, 66);
            donThuocButton.Margin = new Padding(0);
            donThuocButton.Name = "donThuocButton";
            donThuocButton.Size = new Size(157, 66);
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
            thuocButton.Location = new Point(0, 132);
            thuocButton.Margin = new Padding(0);
            thuocButton.Name = "thuocButton";
            thuocButton.Size = new Size(157, 69);
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
            content.Location = new Point(157, 0);
            content.Name = "content";
            content.Size = new Size(796, 604);
            content.TabIndex = 1;
            // 
            // QTV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(953, 604);
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
        private Panel content;
    }
}