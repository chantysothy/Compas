using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compas.AdminUI
{
    public partial class ScanerTest : Form
    {
        string s;
        public ScanerTest()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            s = s + ";" + e.KeyCode.ToString() + "-" + e.KeyData.ToString();
            label1.Text = s;
            e.Handled = true;
        }

        private void ClearBt_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            s = "";
        }
    }
}
