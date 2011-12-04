using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compas.UC
{
    public partial class NumPad : UserControl
    {
        private decimal memoryValue = 0;
        
        public NumPad()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }


        private void NumericButton_Click(object sender, EventArgs e)
        {           
            decimal test = 0;
            if(Decimal.TryParse(ValueTB.Text + ((Button)sender).Text, out test) == true)
                ValueTB.Text = ValueTB.Text + ((Button)sender).Text;
        }

        private void MinusBt_Click(object sender, EventArgs e)
        {
            memoryValue = Convert.ToDecimal(ValueTB.Text);
            ValueTB.Text = "0";
        }
    }
}
