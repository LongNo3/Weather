namespace Weather
{
    partial class WeatherMain
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
            lblToday = new Label();
            lblCurrentWeathr = new Label();
            lblCurrentTemperatureMax = new Label();
            lblCurrentTemperature = new Label();
            lblCurrentTemperatureMin = new Label();
            lblErrer = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pboxMain = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxMain).BeginInit();
            SuspendLayout();
            // 
            // lblToday
            // 
            lblToday.AutoSize = true;
            lblToday.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblToday.Location = new Point(8, 7);
            lblToday.Name = "lblToday";
            lblToday.Size = new Size(251, 31);
            lblToday.TabIndex = 0;
            lblToday.Text = "YYYY年MM月DD日";
            // 
            // lblCurrentWeathr
            // 
            lblCurrentWeathr.AutoSize = true;
            lblCurrentWeathr.Font = new Font("メイリオ", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblCurrentWeathr.Location = new Point(58, 182);
            lblCurrentWeathr.Name = "lblCurrentWeathr";
            lblCurrentWeathr.Size = new Size(126, 41);
            lblCurrentWeathr.TabIndex = 2;
            lblCurrentWeathr.Text = "天気表示";
            // 
            // lblCurrentTemperatureMax
            // 
            lblCurrentTemperatureMax.AutoSize = true;
            lblCurrentTemperatureMax.Location = new Point(18, 246);
            lblCurrentTemperatureMax.Name = "lblCurrentTemperatureMax";
            lblCurrentTemperatureMax.Size = new Size(38, 15);
            lblCurrentTemperatureMax.TabIndex = 3;
            lblCurrentTemperatureMax.Text = "label1";
            // 
            // lblCurrentTemperature
            // 
            lblCurrentTemperature.AutoSize = true;
            lblCurrentTemperature.Location = new Point(94, 246);
            lblCurrentTemperature.Name = "lblCurrentTemperature";
            lblCurrentTemperature.Size = new Size(38, 15);
            lblCurrentTemperature.TabIndex = 4;
            lblCurrentTemperature.Text = "label2";
            // 
            // lblCurrentTemperatureMin
            // 
            lblCurrentTemperatureMin.AutoSize = true;
            lblCurrentTemperatureMin.Location = new Point(170, 246);
            lblCurrentTemperatureMin.Name = "lblCurrentTemperatureMin";
            lblCurrentTemperatureMin.Size = new Size(38, 15);
            lblCurrentTemperatureMin.TabIndex = 5;
            lblCurrentTemperatureMin.Text = "label3";
            // 
            // lblErrer
            // 
            lblErrer.AutoSize = true;
            lblErrer.Location = new Point(18, 417);
            lblErrer.Name = "lblErrer";
            lblErrer.Size = new Size(38, 15);
            lblErrer.TabIndex = 6;
            lblErrer.Text = "label3";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pboxMain, 0, 0);
            tableLayoutPanel1.Location = new Point(19, 41);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(226, 202);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // pboxMain
            // 
            pboxMain.Dock = DockStyle.Fill;
            pboxMain.Location = new Point(3, 3);
            pboxMain.Name = "pboxMain";
            pboxMain.Size = new Size(220, 196);
            pboxMain.SizeMode = PictureBoxSizeMode.CenterImage;
            pboxMain.TabIndex = 0;
            pboxMain.TabStop = false;
            // 
            // WeatherMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblErrer);
            Controls.Add(lblCurrentTemperatureMin);
            Controls.Add(lblCurrentTemperature);
            Controls.Add(lblCurrentTemperatureMax);
            Controls.Add(lblCurrentWeathr);
            Controls.Add(lblToday);
            Controls.Add(tableLayoutPanel1);
            Name = "WeatherMain";
            Text = "天気";
            Load += WeatherMainLoad;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblToday;
        private Label lblCurrentWeathr;
        private Label lblCurrentTemperatureMax;
        private Label lblCurrentTemperature;
        private Label lblCurrentTemperatureMin;
        private Label lblErrer;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pboxMain;
    }
}
