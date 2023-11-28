namespace WeCar.User_Control
{
    partial class carManagement
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
            selectType = new ComboBox();
            fuelGroup = new Panel();
            F02 = new RadioButton();
            F01 = new RadioButton();
            F03 = new RadioButton();
            inputPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            inputBrand = new TextBox();
            inputCarId = new TextBox();
            inputCarName = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            button1 = new Button();
            button3 = new Button();
            btnAdd = new Button();
            button5 = new Button();
            inputBox = new TextBox();
            dataGridView1 = new DataGridView();
            panel4.SuspendLayout();
            fuelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(selectType);
            panel4.Controls.Add(fuelGroup);
            panel4.Controls.Add(inputPrice);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(inputBrand);
            panel4.Controls.Add(inputCarId);
            panel4.Controls.Add(inputCarName);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(inputBox);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(3, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(826, 256);
            panel4.TabIndex = 85;
            // 
            // selectType
            // 
            selectType.FormattingEnabled = true;
            selectType.Location = new Point(29, 137);
            selectType.Margin = new Padding(3, 2, 3, 2);
            selectType.Name = "selectType";
            selectType.Size = new Size(256, 23);
            selectType.TabIndex = 159;
            selectType.SelectedIndexChanged += selectType_SelectedIndexChanged;
            selectType.SelectionChangeCommitted += selectType_SelectionChangeCommitted;
            // 
            // fuelGroup
            // 
            fuelGroup.Controls.Add(F02);
            fuelGroup.Controls.Add(F01);
            fuelGroup.Controls.Add(F03);
            fuelGroup.Location = new Point(29, 194);
            fuelGroup.Name = "fuelGroup";
            fuelGroup.Size = new Size(234, 36);
            fuelGroup.TabIndex = 158;
            // 
            // F02
            // 
            F02.AutoSize = true;
            F02.ForeColor = SystemColors.ControlLightLight;
            F02.Location = new Point(72, 6);
            F02.Margin = new Padding(3, 2, 3, 2);
            F02.Name = "F02";
            F02.Size = new Size(79, 19);
            F02.TabIndex = 154;
            F02.TabStop = true;
            F02.Text = "Dầu diesel";
            F02.UseVisualStyleBackColor = true;
            // 
            // F01
            // 
            F01.AutoSize = true;
            F01.ForeColor = SystemColors.ControlLightLight;
            F01.Location = new Point(3, 6);
            F01.Margin = new Padding(3, 2, 3, 2);
            F01.Name = "F01";
            F01.Size = new Size(52, 19);
            F01.TabIndex = 153;
            F01.TabStop = true;
            F01.Text = "Xăng";
            F01.UseVisualStyleBackColor = true;
            // 
            // F03
            // 
            F03.AutoSize = true;
            F03.ForeColor = SystemColors.ControlLightLight;
            F03.Location = new Point(180, 6);
            F03.Margin = new Padding(3, 2, 3, 2);
            F03.Name = "F03";
            F03.Size = new Size(49, 19);
            F03.TabIndex = 155;
            F03.TabStop = true;
            F03.Text = "Điện";
            F03.UseVisualStyleBackColor = true;
            // 
            // inputPrice
            // 
            inputPrice.Location = new Point(311, 190);
            inputPrice.Margin = new Padding(3, 2, 3, 2);
            inputPrice.Name = "inputPrice";
            inputPrice.Size = new Size(256, 23);
            inputPrice.TabIndex = 157;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(311, 168);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 156;
            label1.Text = "Giá thuê/Ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(29, 168);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 140;
            label2.Text = "Nhiên liệu";
            // 
            // inputBrand
            // 
            inputBrand.Location = new Point(311, 137);
            inputBrand.Margin = new Padding(3, 2, 3, 2);
            inputBrand.Name = "inputBrand";
            inputBrand.Size = new Size(256, 23);
            inputBrand.TabIndex = 119;
            // 
            // inputCarId
            // 
            inputCarId.Location = new Point(29, 82);
            inputCarId.Margin = new Padding(3, 2, 3, 2);
            inputCarId.Name = "inputCarId";
            inputCarId.Size = new Size(256, 23);
            inputCarId.TabIndex = 117;
            // 
            // inputCarName
            // 
            inputCarName.Location = new Point(311, 81);
            inputCarName.Margin = new Padding(3, 2, 3, 2);
            inputCarName.Name = "inputCarName";
            inputCarName.Size = new Size(256, 23);
            inputCarName.TabIndex = 112;
            inputCarName.TextChanged += textBox8_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(311, 59);
            label16.Name = "label16";
            label16.Size = new Size(60, 20);
            label16.TabIndex = 111;
            label16.Text = "Tên Xe";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(29, 17);
            label17.Name = "label17";
            label17.Size = new Size(157, 25);
            label17.TabIndex = 110;
            label17.Text = "Quản lý xe ô tô";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ControlLightLight;
            label18.Location = new Point(29, 113);
            label18.Name = "label18";
            label18.Size = new Size(59, 20);
            label18.TabIndex = 103;
            label18.Text = "Loại xe";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ControlLightLight;
            label19.Location = new Point(311, 113);
            label19.Name = "label19";
            label19.Size = new Size(68, 20);
            label19.TabIndex = 101;
            label19.Text = "Hãng xe";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ControlLightLight;
            label20.Location = new Point(29, 59);
            label20.Name = "label20";
            label20.Size = new Size(50, 20);
            label20.TabIndex = 100;
            label20.Text = "ID Xe";
            // 
            // button1
            // 
            button1.Location = new Point(482, 236);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(67, 21);
            button1.TabIndex = 79;
            button1.Text = "Cập nhật";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(426, 236);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(52, 21);
            button3.TabIndex = 78;
            button3.Text = "Xóa";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += handleDelCar;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(369, 236);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(52, 21);
            btnAdd.TabIndex = 77;
            btnAdd.Text = "Thêm";
            btnAdd.TextAlign = ContentAlignment.TopCenter;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += addBtn_click;
            // 
            // button5
            // 
            button5.Location = new Point(312, 236);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(52, 21);
            button5.TabIndex = 76;
            button5.Text = "Tìm";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // inputBox
            // 
            inputBox.Location = new Point(29, 235);
            inputBox.Margin = new Padding(3, 2, 3, 2);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(256, 23);
            inputBox.TabIndex = 74;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 276);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(826, 186);
            dataGridView1.TabIndex = 113;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // carManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "carManagement";
            Size = new Size(829, 465);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            fuelGroup.ResumeLayout(false);
            fuelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private TextBox inputBrand;
        private TextBox inputCarId;
        private TextBox inputCarName;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Button button1;
        private Button button3;
        private Button btnAdd;
        private Button button5;
        private TextBox inputBox;
        private RadioButton F01;
        private Label label2;
        private RadioButton F03;
        private RadioButton F02;
        private DataGridView dataGridView1;
        private TextBox inputPrice;
        private Label label1;
        private Panel fuelGroup;
        private ComboBox selectType;
    }
}
