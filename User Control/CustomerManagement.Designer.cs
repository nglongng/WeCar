namespace WeCar.User_Control
{
    partial class CustomerManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel4 = new Panel();
            inputMail = new TextBox();
            label1 = new Label();
            inputAddress = new TextBox();
            comboBox2 = new ComboBox();
            label15 = new Label();
            inputPhone = new TextBox();
            inputId = new TextBox();
            inputName = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label19 = new Label();
            label20 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            inputSearch = new TextBox();
            dataGridView1 = new DataGridView();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(inputMail);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(inputAddress);
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(inputPhone);
            panel4.Controls.Add(inputId);
            panel4.Controls.Add(inputName);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(inputSearch);
            panel4.ForeColor = SystemColors.ControlText;
            panel4.Location = new Point(3, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(823, 272);
            panel4.TabIndex = 86;
            panel4.Paint += panel4_Paint;
            // 
            // inputMail
            // 
            inputMail.Location = new Point(22, 135);
            inputMail.Margin = new Padding(3, 2, 3, 2);
            inputMail.Name = "inputMail";
            inputMail.Size = new Size(256, 23);
            inputMail.TabIndex = 128;
            inputMail.TextChanged += inputMail_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(22, 113);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 127;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // inputAddress
            // 
            inputAddress.Location = new Point(22, 193);
            inputAddress.Margin = new Padding(3, 2, 3, 2);
            inputAddress.Name = "inputAddress";
            inputAddress.Size = new Size(256, 23);
            inputAddress.TabIndex = 125;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(283, 235);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(101, 23);
            comboBox2.TabIndex = 124;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(22, 168);
            label15.Name = "label15";
            label15.Size = new Size(57, 20);
            label15.TabIndex = 121;
            label15.Text = "Địa chỉ";
            // 
            // inputPhone
            // 
            inputPhone.Location = new Point(304, 135);
            inputPhone.Margin = new Padding(3, 2, 3, 2);
            inputPhone.Name = "inputPhone";
            inputPhone.Size = new Size(256, 23);
            inputPhone.TabIndex = 119;
            // 
            // inputId
            // 
            inputId.Location = new Point(22, 82);
            inputId.Margin = new Padding(3, 2, 3, 2);
            inputId.Name = "inputId";
            inputId.Size = new Size(256, 23);
            inputId.TabIndex = 117;
            // 
            // inputName
            // 
            inputName.Location = new Point(304, 81);
            inputName.Margin = new Padding(3, 2, 3, 2);
            inputName.Name = "inputName";
            inputName.Size = new Size(256, 23);
            inputName.TabIndex = 112;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(304, 59);
            label16.Name = "label16";
            label16.Size = new Size(128, 20);
            label16.TabIndex = 111;
            label16.Text = "Tên Khách Hàng";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(22, 17);
            label17.Name = "label17";
            label17.Size = new Size(204, 25);
            label17.TabIndex = 110;
            label17.Text = "Quản lý khách hàng";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ControlLightLight;
            label19.Location = new Point(304, 113);
            label19.Name = "label19";
            label19.Size = new Size(105, 20);
            label19.TabIndex = 101;
            label19.Text = "Số Điện thoại";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ControlLightLight;
            label20.Location = new Point(22, 59);
            label20.Name = "label20";
            label20.Size = new Size(80, 20);
            label20.TabIndex = 100;
            label20.Text = "Số CMND";
            // 
            // button1
            // 
            button1.Location = new Point(559, 234);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(68, 21);
            button1.TabIndex = 79;
            button1.Text = "Cập nhật ";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(503, 234);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(52, 21);
            button3.TabIndex = 78;
            button3.Text = "Xóa";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(446, 234);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(52, 21);
            button4.TabIndex = 77;
            button4.Text = "Thêm";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(389, 234);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(52, 21);
            button5.TabIndex = 76;
            button5.Text = "Tìm";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // inputSearch
            // 
            inputSearch.Location = new Point(22, 235);
            inputSearch.Margin = new Padding(3, 2, 3, 2);
            inputSearch.Name = "inputSearch";
            inputSearch.Size = new Size(256, 23);
            inputSearch.TabIndex = 74;
            inputSearch.Text = "Tìm kiếm";
            inputSearch.TextChanged += textBox9_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 279);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(826, 186);
            dataGridView1.TabIndex = 113;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerManagement";
            Size = new Size(829, 465);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private TextBox inputAddress;
        private ComboBox comboBox2;
        private Label label15;
        private TextBox inputPhone;
        private TextBox inputId;
        private TextBox inputName;
        private Label label16;
        private Label label17;
        private Label label19;
        private Label label20;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox inputSearch;
        private DataGridView dataGridView1;
        private TextBox inputMail;
        private Label label1;
    }
}
