using QLPHONGKHAM.Controls;
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
    public partial class ChiTietBN : Form
    {
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;
        Color btnDefaultColor = Color.Transparent;
        Color btnSelectedtColor = Color.Teal;
        public string backup; 
        public ChiTietBN(string Id,string role)
        {
            InitializeComponent();
            label1.Text = Id;
            backup = role;
            InitializeNavigationControl();
            InitializeNavigationButtons();
        }
        private void InitializeNavigationControl()
        {
            BenhNhan benhNhan = new BenhNhan();
            benhNhan.bnID = label1.Text.ToString();
            Kehoachdieutri kh = new Kehoachdieutri();
            kh.idBN = label1.Text.ToString();
            DanhSachDonThuoc dsdonthuoc = new DanhSachDonThuoc();
            dsdonthuoc.idBN = label1.Text.ToString();
            thanhtoan tt = new thanhtoan();
            tt.idBN = label1.Text.ToString();
            List<UserControl> userControls = new List<UserControl>()
            {
                benhNhan,kh, dsdonthuoc,tt
            };
           
            navigationControl = new NavigationControl(userControls, content); 
            navigationControl.Display(0); 
        }

        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { thongtinButton, khdieutriButton,thanhtoanbutton,donthuocbutton };

            // create a NavigationButtons instance
            navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedtColor);
            // Make a default selected button
            navigationButtons.Highlight(thongtinButton);
        }

        private void thongtinButton_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(thongtinButton);
        }

        private void khdieutriButton_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(khdieutriButton);
        }

        private void thanhtoanbutton_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
            navigationButtons.Highlight(thanhtoanbutton);
        }

        private void donthuocbutton_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(donthuocbutton);
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            QuanLyBenhNhan qlbn = new QuanLyBenhNhan(backup);
            qlbn.Show();
            
        }
    }
}
