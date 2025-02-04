﻿namespace weatherapp
{
    partial class Form1
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
            maxTemp = new TextBox();
            minTemp = new TextBox();
            humidity = new TextBox();
            windSpeed = new TextBox();
            atmPressure = new TextBox();
            city = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            showBtn = new Button();
            moonPhase = new TextBox();
            label7 = new Label();
            conditionPic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)conditionPic).BeginInit();
            SuspendLayout();
            // 
            // maxTemp
            // 
            maxTemp.Location = new Point(182, 48);
            maxTemp.Name = "maxTemp";
            maxTemp.Size = new Size(100, 23);
            maxTemp.TabIndex = 0;
            // 
            // minTemp
            // 
            minTemp.Location = new Point(182, 77);
            minTemp.Name = "minTemp";
            minTemp.Size = new Size(100, 23);
            minTemp.TabIndex = 1;
            // 
            // humidity
            // 
            humidity.Location = new Point(182, 106);
            humidity.Name = "humidity";
            humidity.Size = new Size(100, 23);
            humidity.TabIndex = 2;
            // 
            // windSpeed
            // 
            windSpeed.Location = new Point(182, 135);
            windSpeed.Name = "windSpeed";
            windSpeed.Size = new Size(100, 23);
            windSpeed.TabIndex = 3;
            // 
            // atmPressure
            // 
            atmPressure.Location = new Point(182, 164);
            atmPressure.Name = "atmPressure";
            atmPressure.Size = new Size(100, 23);
            atmPressure.TabIndex = 4;
            // 
            // city
            // 
            city.Location = new Point(369, 164);
            city.Name = "city";
            city.Size = new Size(100, 23);
            city.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 56);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 6;
            label1.Text = "Maksimāla temperatūra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 85);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 7;
            label2.Text = "Minimāla temperatūra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 114);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "Mitrums";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 143);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 9;
            label4.Text = "Vēja ātrums";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 172);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 10;
            label5.Text = "Atmosfēras spiedens";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(322, 172);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 11;
            label6.Text = "Pilsēta";
            // 
            // showBtn
            // 
            showBtn.Location = new Point(322, 193);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(147, 23);
            showBtn.TabIndex = 12;
            showBtn.Text = "Parādīt prognozi";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // moonPhase
            // 
            moonPhase.Location = new Point(182, 193);
            moonPhase.Name = "moonPhase";
            moonPhase.Size = new Size(100, 23);
            moonPhase.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 201);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 14;
            label7.Text = "Mēness fāze";
            // 
            // conditionPic
            // 
            conditionPic.Location = new Point(322, 48);
            conditionPic.Name = "conditionPic";
            conditionPic.Size = new Size(147, 110);
            conditionPic.TabIndex = 15;
            conditionPic.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 471);
            Controls.Add(conditionPic);
            Controls.Add(label7);
            Controls.Add(moonPhase);
            Controls.Add(showBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(city);
            Controls.Add(atmPressure);
            Controls.Add(windSpeed);
            Controls.Add(humidity);
            Controls.Add(minTemp);
            Controls.Add(maxTemp);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)conditionPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox maxTemp;
        private TextBox minTemp;
        private TextBox humidity;
        private TextBox windSpeed;
        private TextBox atmPressure;
        private TextBox city;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button showBtn;
        private TextBox moonPhase;
        private Label label7;
        private PictureBox conditionPic;
    }
}
