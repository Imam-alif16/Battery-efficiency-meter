﻿namespace PengukurBaterai
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
            this.components = new System.ComponentModel.Container();
            this.PercentageBar = new System.Windows.Forms.ProgressBar();
            this.Percentage = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeLeft = new System.Windows.Forms.Timer(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LabelHour = new System.Windows.Forms.Label();
            this.LabelSecond = new System.Windows.Forms.Label();
            this.LabelMinute = new System.Windows.Forms.Label();
            this.StartBTN = new System.Windows.Forms.Button();
            this.StopBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PercentageBar
            // 
            this.PercentageBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PercentageBar.Location = new System.Drawing.Point(17, 62);
            this.PercentageBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PercentageBar.Name = "PercentageBar";
            this.PercentageBar.Size = new System.Drawing.Size(809, 36);
            this.PercentageBar.TabIndex = 0;
            // 
            // Percentage
            // 
            this.Percentage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Percentage.Location = new System.Drawing.Point(836, 62);
            this.Percentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(99, 36);
            this.Percentage.TabIndex = 1;
            this.Percentage.Text = "0%";
            this.Percentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeLabel.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.Location = new System.Drawing.Point(17, 15);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(359, 40);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "Remaining Time = 00 : 00 : 00";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeLeft
            // 
            this.TimeLeft.Enabled = true;
            this.TimeLeft.Interval = 1000;
            this.TimeLeft.Tick += new System.EventHandler(this.SisaWaktu_Tick);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 222);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(17, 268);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(397, 129);
            this.listBox1.TabIndex = 10;
            // 
            // LabelHour
            // 
            this.LabelHour.AutoSize = true;
            this.LabelHour.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelHour.Location = new System.Drawing.Point(73, 109);
            this.LabelHour.Name = "LabelHour";
            this.LabelHour.Size = new System.Drawing.Size(67, 54);
            this.LabelHour.TabIndex = 11;
            this.LabelHour.Text = "00";
            this.LabelHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSecond
            // 
            this.LabelSecond.AutoSize = true;
            this.LabelSecond.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelSecond.Location = new System.Drawing.Point(295, 109);
            this.LabelSecond.Name = "LabelSecond";
            this.LabelSecond.Size = new System.Drawing.Size(67, 54);
            this.LabelSecond.TabIndex = 13;
            this.LabelSecond.Text = "00";
            this.LabelSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMinute
            // 
            this.LabelMinute.AutoSize = true;
            this.LabelMinute.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelMinute.Location = new System.Drawing.Point(184, 109);
            this.LabelMinute.Name = "LabelMinute";
            this.LabelMinute.Size = new System.Drawing.Size(67, 54);
            this.LabelMinute.TabIndex = 14;
            this.LabelMinute.Text = "00";
            this.LabelMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartBTN
            // 
            this.StartBTN.Location = new System.Drawing.Point(16, 180);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(195, 38);
            this.StartBTN.TabIndex = 15;
            this.StartBTN.Text = "Start";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.Start_Click);
            // 
            // StopBTN
            // 
            this.StopBTN.Location = new System.Drawing.Point(219, 180);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(195, 38);
            this.StopBTN.TabIndex = 16;
            this.StopBTN.Text = "Stop";
            this.StopBTN.UseVisualStyleBackColor = true;
            this.StopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 54);
            this.label1.TabIndex = 17;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(257, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 54);
            this.label2.TabIndex = 18;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetBTN
            // 
            this.ResetBTN.Location = new System.Drawing.Point(219, 222);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(195, 38);
            this.ResetBTN.TabIndex = 19;
            this.ResetBTN.Text = "Reset";
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 65);
            this.button2.TabIndex = 20;
            this.button2.Text = "RECORD";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(651, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 65);
            this.button3.TabIndex = 21;
            this.button3.Text = "STOP";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(452, 243);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(374, 154);
            this.listBox2.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 480);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ResetBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopBTN);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.LabelMinute);
            this.Controls.Add(this.LabelSecond);
            this.Controls.Add(this.LabelHour);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.PercentageBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProgressBar PercentageBar;
        private Label Percentage;
        private Label TimeLabel;
        private System.Windows.Forms.Timer TimeLeft;
        private System.Windows.Forms.Timer Timer1;
        private Button button1;
        private ListBox listBox1;
        private Label LabelHour;
        private Label LabelSecond;
        private Label LabelMinute;
        private Button StartBTN;
        private Button StopBTN;
        private Label label1;
        private Label label2;
        private Button ResetBTN;
        private Button button2;
        private Button button3;
        private ListBox listBox2;
    }
}