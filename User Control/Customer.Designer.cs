namespace WeCar.User_Control
{
    partial class Customer
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
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            label15 = new Label();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox9 = new TextBox();
            dataGridView1 = new DataGridView();
            CMND = new DataGridViewTextBoxColumn();
            tenkh = new DataGridViewTextBoxColumn();
            ngaysinh = new DataGridViewTextBoxColumn();
            sdt = new DataGridViewTextBoxColumn();
            diachi = new DataGridViewTextBoxColumn();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(textBox7);
            panel4.Controls.Add(textBox8);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(textBox9);
            panel4.ForeColor = SystemColors.ControlText;
            panel4.Location = new Point(3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(941, 344);
            panel4.TabIndex = 86;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 170);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(292, 26);
            dateTimePicker1.TabIndex = 126;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 243);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 26);
            textBox1.TabIndex = 125;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(304, 296);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(115, 27);
            comboBox2.TabIndex = 124;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(6, 212);
            label15.Name = "label15";
            label15.Size = new Size(54, 19);
            label15.TabIndex = 121;
            label15.Text = "Địa chỉ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(328, 170);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(292, 26);
            textBox5.TabIndex = 119;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(6, 102);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(292, 26);
            textBox7.TabIndex = 117;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(328, 101);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(292, 26);
            textBox8.TabIndex = 112;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(328, 73);
            label16.Name = "label16";
            label16.Size = new Size(119, 19);
            label16.TabIndex = 111;
            label16.Text = "Tên Khách Hàng";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("SF Pro Display", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(6, 20);
            label17.Name = "label17";
            label17.Size = new Size(185, 25);
            label17.TabIndex = 110;
            label17.Text = "Quản lý khách hàng";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ControlLightLight;
            label18.Location = new Point(6, 142);
            label18.Name = "label18";
            label18.Size = new Size(75, 19);
            label18.TabIndex = 103;
            label18.Text = "Ngày sinh";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ControlLightLight;
            label19.Location = new Point(328, 142);
            label19.Name = "label19";
            label19.Size = new Size(95, 19);
            label19.TabIndex = 101;
            label19.Text = "Số Điện thoại";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ControlLightLight;
            label20.Location = new Point(6, 74);
            label20.Name = "label20";
            label20.Size = new Size(75, 19);
            label20.TabIndex = 100;
            label20.Text = "Số CMND";
            // 
            // button1
            // 
            button1.Location = new Point(620, 295);
            button1.Name = "button1";
            button1.Size = new Size(59, 26);
            button1.TabIndex = 79;
            button1.Text = "Sửa";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(555, 295);
            button3.Name = "button3";
            button3.Size = new Size(59, 26);
            button3.TabIndex = 78;
            button3.Text = "Xóa";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(490, 295);
            button4.Name = "button4";
            button4.Size = new Size(59, 26);
            button4.TabIndex = 77;
            button4.Text = "Thêm";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(425, 295);
            button5.Name = "button5";
            button5.Size = new Size(59, 26);
            button5.TabIndex = 76;
            button5.Text = "Tìm";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(6, 297);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(292, 26);
            textBox9.TabIndex = 74;
            textBox9.Text = "Tìm kiếm";
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CMND, tenkh, ngaysinh, sdt, diachi });
            dataGridView1.Location = new Point(0, 353);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(944, 236);
            dataGridView1.TabIndex = 113;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CMND
            // 
            CMND.HeaderText = "Số CMND";
            CMND.Name = "CMND";
            // 
            // tenkh
            // 
            tenkh.HeaderText = "Tên Khách Hàng";
            tenkh.Name = "tenkh";
            // 
            // ngaysinh
            // 
            ngaysinh.HeaderText = "Ngày sinh";
            ngaysinh.Name = "ngaysinh";
            // 
            // sdt
            // 
            sdt.HeaderText = "Số điện thoại";
            sdt.Name = "sdt";
            // 
            // diachi
            // 
            diachi.HeaderText = "Địa chỉ";
            diachi.Name = "diachi";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Name = "Customer";
            Size = new Size(947, 589);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label15;
        private TextBox textBox5;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox9;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CMND;
        private DataGridViewTextBoxColumn tenkh;
        private DataGridViewTextBoxColumn ngaysinh;
        private DataGridViewTextBoxColumn sdt;
        private DataGridViewTextBoxColumn diachi;
    }
}
