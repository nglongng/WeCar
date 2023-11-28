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
            carManagement uc = new carManagement();
            addUserControl(uc);
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

        private void handleHover(object sender, DragEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void handleLeave(object sender, DragEventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CustomerManagement uc = new CustomerManagement();
            addUserControl(uc);
        }


        private void label5_Click(object sender, EventArgs e)
        {
            string role = Properties.Settings.Default.role;
            if (role == "Employee")
            {
                MessageBox.Show("Report chỉ dành cho Admin hoặc manager!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Report uc = new Report();
            addUserControl(uc);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DataManagement uc = new DataManagement();
            addUserControl(uc);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
