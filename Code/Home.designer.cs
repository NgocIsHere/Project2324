﻿using System.Drawing;
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.thuocButton = new System.Windows.Forms.Button();
            this.NSButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LLVButton = new System.Windows.Forms.Button();
            this.NVButton = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.thuocButton);
            this.panel1.Controls.Add(this.NSButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.LLVButton);
            this.panel1.Controls.Add(this.NVButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 764);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 89);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cuộc hẹn";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(0, 672);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(270, 89);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Đăng xuất";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // thuocButton
            // 
            this.thuocButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.thuocButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.thuocButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.thuocButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.thuocButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thuocButton.Location = new System.Drawing.Point(3, 481);
            this.thuocButton.Name = "thuocButton";
            this.thuocButton.Size = new System.Drawing.Size(270, 89);
            this.thuocButton.TabIndex = 6;
            this.thuocButton.Text = "Thuốc";
            this.thuocButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.thuocButton.UseVisualStyleBackColor = false;
            this.thuocButton.Click += new System.EventHandler(this.thuocButton_Click);
            // 
            // NSButton
            // 
            this.NSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.NSButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NSButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.NSButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NSButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NSButton.Location = new System.Drawing.Point(-1, 185);
            this.NSButton.Name = "NSButton";
            this.NSButton.Size = new System.Drawing.Size(271, 89);
            this.NSButton.TabIndex = 2;
            this.NSButton.Text = "Nha Sĩ";
            this.NSButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NSButton.UseVisualStyleBackColor = false;
            this.NSButton.Click += new System.EventHandler(this.NSButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 82);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bệnh nhân";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LLVButton
            // 
            this.LLVButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.LLVButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LLVButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.LLVButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LLVButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LLVButton.Location = new System.Drawing.Point(-1, 280);
            this.LLVButton.Name = "LLVButton";
            this.LLVButton.Size = new System.Drawing.Size(274, 94);
            this.LLVButton.TabIndex = 4;
            this.LLVButton.Text = "Lịch làm việc";
            this.LLVButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LLVButton.UseVisualStyleBackColor = false;
            this.LLVButton.Click += new System.EventHandler(this.LLVButton_Click);
            // 
            // NVButton
            // 
            this.NVButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.NVButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NVButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.NVButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NVButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NVButton.Location = new System.Drawing.Point(-2, 380);
            this.NVButton.Name = "NVButton";
            this.NVButton.Size = new System.Drawing.Size(275, 95);
            this.NVButton.TabIndex = 3;
            this.NVButton.Text = "Nhân viên";
            this.NVButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NVButton.UseVisualStyleBackColor = false;
            this.NVButton.Click += new System.EventHandler(this.NVButton_Click);
            // 
            // content
            // 
            this.content.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Enabled = false;
            this.content.ForeColor = System.Drawing.Color.White;
            this.content.Location = new System.Drawing.Point(273, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1146, 764);
            this.content.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 577);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 89);
            this.button3.TabIndex = 8;
            this.button3.Text = "Đơn thuốc";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1419, 764);
            this.Controls.Add(this.content);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "QTV";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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