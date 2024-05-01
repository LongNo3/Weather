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
            lblNextDay1 = new Label();
            lblNextDay2 = new Label();
            lblNextDay3 = new Label();
            lblNextDay4 = new Label();
            lblNextDay5 = new Label();
            lblNextDay6 = new Label();
            pbNextWeathr1 = new PictureBox();
            lblNextWeathr1 = new Label();
            lblNextTemperatureMax1 = new Label();
            lblCurrentTemperatureMaxText = new Label();
            lblCurrentTemperatureText = new Label();
            lblCurrentTemperatureMinText = new Label();
            lblNextTemperatureMin1 = new Label();
            lblNextTemperatureMaxText1 = new Label();
            lblNextTemperatureMinText1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbShita).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNextWeathr1).BeginInit();
            SuspendLayout();
            // 
            // lblToday
            // 
            lblToday.AutoSize = true;
            lblToday.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblToday.Location = new Point(12, 315);
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
            lblCurrentWeathr.Location = new Point(30, 211);
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
            lblCurrentTemperatureMax.Location = new Point(23, 267);
            lblCurrentTemperatureMax.Name = "lblCurrentTemperatureMax";
            lblCurrentTemperatureMax.Size = new Size(44, 21);
            lblCurrentTemperatureMax.TabIndex = 3;
            lblCurrentTemperatureMax.Text = "00℃";
            // 
            // lblCurrentTemperature
            // 
            lblCurrentTemperature.AutoSize = true;
            lblCurrentTemperature.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            lblCurrentTemperature.Location = new Point(101, 267);
            lblCurrentTemperature.Name = "lblCurrentTemperature";
            lblCurrentTemperature.Size = new Size(44, 21);
            lblCurrentTemperature.TabIndex = 4;
            lblCurrentTemperature.Text = "00℃";
            // 
            // lblCurrentTemperatureMin
            // 
            lblCurrentTemperatureMin.AutoSize = true;
            lblCurrentTemperatureMin.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            lblCurrentTemperatureMin.Location = new Point(177, 267);
            lblCurrentTemperatureMin.Name = "lblCurrentTemperatureMin";
            lblCurrentTemperatureMin.Size = new Size(44, 21);
            lblCurrentTemperatureMin.TabIndex = 5;
            lblCurrentTemperatureMin.Text = "00℃";
            // 
            // lblErrer
            // 
            lblErrer.AutoSize = true;
            lblErrer.Location = new Point(18, 417);
            lblErrer.Name = "lblErrer";
            lblErrer.Size = new Size(88, 15);
            lblErrer.TabIndex = 6;
            lblErrer.Text = "エラーメッセージ欄";
            // 
            // pbShita
            // 
            pbShita.InitialImage = null;
            pbShita.Location = new Point(30, 12);
            pbShita.Name = "pbShita";
            pbShita.Size = new Size(200, 200);
            pbShita.TabIndex = 7;
            pbShita.TabStop = false;
            // 
            // lblNextDay1
            // 
            lblNextDay1.AutoSize = true;
            lblNextDay1.Location = new Point(294, 65);
            lblNextDay1.Name = "lblNextDay1";
            lblNextDay1.Size = new Size(43, 15);
            lblNextDay1.TabIndex = 8;
            lblNextDay1.Text = "１日後";
            // 
            // lblNextDay2
            // 
            lblNextDay2.AutoSize = true;
            lblNextDay2.Location = new Point(294, 212);
            lblNextDay2.Name = "lblNextDay2";
            lblNextDay2.Size = new Size(43, 15);
            lblNextDay2.TabIndex = 9;
            lblNextDay2.Text = "２日後";
            // 
            // lblNextDay3
            // 
            lblNextDay3.AutoSize = true;
            lblNextDay3.Location = new Point(294, 247);
            lblNextDay3.Name = "lblNextDay3";
            lblNextDay3.Size = new Size(43, 15);
            lblNextDay3.TabIndex = 10;
            lblNextDay3.Text = "３日後";
            // 
            // lblNextDay4
            // 
            lblNextDay4.AutoSize = true;
            lblNextDay4.Location = new Point(294, 287);
            lblNextDay4.Name = "lblNextDay4";
            lblNextDay4.Size = new Size(43, 15);
            lblNextDay4.TabIndex = 11;
            lblNextDay4.Text = "４日後";
            // 
            // lblNextDay5
            // 
            lblNextDay5.AutoSize = true;
            lblNextDay5.Location = new Point(294, 329);
            lblNextDay5.Name = "lblNextDay5";
            lblNextDay5.Size = new Size(43, 15);
            lblNextDay5.TabIndex = 12;
            lblNextDay5.Text = "５日後";
            // 
            // lblNextDay6
            // 
            lblNextDay6.AutoSize = true;
            lblNextDay6.Location = new Point(294, 374);
            lblNextDay6.Name = "lblNextDay6";
            lblNextDay6.Size = new Size(43, 15);
            lblNextDay6.TabIndex = 13;
            lblNextDay6.Text = "６日後";
            // 
            // pbNextWeathr1
            // 
            pbNextWeathr1.InitialImage = null;
            pbNextWeathr1.Location = new Point(294, 12);
            pbNextWeathr1.Name = "pbNextWeathr1";
            pbNextWeathr1.Size = new Size(50, 50);
            pbNextWeathr1.TabIndex = 14;
            pbNextWeathr1.TabStop = false;
            // 
            // lblNextWeathr1
            // 
            lblNextWeathr1.AutoSize = true;
            lblNextWeathr1.Location = new Point(350, 9);
            lblNextWeathr1.Name = "lblNextWeathr1";
            lblNextWeathr1.Size = new Size(55, 15);
            lblNextWeathr1.TabIndex = 15;
            lblNextWeathr1.Text = "天気表示";
            // 
            // lblNextTemperatureMax1
            // 
            lblNextTemperatureMax1.AutoSize = true;
            lblNextTemperatureMax1.Location = new Point(414, 27);
            lblNextTemperatureMax1.Name = "lblNextTemperatureMax1";
            lblNextTemperatureMax1.Size = new Size(31, 15);
            lblNextTemperatureMax1.TabIndex = 16;
            lblNextTemperatureMax1.Text = "00℃";
            // 
            // lblCurrentTemperatureMaxText
            // 
            lblCurrentTemperatureMaxText.AutoSize = true;
            lblCurrentTemperatureMaxText.Location = new Point(19, 252);
            lblCurrentTemperatureMaxText.Name = "lblCurrentTemperatureMaxText";
            lblCurrentTemperatureMaxText.Size = new Size(55, 15);
            lblCurrentTemperatureMaxText.TabIndex = 17;
            lblCurrentTemperatureMaxText.Text = "最高気温";
            // 
            // lblCurrentTemperatureText
            // 
            lblCurrentTemperatureText.AutoSize = true;
            lblCurrentTemperatureText.Location = new Point(95, 252);
            lblCurrentTemperatureText.Name = "lblCurrentTemperatureText";
            lblCurrentTemperatureText.Size = new Size(55, 15);
            lblCurrentTemperatureText.TabIndex = 18;
            lblCurrentTemperatureText.Text = "現在気温";
            // 
            // lblCurrentTemperatureMinText
            // 
            lblCurrentTemperatureMinText.AutoSize = true;
            lblCurrentTemperatureMinText.Location = new Point(171, 252);
            lblCurrentTemperatureMinText.Name = "lblCurrentTemperatureMinText";
            lblCurrentTemperatureMinText.Size = new Size(55, 15);
            lblCurrentTemperatureMinText.TabIndex = 19;
            lblCurrentTemperatureMinText.Text = "最低気温";
            // 
            // lblNextTemperatureMin1
            // 
            lblNextTemperatureMin1.AutoSize = true;
            lblNextTemperatureMin1.Location = new Point(414, 47);
            lblNextTemperatureMin1.Name = "lblNextTemperatureMin1";
            lblNextTemperatureMin1.Size = new Size(31, 15);
            lblNextTemperatureMin1.TabIndex = 20;
            lblNextTemperatureMin1.Text = "00℃";
            // 
            // lblNextTemperatureMaxText1
            // 
            lblNextTemperatureMaxText1.AutoSize = true;
            lblNextTemperatureMaxText1.Location = new Point(350, 27);
            lblNextTemperatureMaxText1.Name = "lblNextTemperatureMaxText1";
            lblNextTemperatureMaxText1.Size = new Size(67, 15);
            lblNextTemperatureMaxText1.TabIndex = 21;
            lblNextTemperatureMaxText1.Text = "最高気温：";
            // 
            // lblNextTemperatureMinText1
            // 
            lblNextTemperatureMinText1.AutoSize = true;
            lblNextTemperatureMinText1.Location = new Point(350, 47);
            lblNextTemperatureMinText1.Name = "lblNextTemperatureMinText1";
            lblNextTemperatureMinText1.Size = new Size(67, 15);
            lblNextTemperatureMinText1.TabIndex = 22;
            lblNextTemperatureMinText1.Text = "最低気温：";
            // 
            // WeatherMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNextTemperatureMinText1);
            Controls.Add(lblNextTemperatureMaxText1);
            Controls.Add(lblNextTemperatureMin1);
            Controls.Add(lblCurrentTemperatureMinText);
            Controls.Add(lblCurrentTemperatureText);
            Controls.Add(lblCurrentTemperatureMaxText);
            Controls.Add(lblNextTemperatureMax1);
            Controls.Add(lblNextWeathr1);
            Controls.Add(pbNextWeathr1);
            Controls.Add(lblNextDay6);
            Controls.Add(lblNextDay5);
            Controls.Add(lblNextDay4);
            Controls.Add(lblNextDay3);
            Controls.Add(lblNextDay2);
            Controls.Add(lblNextDay1);
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
            ((System.ComponentModel.ISupportInitialize)pbNextWeathr1).EndInit();
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
        private Label lblNextDay1;
        private Label lblNextDay2;
        private Label lblNextDay3;
        private Label lblNextDay4;
        private Label lblNextDay5;
        private Label lblNextDay6;
        private PictureBox pbNextWeathr1;
        private Label lblNextWeathr1;
        private Label lblNextTemperatureMax1;
        private Label lblCurrentTemperatureMaxText;
        private Label lblCurrentTemperatureText;
        private Label lblCurrentTemperatureMinText;
        private Label lblNextTemperatureMin1;
        private Label lblNextTemperatureMaxText1;
        private Label lblNextTemperatureMinText1;
    }
}
