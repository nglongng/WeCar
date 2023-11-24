using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeCar
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtErrPass_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn_MouseHover(object sender, EventArgs e)
        {
            closeBtn.ForeColor = Color.Red;

        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.ForeColor = Color.White;
        }

        private void inputUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtErrUserName.Text = "";
        }

        private void inputPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            inputPassword.PasswordChar = '*';
            txtErrPass.Text = "";
        }

        private void inputConFirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            inputConfirmPass.PasswordChar = '*';
            txtErrPassConfirm.Text = "";
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            //handle login logic
            String usname = this.inputUserName.Text;
            String pass = this.inputPassword.Text;
            String confirmPass = this.inputConfirmPass.Text;
            if (usname == "")
            {
                txtErrUserName.Text = "Please enter your user name";
            }
            else if (pass == "")
            {
                txtErrPass.Text = "Please enter your password";
            }
            else if (confirmPass == "")
            {
                txtErrPassConfirm.Text = "Please confirm your password";
            }
            else if (!pass.Equals(confirmPass))
            {
                txtErrPassConfirm.Text = "Password is not mess";

            }
            else
            {
                Popup popup = new Popup();
                popup.Show();

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private bool isDragging = false;
        private Point offset;
        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offset = e.Location;
            }
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left = e.X + this.Left - offset.X;
                this.Top = e.Y + this.Top - offset.Y;
            }
        }

        private void RegisterForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
