namespace QLPHONGKHAM
{
    partial class DanhSachThuoc
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
            danhSachThuocTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)danhSachThuocTable).BeginInit();
            SuspendLayout();
            // 
            // danhSachThuocTable
            // 
            danhSachThuocTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachThuocTable.Dock = DockStyle.Fill;
            danhSachThuocTable.Location = new Point(0, 0);
            danhSachThuocTable.Margin = new Padding(0);
            danhSachThuocTable.Name = "danhSachThuocTable";
            danhSachThuocTable.RowHeadersWidth = 51;
            danhSachThuocTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachThuocTable.Size = new Size(800, 450);
            danhSachThuocTable.TabIndex = 0;
            danhSachThuocTable.CellContentClick += danhSachThuocTable_CellContentClick;
            // 
            // DanhSachThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(danhSachThuocTable);
            Name = "DanhSachThuoc";
            Text = "DanhSachThuoc";
            ((System.ComponentModel.ISupportInitialize)danhSachThuocTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView danhSachThuocTable;
    }
}