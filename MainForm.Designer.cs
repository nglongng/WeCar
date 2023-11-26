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
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 589);
            panel2.TabIndex = 48;
            panel2.Paint += panel2_Paint;
            // 
            // label6
            // 
            label6.AccessibleName = "";
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(60, 270);
            label6.Name = "label6";
            label6.Size = new Size(165, 34);
            label6.TabIndex = 51;
            label6.Text = "Data Management";
            label6.Click += label6_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(11, 270);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 34);
            pictureBox6.TabIndex = 50;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AccessibleName = "";
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(60, 208);
            label5.Name = "label5";
            label5.Size = new Size(154, 34);
            label5.TabIndex = 49;
            label5.Text = "Report & Statistic";
            label5.Click += label5_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(11, 208);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 34);
            pictureBox5.TabIndex = 48;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label3
            // 
            label3.AccessibleName = "";
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(60, 148);
            label3.Name = "label3";
            label3.Size = new Size(100, 34);
            label3.TabIndex = 45;
            label3.Text = "Order List";
            label3.Click += label3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(11, 148);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 34);
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AccessibleName = "";
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 28);
            label1.Name = "label1";
            label1.Size = new Size(158, 34);
            label1.TabIndex = 40;
            label1.Text = "Car Management";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AccessibleName = "";
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(60, 88);
            label2.Name = "label2";
            label2.Size = new Size(97, 34);
            label2.TabIndex = 43;
            label2.Text = "Customer";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(11, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 34);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(11, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 34);
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(232, 2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(947, 589);
            panelContainer.TabIndex = 49;
            panelContainer.Paint += PanelContainer_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1178, 592);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Name = "MainForm";
            Text = "MainForm";
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
        private Label label6;
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
    }
}