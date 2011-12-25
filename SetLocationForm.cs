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
                return (double)longitudeVal.Value;
            }
            set
            {
                longitudeVal.Value = (Decimal)value;
            }
        }
    }
}
