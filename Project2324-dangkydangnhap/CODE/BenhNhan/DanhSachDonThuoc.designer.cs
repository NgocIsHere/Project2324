using System.Drawing;
using System.Windows.Forms;

namespace QLPHONGKHAM.Controls
{
    partial class DanhSachDonThuoc
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Label = new Label();
            danhSachDonThuocTable = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachDonThuocTable).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Label, 0, 0);
            tableLayoutPanel1.Controls.Add(danhSachDonThuocTable, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(1032, 676);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.BackColor = Color.Teal;
            Label.Dock = DockStyle.Fill;
            Label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label.ForeColor = Color.GhostWhite;
            Label.Location = new Point(0, 0);
            Label.Margin = new Padding(0);
            Label.Name = "Label";
            Label.Size = new Size(1032, 67);
            Label.TabIndex = 1;
            Label.Text = "DANH SÁCH ĐƠN THUỐC";
            Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // danhSachDonThuocTable
            // 
            danhSachDonThuocTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachDonThuocTable.Dock = DockStyle.Fill;
            danhSachDonThuocTable.Location = new Point(0, 67);
            danhSachDonThuocTable.Margin = new Padding(0);
            danhSachDonThuocTable.MultiSelect = false;
            danhSachDonThuocTable.Name = "danhSachDonThuocTable";
            danhSachDonThuocTable.ReadOnly = true;
            danhSachDonThuocTable.RowHeadersWidth = 51;
            danhSachDonThuocTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachDonThuocTable.Size = new Size(1032, 609);
            danhSachDonThuocTable.TabIndex = 2;
            danhSachDonThuocTable.CellContentClick += danhSachDonThuocTable_CellContentClick;
            // 
            // DanhSachDonThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 676);
            Controls.Add(tableLayoutPanel1);
            Name = "DanhSachDonThuoc";
            Text = "DanhSachDonThuoc";
            Load += DanhSachDonThuoc_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachDonThuocTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Label;
        private DataGridView danhSachDonThuocTable;
    }
}