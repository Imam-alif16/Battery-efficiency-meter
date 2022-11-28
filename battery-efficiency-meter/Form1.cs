﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace battery_efficiency_meter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            PowerStatus ps = SystemInformation.PowerStatus;

            PercentageBar.Value = (int)(ps.BatteryLifePercent * 100);
            if (ps.BatteryLifeRemaining < 0)
                TimeLabel.Text = "Charging";
            else
                TimeLabel.Text = "Remaining Time = " + new TimeSpan(0 , 0 , ps.BatteryLifeRemaining);
                Percentage.Text = string.Format($"{ps.BatteryLifePercent * 100} %");            
        }

        //Stopwatcch
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        private void Start_But_Click(object sender, EventArgs e)
        {
            Stopwatch_Timer.Start();
            stopwatch.Start();
            //Start_But.Enabled= false;
        }
        private void Stopwatch_Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan Lap = stopwatch.Elapsed;
            lbl_Time.Text = string.Format("{0:00} : {1:00} : {2:00} : {3:00}",
                Math.Floor(Lap.TotalHours), Lap.Minutes, Lap.Seconds, Lap.Milliseconds);
        }
        int angka_depan = 0;
        private void Lap_But_Click(object sender, EventArgs e)
        {
            angka_depan += 1;
            listBox1.Items.Add(angka_depan + ".  " + lbl_Time.Text + " =   " + Percentage.Text);
        }

        private void Stop_But_Click(object sender, EventArgs e)
        {
            Stopwatch_Timer.Stop();
            stopwatch.Stop();
            //Start_But.Enabled= false;
        }

        private void Reset_But_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            lbl_Time.Text = "00 : 00 : 00 : 000";
            listBox1.Items.Clear();
            angka_depan = 0;
            //Start_But.Enabled= false;
        }
    }

}
