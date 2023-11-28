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
            label1 = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(12, 12);
            label17.Name = "label17";
            label17.Size = new Size(209, 25);
            label17.TabIndex = 111;
            label17.Text = "Báo cáo và thống kê";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { hangxe, soluong, doanhThu });
            dataGridView1.Location = new Point(21, 93);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(368, 286);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(21, 66);
            label1.Name = "label1";
            label1.Size = new Size(193, 24);
            label1.TabIndex = 113;
            label1.Text = "Thống kê theo loại xe";
            label1.Click += label1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView2.Location = new Point(395, 93);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 28;
            dataGridView2.Size = new Size(395, 286);
            dataGridView2.TabIndex = 114;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Hãng xe";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Doanh thu";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(395, 66);
            label2.Name = "label2";
            label2.Size = new Size(193, 24);
            label2.TabIndex = 115;
            label2.Text = "Thống kê theo loại xe";
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label17);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Report";
            Size = new Size(829, 465);
            Load += Report_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label17;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn hangxe;
        private DataGridViewTextBoxColumn soluong;
        private DataGridViewTextBoxColumn doanhThu;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label label2;
    }
}
