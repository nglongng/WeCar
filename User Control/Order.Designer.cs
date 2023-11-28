namespace WeCar.User_Control
{
    partial class Order
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
            inputDestination = new TextBox();
            label5 = new Label();
            inputStart = new TextBox();
            label4 = new Label();
            inputPeriod = new TextBox();
            S14 = new CheckBox();
            S13 = new CheckBox();
            S12 = new CheckBox();
            S11 = new CheckBox();
            S10 = new CheckBox();
            S09 = new CheckBox();
            S08 = new CheckBox();
            S07 = new CheckBox();
            S06 = new CheckBox();
            S05 = new CheckBox();
            S04 = new CheckBox();
            S03 = new CheckBox();
            S02 = new CheckBox();
            S01 = new CheckBox();
            label3 = new Label();
            inputStatus = new ComboBox();
            label15 = new Label();
            label2 = new Label();
            label1 = new Label();
            inputDate = new DateTimePicker();
            inputCustomerId = new TextBox();
            inputCarId = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridView1 = new DataGridView();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(inputDestination);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(inputStart);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(inputPeriod);
            panel4.Controls.Add(S14);
            panel4.Controls.Add(S13);
            panel4.Controls.Add(S12);
            panel4.Controls.Add(S11);
            panel4.Controls.Add(S10);
            panel4.Controls.Add(S09);
            panel4.Controls.Add(S08);
            panel4.Controls.Add(S07);
            panel4.Controls.Add(S06);
            panel4.Controls.Add(S05);
            panel4.Controls.Add(S04);
            panel4.Controls.Add(S03);
            panel4.Controls.Add(S02);
            panel4.Controls.Add(S01);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(inputStatus);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(inputDate);
            panel4.Controls.Add(inputCustomerId);
            panel4.Controls.Add(inputCarId);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button4);
            panel4.ForeColor = SystemColors.ControlText;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(829, 281);
            panel4.TabIndex = 87;
            // 
            // inputDestination
            // 
            inputDestination.Location = new Point(230, 239);
            inputDestination.Margin = new Padding(3, 2, 3, 2);
            inputDestination.Name = "inputDestination";
            inputDestination.Size = new Size(194, 23);
            inputDestination.TabIndex = 151;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(230, 218);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 150;
            label5.Text = "Điểm đến";
            // 
            // inputStart
            // 
            inputStart.Location = new Point(230, 193);
            inputStart.Margin = new Padding(3, 2, 3, 2);
            inputStart.Name = "inputStart";
            inputStart.Size = new Size(194, 23);
            inputStart.TabIndex = 149;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(230, 172);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 148;
            label4.Text = "Điểm xuất phát";
            label4.Click += label4_Click;
            // 
            // inputPeriod
            // 
            inputPeriod.Location = new Point(230, 133);
            inputPeriod.Margin = new Padding(3, 2, 3, 2);
            inputPeriod.Name = "inputPeriod";
            inputPeriod.Size = new Size(194, 23);
            inputPeriod.TabIndex = 147;
            inputPeriod.TextChanged += inputPeriod_TextChanged;
            // 
            // S14
            // 
            S14.AutoSize = true;
            S14.ForeColor = SystemColors.ButtonHighlight;
            S14.Location = new Point(710, 109);
            S14.Margin = new Padding(3, 2, 3, 2);
            S14.Name = "S14";
            S14.Size = new Size(114, 19);
            S14.TabIndex = 146;
            S14.Text = "Cảm biến tốc độ";
            S14.UseVisualStyleBackColor = true;
            S14.Click += handleCheck;
            // 
            // S13
            // 
            S13.AutoSize = true;
            S13.ForeColor = SystemColors.ButtonHighlight;
            S13.Location = new Point(710, 81);
            S13.Margin = new Padding(3, 2, 3, 2);
            S13.Name = "S13";
            S13.Size = new Size(83, 19);
            S13.TabIndex = 145;
            S13.Text = "Camera lùi";
            S13.UseVisualStyleBackColor = true;
            S13.Click += handleCheck;
            // 
            // S12
            // 
            S12.AutoSize = true;
            S12.ForeColor = SystemColors.ButtonHighlight;
            S12.Location = new Point(579, 199);
            S12.Margin = new Padding(3, 2, 3, 2);
            S12.Name = "S12";
            S12.Size = new Size(88, 19);
            S12.TabIndex = 144;
            S12.Text = "Camera 360";
            S12.UseVisualStyleBackColor = true;
            S12.Click += handleCheck;
            // 
            // S11
            // 
            S11.AutoSize = true;
            S11.ForeColor = SystemColors.ButtonHighlight;
            S11.Location = new Point(579, 176);
            S11.Margin = new Padding(3, 2, 3, 2);
            S11.Name = "S11";
            S11.Size = new Size(101, 19);
            S11.TabIndex = 143;
            S11.Text = "Lốp dự phòng";
            S11.UseVisualStyleBackColor = true;
            S11.Click += handleCheck;
            // 
            // S10
            // 
            S10.AutoSize = true;
            S10.ForeColor = SystemColors.ButtonHighlight;
            S10.Location = new Point(579, 153);
            S10.Margin = new Padding(3, 2, 3, 2);
            S10.Name = "S10";
            S10.Size = new Size(87, 19);
            S10.TabIndex = 142;
            S10.Text = "Định vị GPS";
            S10.UseVisualStyleBackColor = true;
            S10.Click += handleCheck;
            // 
            // S09
            // 
            S09.AutoSize = true;
            S09.ForeColor = SystemColors.ButtonHighlight;
            S09.Location = new Point(579, 130);
            S09.Margin = new Padding(3, 2, 3, 2);
            S09.Name = "S09";
            S09.Size = new Size(125, 19);
            S09.TabIndex = 141;
            S09.Text = "Cảm biến va chạm";
            S09.UseVisualStyleBackColor = true;
            S09.Click += handleCheck;
            // 
            // S08
            // 
            S08.AutoSize = true;
            S08.ForeColor = SystemColors.ButtonHighlight;
            S08.Location = new Point(579, 107);
            S08.Margin = new Padding(3, 2, 3, 2);
            S08.Name = "S08";
            S08.Size = new Size(125, 19);
            S08.TabIndex = 140;
            S08.Text = "Camera hành trình";
            S08.UseVisualStyleBackColor = true;
            S08.Click += handleCheck;
            // 
            // S07
            // 
            S07.AutoSize = true;
            S07.ForeColor = SystemColors.ButtonHighlight;
            S07.Location = new Point(579, 81);
            S07.Margin = new Padding(3, 2, 3, 2);
            S07.Name = "S07";
            S07.Size = new Size(78, 19);
            S07.TabIndex = 139;
            S07.Text = "Bluetooth";
            S07.UseVisualStyleBackColor = true;
            S07.Click += handleCheck;
            // 
            // S06
            // 
            S06.AutoSize = true;
            S06.ForeColor = SystemColors.ButtonHighlight;
            S06.Location = new Point(438, 201);
            S06.Margin = new Padding(3, 2, 3, 2);
            S06.Name = "S06";
            S06.Size = new Size(137, 19);
            S06.TabIndex = 138;
            S06.Text = "Nắp thùng xe bán tải";
            S06.UseVisualStyleBackColor = true;
            S06.Click += handleCheck;
            // 
            // S05
            // 
            S05.AutoSize = true;
            S05.ForeColor = SystemColors.ButtonHighlight;
            S05.Location = new Point(438, 178);
            S05.Margin = new Padding(3, 2, 3, 2);
            S05.Name = "S05";
            S05.Size = new Size(94, 19);
            S05.TabIndex = 137;
            S05.Text = "Khe cắm usb";
            S05.UseVisualStyleBackColor = true;
            S05.CheckedChanged += handleCheck;
            // 
            // S04
            // 
            S04.AutoSize = true;
            S04.ForeColor = SystemColors.ButtonHighlight;
            S04.Location = new Point(438, 155);
            S04.Margin = new Padding(3, 2, 3, 2);
            S04.Name = "S04";
            S04.Size = new Size(83, 19);
            S04.TabIndex = 136;
            S04.Text = "Cửa sổ trời";
            S04.UseVisualStyleBackColor = true;
            S04.Click += handleCheck;
            // 
            // S03
            // 
            S03.AutoSize = true;
            S03.ForeColor = SystemColors.ButtonHighlight;
            S03.Location = new Point(438, 132);
            S03.Margin = new Padding(3, 2, 3, 2);
            S03.Name = "S03";
            S03.Size = new Size(97, 19);
            S03.TabIndex = 135;
            S03.Text = "Cảm biến lốp";
            S03.UseVisualStyleBackColor = true;
            S03.Click += handleCheck;
            // 
            // S02
            // 
            S02.AutoSize = true;
            S02.ForeColor = SystemColors.ButtonHighlight;
            S02.Location = new Point(438, 109);
            S02.Margin = new Padding(3, 2, 3, 2);
            S02.Name = "S02";
            S02.Size = new Size(101, 19);
            S02.TabIndex = 134;
            S02.Text = "Camera cập lề";
            S02.UseVisualStyleBackColor = true;
            S02.Click += handleCheck;
            // 
            // S01
            // 
            S01.AutoSize = true;
            S01.ForeColor = SystemColors.ButtonHighlight;
            S01.Location = new Point(438, 83);
            S01.Margin = new Padding(3, 2, 3, 2);
            S01.Name = "S01";
            S01.Size = new Size(63, 19);
            S01.TabIndex = 133;
            S01.Text = "Bản đồ";
            S01.UseVisualStyleBackColor = true;
            S01.CheckedChanged += handleCheck;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(438, 58);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 132;
            label3.Text = "Tính năng";
            // 
            // inputStatus
            // 
            inputStatus.FormattingEnabled = true;
            inputStatus.Items.AddRange(new object[] { "Đang cho thuê", "Đã thanh toán" });
            inputStatus.Location = new Point(5, 193);
            inputStatus.Margin = new Padding(3, 2, 3, 2);
            inputStatus.Name = "inputStatus";
            inputStatus.Size = new Size(210, 23);
            inputStatus.TabIndex = 131;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(5, 172);
            label15.Name = "label15";
            label15.Size = new Size(80, 20);
            label15.TabIndex = 130;
            label15.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(5, 58);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 128;
            label2.Text = "Số CMND khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(5, 58);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 127;
            // 
            // inputDate
            // 
            inputDate.Location = new Point(5, 134);
            inputDate.Margin = new Padding(3, 2, 3, 2);
            inputDate.Name = "inputDate";
            inputDate.Size = new Size(210, 23);
            inputDate.TabIndex = 126;
            // 
            // inputCustomerId
            // 
            inputCustomerId.Location = new Point(5, 81);
            inputCustomerId.Margin = new Padding(3, 2, 3, 2);
            inputCustomerId.Name = "inputCustomerId";
            inputCustomerId.Size = new Size(210, 23);
            inputCustomerId.TabIndex = 117;
            // 
            // inputCarId
            // 
            inputCarId.Location = new Point(230, 80);
            inputCarId.Margin = new Padding(3, 2, 3, 2);
            inputCarId.Name = "inputCarId";
            inputCarId.Size = new Size(194, 23);
            inputCarId.TabIndex = 112;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(230, 58);
            label16.Name = "label16";
            label16.Size = new Size(46, 20);
            label16.TabIndex = 111;
            label16.Text = "ID xe";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(5, 16);
            label17.Name = "label17";
            label17.Size = new Size(193, 25);
            label17.TabIndex = 110;
            label17.Text = "Quản lý đơn đặt xe";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ControlLightLight;
            label18.Location = new Point(5, 112);
            label18.Name = "label18";
            label18.Size = new Size(101, 20);
            label18.TabIndex = 103;
            label18.Text = "Ngày thuê xe";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ControlLightLight;
            label19.Location = new Point(230, 112);
            label19.Name = "label19";
            label19.Size = new Size(103, 20);
            label19.TabIndex = 101;
            label19.Text = "Số ngày thuê";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ControlLightLight;
            label20.Location = new Point(5, 58);
            label20.Name = "label20";
            label20.Size = new Size(0, 20);
            label20.TabIndex = 100;
            // 
            // button1
            // 
            button1.Location = new Point(558, 239);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(75, 21);
            button1.TabIndex = 79;
            button1.Text = "Cập nhật";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(498, 239);
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
            button4.Location = new Point(438, 239);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(52, 21);
            button4.TabIndex = 77;
            button4.Text = "Thêm";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 279);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(829, 186);
            dataGridView1.TabIndex = 132;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Order";
            Size = new Size(829, 465);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private DateTimePicker inputDate;
        private TextBox inputCustomerId;
        private TextBox inputCarId;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label20;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label1;
        private Label label19;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox inputStatus;
        private Label label15;
        private DataGridView dataGridView1;
        private CheckBox S12;
        private CheckBox S11;
        private CheckBox S10;
        private CheckBox S09;
        private CheckBox S08;
        private CheckBox S07;
        private CheckBox S06;
        private CheckBox S05;
        private CheckBox S04;
        private CheckBox S03;
        private CheckBox S02;
        private CheckBox S01;
        private Label label3;
        private CheckBox S13;
        private CheckBox S14;
        private TextBox inputPeriod;
        private TextBox inputDestination;
        private Label label5;
        private TextBox inputStart;
        private Label label4;
    }
}
