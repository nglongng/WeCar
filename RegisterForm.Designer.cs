namespace WeCar
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pictureBox1 = new PictureBox();
            txtErrInvalid = new Label();
            label5 = new Label();
            txtErrPass = new Label();
            txtErrUserName = new Label();
            btnBack = new LinkLabel();
            panel2 = new Panel();
            label4 = new Label();
            inputPassword = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            inputUserName = new TextBox();
            label1 = new Label();
            registerBtn = new Button();
            label6 = new Label();
            label7 = new Label();
            txtErrPassConfirm = new Label();
            panel3 = new Panel();
            label9 = new Label();
            inputConfirmPass = new TextBox();
            closeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 472);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtErrInvalid
            // 
            txtErrInvalid.AutoSize = true;
            txtErrInvalid.BackColor = SystemColors.ActiveCaptionText;
            txtErrInvalid.Font = new Font("Agency FB", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtErrInvalid.ForeColor = Color.Red;
            txtErrInvalid.Location = new Point(581, 256);
            txtErrInvalid.Name = "txtErrInvalid";
            txtErrInvalid.Size = new Size(0, 14);
            txtErrInvalid.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Agency FB", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(393, 196);
            label5.Name = "label5";
            label5.Size = new Size(0, 14);
            label5.TabIndex = 29;
            // 
            // txtErrPass
            // 
            txtErrPass.AutoSize = true;
            txtErrPass.BackColor = SystemColors.ActiveCaptionText;
            txtErrPass.Font = new Font("Agency FB", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtErrPass.ForeColor = Color.Red;
            txtErrPass.Location = new Point(406, 231);
            txtErrPass.Name = "txtErrPass";
            txtErrPass.Size = new Size(0, 14);
            txtErrPass.TabIndex = 28;
            txtErrPass.Click += txtErrPass_Click;
            // 
            // txtErrUserName
            // 
            txtErrUserName.AutoSize = true;
            txtErrUserName.BackColor = SystemColors.ActiveCaptionText;
            txtErrUserName.Font = new Font("Agency FB", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtErrUserName.ForeColor = Color.Red;
            txtErrUserName.Location = new Point(407, 162);
            txtErrUserName.Name = "txtErrUserName";
            txtErrUserName.Size = new Size(0, 14);
            txtErrUserName.TabIndex = 27;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.BackColor = SystemColors.ActiveCaptionText;
            btnBack.Font = new Font("Agency FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.LinkColor = Color.FromArgb(224, 224, 224);
            btnBack.Location = new Point(645, 397);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(55, 17);
            btnBack.TabIndex = 26;
            btnBack.TabStop = true;
            btnBack.Text = "Back to login";
            btnBack.LinkClicked += linkLabel2_LinkClicked;
            btnBack.Click += btnBack_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(406, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 1);
            panel2.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(304, 190);
            label4.Name = "label4";
            label4.Size = new Size(74, 24);
            label4.TabIndex = 24;
            label4.Text = "Password:";
            // 
            // inputPassword
            // 
            inputPassword.BackColor = SystemColors.InactiveCaptionText;
            inputPassword.BorderStyle = BorderStyle.None;
            inputPassword.Cursor = Cursors.IBeam;
            inputPassword.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            inputPassword.ForeColor = SystemColors.Menu;
            inputPassword.Location = new Point(406, 190);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(294, 18);
            inputPassword.TabIndex = 21;
            inputPassword.KeyPress += inputPassword_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(304, 126);
            label3.Name = "label3";
            label3.Size = new Size(74, 24);
            label3.TabIndex = 22;
            label3.Text = "Username:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(406, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 1);
            panel1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(509, 66);
            label2.Name = "label2";
            label2.Size = new Size(78, 31);
            label2.TabIndex = 19;
            label2.Text = "Register";
            label2.Click += label2_Click;
            // 
            // inputUserName
            // 
            inputUserName.BackColor = SystemColors.InactiveCaptionText;
            inputUserName.BorderStyle = BorderStyle.None;
            inputUserName.Cursor = Cursors.IBeam;
            inputUserName.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            inputUserName.ForeColor = SystemColors.Menu;
            inputUserName.Location = new Point(406, 126);
            inputUserName.Name = "inputUserName";
            inputUserName.Size = new Size(294, 18);
            inputUserName.TabIndex = 18;
            inputUserName.KeyPress += inputUserName_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 78);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 17;
            label1.Text = "label1";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.Black;
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatAppearance.BorderColor = Color.Lime;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            registerBtn.ForeColor = Color.Lime;
            registerBtn.Location = new Point(439, 344);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(189, 36);
            registerBtn.TabIndex = 16;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Font = new Font("Agency FB", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(584, 335);
            label6.Name = "label6";
            label6.Size = new Size(0, 14);
            label6.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.Font = new Font("Agency FB", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(393, 262);
            label7.Name = "label7";
            label7.Size = new Size(0, 14);
            label7.TabIndex = 35;
            // 
            // txtErrPassConfirm
            // 
            txtErrPassConfirm.AutoSize = true;
            txtErrPassConfirm.BackColor = SystemColors.ActiveCaptionText;
            txtErrPassConfirm.Font = new Font("Agency FB", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtErrPassConfirm.ForeColor = Color.Red;
            txtErrPassConfirm.Location = new Point(406, 297);
            txtErrPassConfirm.Name = "txtErrPassConfirm";
            txtErrPassConfirm.Size = new Size(0, 14);
            txtErrPassConfirm.TabIndex = 34;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(406, 280);
            panel3.Name = "panel3";
            panel3.Size = new Size(294, 1);
            panel3.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(304, 256);
            label9.Name = "label9";
            label9.Size = new Size(59, 24);
            label9.TabIndex = 33;
            label9.Text = "Confirm:";
            // 
            // inputConfirmPass
            // 
            inputConfirmPass.BackColor = SystemColors.InactiveCaptionText;
            inputConfirmPass.BorderStyle = BorderStyle.None;
            inputConfirmPass.Cursor = Cursors.IBeam;
            inputConfirmPass.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            inputConfirmPass.ForeColor = SystemColors.Menu;
            inputConfirmPass.Location = new Point(406, 256);
            inputConfirmPass.Name = "inputConfirmPass";
            inputConfirmPass.Size = new Size(294, 18);
            inputConfirmPass.TabIndex = 31;
            inputConfirmPass.KeyPress += inputConFirmPassword_KeyPress;
            // 
            // closeBtn
            // 
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.FlatAppearance.BorderColor = Color.Black;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.ForeColor = SystemColors.ButtonHighlight;
            closeBtn.Location = new Point(770, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(30, 28);
            closeBtn.TabIndex = 37;
            closeBtn.Text = "X";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.MouseClick += closeBtn_MouseClick;
            closeBtn.MouseLeave += closeBtn_MouseLeave;
            closeBtn.MouseHover += closeBtn_MouseHover;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtErrPassConfirm);
            Controls.Add(panel3);
            Controls.Add(label9);
            Controls.Add(inputConfirmPass);
            Controls.Add(txtErrInvalid);
            Controls.Add(label5);
            Controls.Add(txtErrPass);
            Controls.Add(txtErrUserName);
            Controls.Add(btnBack);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(inputPassword);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(inputUserName);
            Controls.Add(label1);
            Controls.Add(registerBtn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            MouseDown += RegisterForm_MouseDown;
            MouseMove += RegisterForm_MouseMove;
            MouseUp += RegisterForm_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label txtErrInvalid;
        private Label label5;
        private Label txtErrPass;
        private Label txtErrUserName;
        private LinkLabel btnBack;
        private Panel panel2;
        private Label label4;
        private TextBox inputPassword;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private TextBox inputUserName;
        private Label label1;
        private Button registerBtn;
        private Label label6;
        private Label label7;
        private Label txtErrPassConfirm;
        private Panel panel3;
        private Label label9;
        private TextBox inputConfirmPass;
        private Button closeBtn;
    }
}