/*
 * This file is part of AstroClock.
 *
 * AstroClock is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * AstroClock is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with AstroClock. If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AstroClock
{
    public partial class ClockForm : Form
    {
        public ClockForm()
        {
            InitializeComponent();

            sins[0] = 7.32450359365975;
            sins[1] = 9.52879391237187;
            sins[2] = 0.313173811282134;
            sins[3] = 0.189380474571641;
            sins[4] = 0.0111818278100789;
            sins[5] = 0.00457319934998596;
            coss[0] = -0.779234610109471;
            coss[1] = 2.77779966846886;
            coss[2] = 0.0592300121898352;
            coss[3] = 0.116518600690763;
            coss[4] = 0.0052571745421124;
            coss[5] = 0.00554442532098614;

            setLocation(0.464497, "KEGS, Chelmsford");

            timer.Tick += new EventHandler(UpdateClock);
            timer.Interval = 100;
            timer.Start();
        }

        private void UpdateClock(Object o, EventArgs e)
        {
            DateTime nowDate = DateTime.Now.ToUniversalTime();
            double now = dateToDouble(nowDate);
            double m = 2 * Math.PI * now / 86400 / tropicalYear;

            double deltaTaMins = 0.0;
            double deltaTaDays = 0.0;
            double[] tmp = new double[6];
            for (int i = 0; i < 6; i++)
            {
                tmp[i] = 2 * Math.PI * (i + 1) * ((now / 86400) % tropicalYear) / tropicalYear;
                vals[i] = sins[i] * Math.Sin(tmp[i]) + coss[i] * Math.Cos(tmp[i]);
                deltaTaMins -= vals[i];
            }
            deltaTaDays = deltaTaMins / 1440;

            double siderealTime = ((18.697374558 + 24.065709824419 * (now - siderealTimeOrigin) / 86400) % 24) / 24;
            
            DateTime localTimeGrn = nowDate;
            DateTime localTimePl = nowDate.AddDays(longitudeAdjustment);
            TimeSpan eot = new TimeSpan((long)(deltaTaMins * 60 * 1000 * 1000 * 10));
            DateTime solarTimeGrn = localTimeGrn.AddDays(deltaTaDays);
            DateTime solarTimePl = localTimePl.AddDays(deltaTaDays);
            TimeSpan siderealTimeGrn = new TimeSpan((long)(siderealTime * 24 * 60 * 60 * 1000 * 1000 * 10));
            TimeSpan siderealTimePl = new TimeSpan((long)((siderealTime + longitudeAdjustment) * 24 * 60 * 60 * 1000 * 1000 * 10));

            lblGrnMeanTimeVal.Text = localTimeGrn.ToString("HH:mm:ss");
            lblPlMeanTimeVal.Text = localTimePl.ToString("HH:mm:ss");
            eot = eot.Add(new TimeSpan(0, 0, 0, 0, 500));
            lblGrnEqTimeVal.Text = (eot.Ticks < 0 ?"-":"") + eot.ToString(@"hh\:mm\:ss");
            lblPlEqTimeVal.Text = lblGrnEqTimeVal.Text;
            //lblPlEqTimeVal.Text = eot.ToString(@"hh\:mm\:ss");
            lblGrnSolTimeVal.Text = solarTimeGrn.ToString("HH:mm:ss");
            lblPlSolTimeVal.Text = solarTimePl.ToString("HH:mm:ss");
            lblGrnSidTimeVal.Text = siderealTimeGrn.ToString(@"hh\:mm\:ss");
            lblPlSidTimeVal.Text = siderealTimePl.ToString(@"hh\:mm\:ss");
        }

        private void setLocation(double longitude, String name)
        {
            localLongitude = longitude;
            longitudeAdjustment = localLongitude / 360;
            location = name;
            string DisplayLoc = (Math.Floor (Math.Abs(localLongitude)) ).ToString("0") + "° ";     //(localLongitude>0)?"E":"W";
            DisplayLoc += (Math.Floor((60* Math.Abs( localLongitude)) % 60)).ToString("00") + "' ";
            DisplayLoc += (Math.Floor((.5 + 3600 * Math.Abs(localLongitude)) % 60)).ToString("00") + "\" ";
            DisplayLoc += (localLongitude == 0 ? "" : (localLongitude > 0) ? "E" : "W");
            lblPl.Text = location + " (" + DisplayLoc + ")";
            //lblPl.Text = location + " (" + localLongitude.ToString() + " degrees " + ((localLongitude > 0) ? "E" : "W") + ")";
        }

        private void changeLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetLocationForm setLoc = new SetLocationForm();
            setLoc.Location = location;
            setLoc.Longitude = localLongitude;
            if (setLoc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                setLocation(setLoc.Longitude, setLoc.Location);
            }
        }

        private static double dateToDouble(DateTime date)
        {
            DateTime epoch = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddDays(-2);
            TimeSpan t = (date - epoch);
            return t.TotalSeconds;
        }

        private static DateTime doubleToDate(double unix)
        {
            DateTime epoch = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddDays(-2);
            return epoch.AddSeconds(unix);
        }

        private Timer timer = new Timer();
        private const double tropicalYear = 365.242190419;
        private DateTime periHelionExample = new DateTime(2011, 01, 02, 22, 56, 0);
        private const double siderealYear = tropicalYear + 1;
        private double siderealTimeOrigin = dateToDouble(new DateTime(2000, 01, 01, 12, 0, 0).ToUniversalTime());
        private double localLongitude; // Degrees
        private double longitudeAdjustment; // Days
        private String location;
        private double[] sins = new double[6];
        private double[] coss = new double[6];
        private double[] vals = new double[6];
    }
}
