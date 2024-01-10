using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPHONGKHAM.Controls
{
    public partial class DanhSachDonThuoc : Form
    {
        Connection connection;
        public DanhSachDonThuoc()
        {
            InitializeComponent();
            connection = new Connection();
            connection.connect();
            SqlParameter[] paras =
            {
                new SqlParameter("@ID_BENHAN", SqlDbType.Char){Value = DonThuoc.idBenhAn}
            };
            danhSachDonThuocTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachDonThuocTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            danhSachDonThuocTable.DataSource = connection.dataTableWithParams("SP_XemDonThuocCuaBenhNhan", paras);
        }

        private void DanhSachDonThuoc_Load(object sender, EventArgs e)
        {

        }

        private void danhSachDonThuocTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = danhSachDonThuocTable.Rows[e.RowIndex];

            DonThuoc.idDonThuocGlobal = Convert.ToString(row.Cells["ID_DON"].Value);
            TaoDonThuoc chiTietDon = new TaoDonThuoc();
            chiTietDon.FormClosed += ChiTietDon_FormClosed;
            chiTietDon.ShowDialog();
        }
        private void ChiTietDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reload the DataGridView when chiTietDon form is closed
            connection.connect();
            SqlParameter[] paras =
            {
                new SqlParameter("@ID_BENHAN", SqlDbType.Char){Value = DonThuoc.idBenhAn}
            };
            danhSachDonThuocTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachDonThuocTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            danhSachDonThuocTable.DataSource = connection.dataTableWithParams("SP_XemDonThuocCuaBenhNhan", paras);
        }
    }
}
