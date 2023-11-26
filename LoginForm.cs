namespace WeCar
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //handle login logic
            String usname = this.inputUserName.Text;
            String pass = this.inputPassword.Text;
            if (usname == "")
            {
                txtErrUserName.Text = "Please enter your user name";
            }
            else if (pass == "")
            {
                txtErrPass.Text = "Please enter your password";
            }
            else if (usname.Equals("admin") && pass.Equals("123"))
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();

            }
            else
            {
                txtErrInvalid.Text = "Username or password is invalid";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_DragOver(object sender, DragEventArgs e)
        {
            loginBtn.ForeColor = Color.White;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            inputPassword.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void closeBtn_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void closeBtn_MouseHover(object sender, EventArgs e)
        {
            closeBtn.ForeColor = Color.Red;

        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.ForeColor = Color.White;
        }

        private void closeBtn_MouseClick(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtErrUserName_Click(object sender, EventArgs e)
        {

        }

        private void inputUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtErrUserName.Text = "";
        }

        private void inputPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtErrPass.Text = "";
        }


        private void registerClick(object sender, EventArgs e)
        {
            txtErrPass.Text = "Please enter your password";
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
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

        private void inputUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}