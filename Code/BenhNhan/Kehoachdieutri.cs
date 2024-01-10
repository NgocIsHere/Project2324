using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPHONGKHAM
{
    public partial class Kehoachdieutri : UserControl
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PHONGKHAM_DBConnectionString"].ConnectionString);
        public string idBN;
        public Kehoachdieutri()
        {
            InitializeComponent();
            groupBox1.Hide();
            groupBox2.Show();
        }

        private void Kehoachdieutri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pHONGKHAM_DBDataSet1.KHDIEUTRI' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'pHONGKHAM_DBDataSet.DIEUTRI' table. You can move, or remove it, as needed.
            string query = "select * from KHDIEUTRI KH where  KH.BENHNHAN = " + idBN;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
            {
                // Create a new DataTable
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the results of the query
                adapter.Fill(dataTable);

                // Set the DataGridView's DataSource to the DataTable
                dataGridView1.DataSource = dataTable;
            }
            con.Close();
            groupBox1.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LieuTrinh newf = new LieuTrinh(idBN, textBox1.Text.ToString());
            newf.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            string teethinf = "";
            if (checkBox1.Checked)
            {
                teethinf += "R1/" + checkedListBox1.Text.ToString() +": "+ checkedListBoxTeethSide1.Text.ToString()+ ",";
            }
            if (checkBox2.Checked)
            {
                teethinf += "R2/" + checkedListBox2.Text.ToString() +": " +checkedListBoxTeethSide2.Text.ToString()+",";
            }
            if (checkBox3.Checked)
            {
                teethinf += "R3/" + checkedListBox3.Text.ToString() +": "+ checkedListBoxTeethSide3.Text.ToString()+",";
            }
            if (checkBox4.Checked)
            {
                teethinf += "R4/" + checkedListBox4.Text.ToString() +": "+ checkedListBoxTeethSide4.Text.ToString()+",";
            }
            if (checkBox5.Checked)
            {
                teethinf += "R5/" + checkedListBox5.Text.ToString() +": "+ checkedListBoxTeethSide5.Text.ToString()+",";
            }
            if (checkBox6.Checked)
            {
                teethinf += "R6/" + checkedListBox6.Text.ToString() + ": " + checkedListBoxTeethSide6.Text.ToString() + ",";
            }
            if (checkBox7.Checked)
            {
                teethinf += "R7/" + checkedListBox1.Text.ToString() + ": " + checkedListBoxTeethSide1.Text.ToString() + ",";
            }
            if (checkBox8.Checked)
            {
                teethinf += "R8/" + checkedListBox8.Text.ToString() + ": " + checkedListBoxTeethSide8.Text.ToString() + ",";
            }
            string type = checkedListBox9.Text.ToString();
            using (SqlCommand cmd = new SqlCommand("SP_THEMKHDIEUTRI", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BENHNHAN", Convert.ToInt32(idBN));
                cmd.Parameters.AddWithValue("@DSRANG", teethinf);
                cmd.Parameters.AddWithValue("@DIEUTRI", type);
                MessageBox.Show("Added!");
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


            }
            groupBox2.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Show();
        }
    }
}
