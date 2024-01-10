using System.Windows.Forms;

namespace QLPHONGKHAM
{
    partial class ChiTietBN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.thongtinButton = new System.Windows.Forms.Button();
            this.khdieutriButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.donthuocbutton = new System.Windows.Forms.Button();
            this.thanhtoanbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 764);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.thongtinButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.khdieutriButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.donthuocbutton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.thanhtoanbutton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(218, 406);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // thongtinButton
            // 
            this.thongtinButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.thongtinButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtinButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.thongtinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thongtinButton.Location = new System.Drawing.Point(0, 20);
            this.thongtinButton.Margin = new System.Windows.Forms.Padding(0);
            this.thongtinButton.Name = "thongtinButton";
            this.thongtinButton.Size = new System.Drawing.Size(221, 67);
            this.thongtinButton.TabIndex = 2;
            this.thongtinButton.Text = "Thông tin";
            this.thongtinButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.thongtinButton.UseVisualStyleBackColor = false;
            this.thongtinButton.Click += new System.EventHandler(this.thongtinButton_Click);
            // 
            // khdieutriButton
            // 
            this.khdieutriButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.khdieutriButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khdieutriButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.khdieutriButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.khdieutriButton.Location = new System.Drawing.Point(0, 87);
            this.khdieutriButton.Margin = new System.Windows.Forms.Padding(0);
            this.khdieutriButton.Name = "khdieutriButton";
            this.khdieutriButton.Size = new System.Drawing.Size(218, 67);
            this.khdieutriButton.TabIndex = 0;
            this.khdieutriButton.Text = "Điều trị";
            this.khdieutriButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.khdieutriButton.UseVisualStyleBackColor = false;
            this.khdieutriButton.Click += new System.EventHandler(this.khdieutriButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // donthuocbutton
            // 
            this.donthuocbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.donthuocbutton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.donthuocbutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.donthuocbutton.Location = new System.Drawing.Point(3, 234);
            this.donthuocbutton.Name = "donthuocbutton";
            this.donthuocbutton.Size = new System.Drawing.Size(215, 79);
            this.donthuocbutton.TabIndex = 5;
            this.donthuocbutton.Text = "Đơn thuốc";
            this.donthuocbutton.UseVisualStyleBackColor = true;
            this.donthuocbutton.Click += new System.EventHandler(this.donthuocbutton_Click);
            // 
            // thanhtoanbutton
            // 
            this.thanhtoanbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.thanhtoanbutton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.thanhtoanbutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.thanhtoanbutton.Location = new System.Drawing.Point(3, 157);
            this.thanhtoanbutton.Name = "thanhtoanbutton";
            this.thanhtoanbutton.Size = new System.Drawing.Size(215, 71);
            this.thanhtoanbutton.TabIndex = 4;
            this.thanhtoanbutton.Text = "Thanh toán";
            this.thanhtoanbutton.UseVisualStyleBackColor = true;
            this.thanhtoanbutton.Click += new System.EventHandler(this.thanhtoanbutton_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(3, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 84);
            this.button2.TabIndex = 7;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // content
            // 
            this.content.Controls.Add(this.button1);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.ForeColor = System.Drawing.Color.White;
            this.content.Location = new System.Drawing.Point(218, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1203, 764);
            this.content.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1203, 764);
            this.button1.TabIndex = 1;
            this.button1.Text = "Điều trị";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ChiTietBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1421, 764);
            this.Controls.Add(this.content);
            this.Controls.Add(this.panel1);
            this.Name = "ChiTietBN";
            this.Text = "Quản lý bệnh nhân";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button thongtinButton;
        private Button khdieutriButton;
        private Panel content;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion
        private Button button1;
        private Button thanhtoanbutton;
        private Button donthuocbutton;
        private Label label1;
        private Button button2;
    }
}