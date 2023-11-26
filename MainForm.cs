using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeCar.User_Control;

namespace WeCar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Order uc = new Order();
            addUserControl(uc);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            carManagement uc = new carManagement();
            addUserControl(uc);
        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Customer uc = new Customer();
            addUserControl(uc);
        }


        private void label5_Click(object sender, EventArgs e)
        {
            Report uc = new Report();
            addUserControl(uc);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DataManagement uc = new DataManagement();
            addUserControl(uc);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
