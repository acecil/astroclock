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

namespace AstroClock
{
    public partial class SetLocationForm : Form
    {
        public SetLocationForm()
        {
            InitializeComponent();
        }

        public String Location
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
                return decompose(longitudetext.Text);
            }
            set
            {
                longitudetext.Text = value.ToString();
            }
        }
        private double decompose(string ltext)

        {
            bool numeric = true; 
            ltext = ltext.Trim();
            foreach (char i in ltext)
            {
                if (!(i >= '0' && i <= '9' || i == '+' || i == '-' || i == '.' || i == ','))
                { numeric = false;
                break;
                }
            }
            if (numeric)
            {
                return Double.Parse(ltext);
            }
            else
            {
                int d = 0; int m = 0; int s = 0; double vv;
                d = ltext.IndexOf('d');
                vv= Double.Parse(ltext.Substring(0,d));
                if(vv <0) numeric=true;
                m = ltext.IndexOf('m');
                vv += (numeric ? -1 : 1) * Double.Parse(ltext.Substring(d + 1, m-d-1))/60;
                s = ltext.IndexOf('s');
                vv += (numeric ? -1 : 1) * Double.Parse(ltext.Substring(m + 1, s-m-1))/3600;
                return vv;
            }
        }
    }
}

