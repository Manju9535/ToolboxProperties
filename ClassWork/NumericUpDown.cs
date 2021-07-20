using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork
{
    public partial class NumericUpDown : Form
    {
        public NumericUpDown()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value >= 65)
            {
                MessageBox.Show("Age is: " + numericUpDown1.Value.ToString());
            }
            else
            {
                MessageBox.Show("The customer is ineligible for a senior citizen discount.");
            }
        }
    }
}
