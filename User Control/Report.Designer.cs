namespace WeCar.User_Control
{
    partial class Report
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
            label17 = new Label();
            dataGridView1 = new DataGridView();
            hangxe = new DataGridViewTextBoxColumn();
            soluong = new DataGridViewTextBoxColumn();
            doanhThu = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("SF Pro Display", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(14, 15);
            label17.Name = "label17";
            label17.Size = new Size(188, 25);
            label17.TabIndex = 111;
            label17.Text = "Báo cáo và thống kê";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { hangxe, soluong, doanhThu });
            dataGridView1.Location = new Point(0, 350);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(947, 236);
            dataGridView1.TabIndex = 112;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // hangxe
            // 
            hangxe.HeaderText = "Hãng xe";
            hangxe.Name = "hangxe";
            // 
            // soluong
            // 
            soluong.HeaderText = "Số lượng";
            soluong.Name = "soluong";
            // 
            // doanhThu
            // 
            doanhThu.HeaderText = "Doanh thu";
            doanhThu.Name = "doanhThu";
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(dataGridView1);
            Controls.Add(label17);
            Name = "Report";
            Size = new Size(947, 589);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label17;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn hangxe;
        private DataGridViewTextBoxColumn soluong;
        private DataGridViewTextBoxColumn doanhThu;
    }
}
