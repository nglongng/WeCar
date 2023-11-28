namespace WeCar
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel2 = new Panel();
            label4 = new Label();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelContainer = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(1, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 465);
            panel2.TabIndex = 48;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AccessibleName = "";
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(63, 420);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 53;
            label4.Text = "Đăng xuất";
            label4.Click += label4_Click;
            label4.MouseLeave += label1_MouseLeave;
            label4.MouseHover += label1_MouseHover;
            // 
            // label6
            // 
            label6.AccessibleName = "";
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(52, 213);
            label6.Name = "label6";
            label6.Size = new Size(171, 25);
            label6.TabIndex = 51;
            label6.Text = "Quản lý dữ liệu";
            label6.Click += label6_Click;
            label6.DragEnter += handleHover;
            label6.MouseLeave += label6_MouseLeave;
            label6.MouseHover += label1_MouseHover;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(10, 213);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 27);
            pictureBox6.TabIndex = 50;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AccessibleName = "";
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(52, 164);
            label5.Name = "label5";
            label5.Size = new Size(196, 25);
            label5.TabIndex = 49;
            label5.Text = "Báo cáo thống kê";
            label5.Click += label5_Click;
            label5.MouseLeave += label1_MouseLeave;
            label5.MouseHover += label1_MouseHover;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(10, 164);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 27);
            pictureBox5.TabIndex = 48;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label3
            // 
            label3.AccessibleName = "";
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 117);
            label3.Name = "label3";
            label3.Size = new Size(196, 25);
            label3.TabIndex = 45;
            label3.Text = "Danh sách đặt xe";
            label3.Click += label3_Click;
            label3.MouseLeave += label1_MouseLeave;
            label3.MouseHover += label1_MouseHover;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(10, 117);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 27);
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AccessibleName = "";
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 22);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 40;
            label1.Text = "Quản lý xe";
            label1.Click += label1_Click;
            label1.MouseLeave += label1_MouseLeave;
            label1.MouseHover += label1_MouseHover;
            // 
            // label2
            // 
            label2.AccessibleName = "";
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 69);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 43;
            label2.Text = "Khách hàng";
            label2.Click += label2_Click;
            label2.MouseLeave += label1_MouseLeave;
            label2.MouseHover += label1_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(10, 22);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 27);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(10, 69);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 27);
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.Black;
            panelContainer.Location = new Point(266, 2);
            panelContainer.Margin = new Padding(3, 2, 3, 2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(829, 465);
            panelContainer.TabIndex = 49;
            panelContainer.Paint += PanelContainer_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1096, 467);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox6;
        private Label label5;
        private PictureBox pictureBox5;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelContainer;
        private Label label4;
        private Label label6;
    }
}