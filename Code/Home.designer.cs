using System.Drawing;
using System.Windows.Forms;

namespace QLPHONGKHAM
{
    partial class Home
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
            button3 = new Button();
            button2 = new Button();
            exitButton = new Button();
            thuocButton = new Button();
            NSButton = new Button();
            button1 = new Button();
            LLVButton = new Button();
            NVButton = new Button();
            content = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 40, 45);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(thuocButton);
            panel1.Controls.Add(NSButton);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(LLVButton);
            panel1.Controls.Add(NVButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 764);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button3.ForeColor = SystemColors.HighlightText;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 577);
            button3.Name = "button3";
            button3.Size = new Size(240, 89);
            button3.TabIndex = 8;
            button3.Text = "Đơn thuốc";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button2.ForeColor = SystemColors.HighlightText;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 90);
            button2.Name = "button2";
            button2.Size = new Size(243, 89);
            button2.TabIndex = 3;
            button2.Text = "Cuộc hẹn";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Teal;
            exitButton.FlatStyle = FlatStyle.Popup;
            exitButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            exitButton.ForeColor = SystemColors.HighlightText;
            exitButton.ImageAlign = ContentAlignment.MiddleLeft;
            exitButton.Location = new Point(2, 672);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(240, 89);
            exitButton.TabIndex = 7;
            exitButton.Text = "Đăng xuất";
            exitButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // thuocButton
            // 
            thuocButton.BackColor = Color.Teal;
            thuocButton.FlatStyle = FlatStyle.Popup;
            thuocButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            thuocButton.ForeColor = SystemColors.HighlightText;
            thuocButton.ImageAlign = ContentAlignment.MiddleLeft;
            thuocButton.Location = new Point(3, 481);
            thuocButton.Name = "thuocButton";
            thuocButton.Size = new Size(240, 89);
            thuocButton.TabIndex = 6;
            thuocButton.Text = "Thuốc";
            thuocButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            thuocButton.UseVisualStyleBackColor = false;
            thuocButton.Click += thuocButton_Click;
            // 
            // NSButton
            // 
            NSButton.BackColor = Color.Teal;
            NSButton.FlatStyle = FlatStyle.Popup;
            NSButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            NSButton.ForeColor = SystemColors.HighlightText;
            NSButton.ImageAlign = ContentAlignment.MiddleLeft;
            NSButton.Location = new Point(-1, 185);
            NSButton.Name = "NSButton";
            NSButton.Size = new Size(241, 89);
            NSButton.TabIndex = 2;
            NSButton.Text = "Nha Sĩ";
            NSButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            NSButton.UseVisualStyleBackColor = false;
            NSButton.Click += NSButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(240, 82);
            button1.TabIndex = 3;
            button1.Text = "Bệnh nhân";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LLVButton
            // 
            LLVButton.BackColor = Color.Teal;
            LLVButton.FlatStyle = FlatStyle.Popup;
            LLVButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            LLVButton.ForeColor = SystemColors.HighlightText;
            LLVButton.ImageAlign = ContentAlignment.MiddleLeft;
            LLVButton.Location = new Point(-1, 280);
            LLVButton.Name = "LLVButton";
            LLVButton.Size = new Size(244, 94);
            LLVButton.TabIndex = 4;
            LLVButton.Text = "Lịch làm việc";
            LLVButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            LLVButton.UseVisualStyleBackColor = false;
            LLVButton.Click += LLVButton_Click;
            // 
            // NVButton
            // 
            NVButton.BackColor = Color.Teal;
            NVButton.FlatStyle = FlatStyle.Popup;
            NVButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            NVButton.ForeColor = SystemColors.HighlightText;
            NVButton.ImageAlign = ContentAlignment.MiddleLeft;
            NVButton.Location = new Point(-2, 380);
            NVButton.Name = "NVButton";
            NVButton.Size = new Size(244, 95);
            NVButton.TabIndex = 3;
            NVButton.Text = "Nhân viên";
            NVButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            NVButton.UseVisualStyleBackColor = false;
            NVButton.Click += NVButton_Click;
            // 
            // content
            // 
            content.Cursor = Cursors.SizeAll;
            content.Dock = DockStyle.Fill;
            content.Enabled = false;
            content.ForeColor = Color.White;
            content.Location = new Point(243, 0);
            content.Name = "content";
            content.Size = new Size(1018, 764);
            content.TabIndex = 1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1261, 764);
            Controls.Add(content);
            Controls.Add(panel1);
            Name = "Home";
            Text = "QTV";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button nhasiButton;
        private Panel content;
        private Button NSButton;
        private Button NVButton;
        private Button LLVButton;
        private Button button1;
        private Button thuocButton;
        private Button exitButton;
        private Button button2;
        private Button button3;
    }
}