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
using System.Windows.Forms;

namespace AstroClock
{
    public partial class SetLocationForm : Form
    {
        public SetLocationForm()
        {
            InitializeComponent();
        }

        public String LocationSomethingElse
        {
            get
            {
                return textboxLocation.Text;
            }
            set
            {
                textboxLocation.Text = value;
            }
        }

        public double Longitude
        {
            get
            {
                return longitudeVal;
            }
            set
            {
                longitudeVal = value;
                NUDDegrees.Enabled = true;
                NUDDegrees.Value = (decimal)Math.Abs(longitudeVal);
                NUDDMSDegrees.Enabled = false;
                NUDDMSDegrees.Value = (decimal)Math.Floor(Math.Abs(longitudeVal ));
                NUDDMSMinutes.Enabled = false;
                NUDDMSMinutes.Value = (decimal)Math.Floor(60 * (Math.Abs(longitudeVal) % 1));
                NUDDMSSeconds.Enabled = false;
                NUDDMSSeconds.Value = (decimal)Math.Round((((60 * Math.Abs(longitudeVal)) % 1) * 60), 1);
                NUDRadians.Enabled = false;
                NUDRadians.Value= (decimal) Math.Round((Math.PI* Math.Abs(longitudeVal))/180, 4);
                if (value < 0)
                {
                    radioW.Checked = true;
                    radioE.Checked = false;
                }
                else
                {
                    radioE.Checked = true;
                    radioW.Checked = false;
                }
            }
        }
 
        private void radioDD_Click(object sender, EventArgs e)
        {
            NUDDegrees.Enabled = true;
            NUDDMSDegrees.Enabled = false;
            NUDDMSMinutes.Enabled = false;
            NUDDMSSeconds.Enabled = false;
            NUDRadians.Enabled = false;
        }

        private void radioDMS_Click(object sender, EventArgs e)
        {
            NUDDegrees.Enabled = false;
            NUDDMSDegrees.Enabled = true;
            NUDDMSMinutes.Enabled = true;
            NUDDMSSeconds.Enabled = true;
            NUDRadians.Enabled = false;
        }

        private void radioRadians_Click(object sender, EventArgs e)
        {
            NUDDegrees.Enabled = false;
            NUDDMSDegrees.Enabled = false;
            NUDDMSMinutes.Enabled = false;
            NUDDMSSeconds.Enabled = false;
            NUDRadians.Enabled = true;
        }

        private double longitudeVal = 0.0;

        private void NUDDegrees_ValueChanged(object sender, EventArgs e)
        {
            if (radioDD.Checked)
            {
                longitudeVal = (double)NUDDegrees.Value * (radioW.Checked ? -1 : 1);
                NUDDMSDegrees.Value = (decimal)Math.Floor(Math.Abs(longitudeVal));
                NUDDMSMinutes.Value = (decimal)Math.Floor(60 * (Math.Abs(longitudeVal) % 1));
                NUDDMSSeconds.Value = (decimal)(((60 * Math.Abs(longitudeVal)) % 1) * 60);
                NUDRadians.Value = (decimal)(Math.PI * Math.Abs(longitudeVal)) / 180;
            }
        }

        private void radioE_CheckedChanged(object sender, EventArgs e)
        {
            longitudeVal = Math.Abs(longitudeVal) * (radioW.Checked ? -1 : 1);
        }

        private void radioW_CheckedChanged(object sender, EventArgs e)
        {
            longitudeVal = Math.Abs(longitudeVal) * (radioW.Checked ? -1 : 1);
        }

        private void NUDDMSDegrees_ValueChanged(object sender, EventArgs e)
        {
            if (radioDMS.Checked)
            {
                longitudeVal = ((double)NUDDMSDegrees.Value + ((double)NUDDMSMinutes.Value) / 59.99999 + (double)NUDDMSSeconds.Value / 3600) * (radioW.Checked ? -1 : 1);

                if (Math.Abs(longitudeVal) > 180)
                {
                    longitudeVal = 180 * (radioW.Checked ? -1 : 1);
                    NUDDMSDegrees.Value = (decimal)Math.Floor(Math.Abs(longitudeVal));
                }

                NUDDegrees.Value = (decimal)Math.Abs(longitudeVal);
                NUDDMSMinutes.Value = (decimal)Math.Floor(60 * (Math.Abs(longitudeVal) % 1));
                NUDDMSSeconds.Value = (decimal)(((60 * Math.Abs(longitudeVal)) % 1) * 60);
                NUDRadians.Value = (decimal)(Math.PI * Math.Abs(longitudeVal)) / 180;
            }
        }

        private void NUDDMSMinutes_ValueChanged(object sender, EventArgs e)
        {
            if (radioDMS.Checked)
            {
                longitudeVal = ((double)NUDDMSDegrees.Value + ((double)NUDDMSMinutes.Value) / 59.99999 + (double)NUDDMSSeconds.Value / 3600) * (radioW.Checked ? -1 : 1);
                if (Math.Abs(longitudeVal) > 180)
                {
                    longitudeVal = 180 * (radioW.Checked ? -1 : 1);
                    NUDDMSMinutes.Value = (decimal)Math.Floor(60 * (Math.Abs(longitudeVal) % 1));
                }
                NUDDegrees.Value = (decimal)Math.Abs(longitudeVal);
                NUDDMSDegrees.Value = (decimal)Math.Floor(Math.Abs(longitudeVal));
                NUDDMSSeconds.Value = (decimal)(((60 * Math.Abs(longitudeVal)) % 1) * 60);
                NUDRadians.Value = (decimal)(Math.PI * Math.Abs(longitudeVal)) / 180;
            }
        }

        private void NUDDMSSeconds_ValueChanged(object sender, EventArgs e)
        {
            if (radioDMS.Checked)
            {
                longitudeVal = ((double)NUDDMSDegrees.Value + ((double) NUDDMSMinutes.Value) / 59.99999 + (double)NUDDMSSeconds.Value / 3600) * (radioW.Checked ? -1 : 1);
                if (Math.Abs(longitudeVal) > 180)
                {
                    longitudeVal = 180 * (radioW.Checked ? -1 : 1);
                    NUDDMSSeconds.Value = (decimal)(((60 * Math.Abs(longitudeVal)) % 1) * 60);
                }
                NUDDegrees.Value = (decimal)Math.Abs(longitudeVal);
                NUDDMSDegrees.Value = (decimal)Math.Floor(Math.Abs(longitudeVal));
                NUDDMSMinutes.Value = (decimal)Math.Floor(60 * (Math.Abs(longitudeVal) % 1));
                NUDRadians.Value = (decimal)(Math.PI * Math.Abs(longitudeVal)) / 180;
            }
        }

        private void NUDRadians_ValueChanged(object sender, EventArgs e)
        {
            if (radioRadians.Checked)
            {
                longitudeVal = (double)((double)NUDRadians.Value * 180 / Math.PI) * (radioW.Checked ? -1 : 1);
                if (Math.Abs(longitudeVal) > 180)
                {
                    longitudeVal = 180 * (radioW.Checked ? -1 : 1);
                }
                NUDDegrees.Value = (decimal)Math.Abs(longitudeVal);
                NUDDMSDegrees.Value = (decimal)Math.Floor(Math.Abs(longitudeVal));
                NUDDMSMinutes.Value = (decimal)Math.Floor(60 * (Math.Abs(longitudeVal) % 1));
                NUDDMSSeconds.Value = (decimal)(((60 * Math.Abs(longitudeVal)) % 1) * 60);
            }
        }
    }
}

