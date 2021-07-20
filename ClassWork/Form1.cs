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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {


            // Set the BoldedDates property to a DateTime array.
            // ... Use array initializer syntax to add tomorrow and two days after.
            monthCalendar1.BoldedDates = new DateTime[]
           {
                DateTime.Today.AddDays(1),
                DateTime.Today.AddDays(2),
                DateTime.Today.AddDays(4)
           };

            // You can acquire the range using this property accessor.
            SelectionRange range = monthCalendar1.SelectionRange;
            DateTime start = range.Start;
            DateTime end = range.End;

            // The user changed the current selection.
            MessageBox.Show("DateChanged: " + monthCalendar1.SelectionRange.ToString());

        }
    }
}
