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
    public partial class DanhSachDonThuoc : UserControl
    {
        Connection connection;
        public string idBN;
        public string role;
        public DanhSachDonThuoc()
        {
            InitializeComponent();
            
        }

        private void DanhSachDonThuoc_Load(object sender, EventArgs e)
        {
            int.TryParse(idBN, out int result);
            connection = new Connection();
            connection.connect();
            SqlParameter[] paras =
            {
                new SqlParameter("@ID_BENHAN", SqlDbType.Int){Value = result}
            };
            danhSachDonThuocTable.DataSource = connection.dataTableWithParams("SP_XemDonThuocCuaBenhNhan", paras);
        }

        private void danhSachDonThuocTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = danhSachDonThuocTable.Rows[e.RowIndex];

            int v = Convert.ToInt32(row.Cells["ID_DON"].Value);
            DonThuoc.idDonThuocGlobal = v.ToString();
            TaoDonThuoc chiTietDon = new TaoDonThuoc(role);
            chiTietDon.FormClosed += ChiTietDon_FormClosed;
            chiTietDon.ShowDialog();
        }
        private void ChiTietDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reload the DataGridView when chiTietDon form is closed
            connection.connect();
            SqlParameter[] paras =
            {
                new SqlParameter("@ID_BENHAN", SqlDbType.Int){Value = DonThuoc.idBenhAn}
            };
            danhSachDonThuocTable.DataSource = connection.dataTableWithParams("SP_XemDonThuocCuaBenhNhan", paras);
        }

        private void danhSachDonThuocTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
