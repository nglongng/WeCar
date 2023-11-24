namespace WeCar
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginBtn = new Button();
            label1 = new Label();
            inputUserName = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            inputPassword = new TextBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            closeBtn = new Button();
            txtErrUserName = new Label();
            txtErrPass = new Label();
            label5 = new Label();
            txtErrInvalid = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Black;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderColor = Color.Lime;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.Lime;
            loginBtn.Location = new Point(450, 329);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(189, 36);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += button1_Click;
            loginBtn.DragOver += button1_DragOver;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 83);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // inputUserName
            // 
            inputUserName.BackColor = SystemColors.InactiveCaptionText;
            inputUserName.BorderStyle = BorderStyle.None;
            inputUserName.Cursor = Cursors.IBeam;
            inputUserName.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            inputUserName.ForeColor = SystemColors.Menu;
            inputUserName.Location = new Point(413, 156);
            inputUserName.Name = "inputUserName";
            inputUserName.Size = new Size(294, 18);
            inputUserName.TabIndex = 2;
            inputUserName.KeyPress += inputUserName_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.carlogo;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 472);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(516, 56);
            label2.Name = "label2";
            label2.Size = new Size(52, 31);
            label2.TabIndex = 5;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(413, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 1);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(311, 156);
            label3.Name = "label3";
            label3.Size = new Size(74, 24);
            label3.TabIndex = 7;
            label3.Text = "Username:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(311, 224);
            label4.Name = "label4";
            label4.Size = new Size(74, 24);
            label4.TabIndex = 8;
            label4.Text = "Password:";
            label4.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(413, 248);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 1);
            panel2.TabIndex = 8;
            // 
            // inputPassword
            // 
            inputPassword.BackColor = SystemColors.InactiveCaptionText;
            inputPassword.BorderStyle = BorderStyle.None;
            inputPassword.Cursor = Cursors.IBeam;
            inputPassword.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            inputPassword.ForeColor = SystemColors.Menu;
            inputPassword.Location = new Point(413, 224);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(294, 18);
            inputPassword.TabIndex = 7;
            inputPassword.TextChanged += textBox2_TextChanged_1;
            inputPassword.KeyPress += inputPassword_KeyPress;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.ActiveCaptionText;
            linkLabel1.Font = new Font("Agency FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(224, 224, 224);
            linkLabel1.Location = new Point(516, 284);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(67, 17);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot password";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = SystemColors.ActiveCaptionText;
            linkLabel2.Font = new Font("Agency FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.FromArgb(224, 224, 224);
            linkLabel2.Location = new Point(504, 388);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(79, 17);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create new account";
            linkLabel2.Click += registerClick;
            // 
            // closeBtn
            // 
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.FlatAppearance.BorderColor = Color.Black;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.ForeColor = SystemColors.ButtonHighlight;
            closeBtn.Location = new Point(769, 1);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(30, 28);
            closeBtn.TabIndex = 11;
            closeBtn.Text = "X";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_MouseClick;
            closeBtn.DragEnter += closeBtn_DragEnter;
            closeBtn.MouseClick += closeBtn_MouseClick;
            closeBtn.MouseLeave += closeBtn_MouseLeave;
            closeBtn.MouseHover += closeBtn_MouseHover;
            // 
            // txtErrUserName
            // 
            txtErrUserName.AutoSize = true;
            txtErrUserName.BackColor = SystemColors.ActiveCaptionText;
            txtErrUserName.Font = new Font("Agency FB", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtErrUserName.ForeColor = Color.Red;
            txtErrUserName.Location = new Point(414, 192);
            txtErrUserName.Name = "txtErrUserName";
            txtErrUserName.Size = new Size(0, 14);
            txtErrUserName.TabIndex = 12;
            txtErrUserName.Click += txtErrUserName_Click;
            // 
            // txtErrPass
            // 
            txtErrPass.AutoSize = true;
            txtErrPass.BackColor = SystemColors.ActiveCaptionText;
            txtErrPass.Font = new Font("Agency FB", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtErrPass.ForeColor = Color.Red;
            txtErrPass.Location = new Point(413, 261);
            txtErrPass.Name = "txtErrPass";
            txtErrPass.Size = new Size(0, 14);
            txtErrPass.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Agency FB", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(400, 230);
            label5.Name = "label5";
            label5.Size = new Size(0, 14);
            label5.TabIndex = 14;
            // 
            // txtErrInvalid
            // 
            txtErrInvalid.AutoSize = true;
            txtErrInvalid.BackColor = SystemColors.ActiveCaptionText;
            txtErrInvalid.Font = new Font("Agency FB", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtErrInvalid.ForeColor = Color.Red;
            txtErrInvalid.Location = new Point(588, 261);
            txtErrInvalid.Name = "txtErrInvalid";
            txtErrInvalid.Size = new Size(0, 14);
            txtErrInvalid.TabIndex = 15;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 474);
            Controls.Add(txtErrInvalid);
            Controls.Add(label5);
            Controls.Add(txtErrPass);
            Controls.Add(txtErrUserName);
            Controls.Add(closeBtn);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(inputPassword);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(inputUserName);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "Form1";
            Load += Form1_Load;
            DragEnter += Form1_DragEnter;
            MouseDown += RegisterForm_MouseDown;
            MouseMove += RegisterForm_MouseMove;
            MouseUp += RegisterForm_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBtn;
        private Label label1;
        private TextBox inputUserName;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private TextBox inputPassword;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Button closeBtn;
        private Label txtErrUserName;
        private Label txtErrPass;
        private Label label5;
        private Label txtErrInvalid;
    }
}