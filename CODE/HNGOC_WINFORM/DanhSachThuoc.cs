using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPHONGKHAM
{
    public partial class DanhSachThuoc : Form
    {
        Connection connection;
        public static string tenThuocGlobal {  get; set; }
        public static string idThuocGlobal { get; set; }
        public DanhSachThuoc()
        {
            InitializeComponent();
            connection = new Connection();
            connection.connect();
            danhSachThuocTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachThuocTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            danhSachThuocTable.DataSource = connection.dataTable("EXEC SP_XEMDSTHUOC");
        }

        private void DanhSachThuoc_Load(object sender, EventArgs e)
        {

        }

        private void danhSachThuocTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = danhSachThuocTable.Rows[e.RowIndex];

                // Check if cells exist and are not null
                DataGridViewCell tenThuocCell = selectedRow.Cells["TENTHUOC"];
                DataGridViewCell idThuocCell = selectedRow.Cells["ID_THUOC"];

                if (tenThuocCell != null && tenThuocCell.Value != null)
                {
                    tenThuocGlobal = tenThuocCell.Value.ToString();
                }
                else
                {
                    tenThuocGlobal = string.Empty; // Assign an empty string if null
                }

                if (idThuocCell != null && idThuocCell.Value != null)
                {
                    idThuocGlobal = idThuocCell.Value.ToString();
                }
                else
                {
                    idThuocGlobal = string.Empty; // Assign an empty string if null
                }

                this.Close();
            }
        }

    }
}
