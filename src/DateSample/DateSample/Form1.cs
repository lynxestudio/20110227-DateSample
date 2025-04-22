using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Message at {DateTime.Now}");
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Message at {DateTime.Today}");
        }
    }
}
