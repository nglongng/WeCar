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
            loginBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            inputUserName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            inputUserName.ForeColor = SystemColors.Menu;
            inputUserName.Location = new Point(428, 156);
            inputUserName.Name = "inputUserName";
            inputUserName.Size = new Size(279, 17);
            inputUserName.TabIndex = 2;
            inputUserName.TextChanged += inputUserName_TextChanged;
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
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(516, 56);
            label2.Name = "label2";
            label2.Size = new Size(78, 29);
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
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(311, 156);
            label3.Name = "label3";
            label3.Size = new Size(111, 24);
            label3.TabIndex = 7;
            label3.Text = "Username:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(311, 224);
            label4.Name = "label4";
            label4.Size = new Size(106, 24);
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
            inputPassword.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            inputPassword.ForeColor = SystemColors.Menu;
            inputPassword.Location = new Point(428, 224);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(279, 17);
            inputPassword.TabIndex = 7;
            inputPassword.TextChanged += textBox2_TextChanged_1;
            inputPassword.KeyPress += inputPassword_KeyPress;
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
            txtErrUserName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtErrUserName.ForeColor = Color.Red;
            txtErrUserName.Location = new Point(414, 192);
            txtErrUserName.Name = "txtErrUserName";
            txtErrUserName.Size = new Size(0, 13);
            txtErrUserName.TabIndex = 12;
            txtErrUserName.Click += txtErrUserName_Click;
            // 
            // txtErrPass
            // 
            txtErrPass.AutoSize = true;
            txtErrPass.BackColor = SystemColors.ActiveCaptionText;
            txtErrPass.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtErrPass.ForeColor = Color.Red;
            txtErrPass.Location = new Point(413, 261);
            txtErrPass.Name = "txtErrPass";
            txtErrPass.Size = new Size(0, 13);
            txtErrPass.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(400, 230);
            label5.Name = "label5";
            label5.Size = new Size(0, 13);
            label5.TabIndex = 14;
            // 
            // txtErrInvalid
            // 
            txtErrInvalid.AutoSize = true;
            txtErrInvalid.BackColor = SystemColors.ActiveCaptionText;
            txtErrInvalid.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtErrInvalid.ForeColor = Color.Red;
            txtErrInvalid.Location = new Point(588, 261);
            txtErrInvalid.Name = "txtErrInvalid";
            txtErrInvalid.Size = new Size(0, 13);
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
        private Button closeBtn;
        private Label txtErrUserName;
        private Label txtErrPass;
        private Label label5;
        private Label txtErrInvalid;
    }
}