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
            pbShita = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbShita).BeginInit();
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
            lblCurrentWeathr.FlatStyle = FlatStyle.Flat;
            lblCurrentWeathr.Font = new Font("メイリオ", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblCurrentWeathr.Location = new Point(51, 246);
            lblCurrentWeathr.Name = "lblCurrentWeathr";
            lblCurrentWeathr.Size = new Size(126, 41);
            lblCurrentWeathr.TabIndex = 2;
            lblCurrentWeathr.Text = "天気表示";
            lblCurrentWeathr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentTemperatureMax
            // 
            lblCurrentTemperatureMax.AutoSize = true;
            lblCurrentTemperatureMax.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            lblCurrentTemperatureMax.Location = new Point(17, 287);
            lblCurrentTemperatureMax.Name = "lblCurrentTemperatureMax";
            lblCurrentTemperatureMax.Size = new Size(51, 21);
            lblCurrentTemperatureMax.TabIndex = 3;
            lblCurrentTemperatureMax.Text = "label1";
            // 
            // lblCurrentTemperature
            // 
            lblCurrentTemperature.AutoSize = true;
            lblCurrentTemperature.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            lblCurrentTemperature.Location = new Point(94, 287);
            lblCurrentTemperature.Name = "lblCurrentTemperature";
            lblCurrentTemperature.Size = new Size(54, 21);
            lblCurrentTemperature.TabIndex = 4;
            lblCurrentTemperature.Text = "label2";
            // 
            // lblCurrentTemperatureMin
            // 
            lblCurrentTemperatureMin.AutoSize = true;
            lblCurrentTemperatureMin.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            lblCurrentTemperatureMin.Location = new Point(168, 287);
            lblCurrentTemperatureMin.Name = "lblCurrentTemperatureMin";
            lblCurrentTemperatureMin.Size = new Size(54, 21);
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
            // pbShita
            // 
            pbShita.InitialImage = null;
            pbShita.Location = new Point(18, 43);
            pbShita.Name = "pbShita";
            pbShita.Size = new Size(200, 200);
            pbShita.TabIndex = 7;
            pbShita.TabStop = false;
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
            Controls.Add(pbShita);
            Name = "WeatherMain";
            Text = "天気";
            Load += WeatherMainLoad;
            ((System.ComponentModel.ISupportInitialize)pbShita).EndInit();
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
        private PictureBox pbShita;
    }
}
