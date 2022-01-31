using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMouseX.Text = "Fuat";
            lblMouseY.Text = string.Empty;
        }
        int callCount = 0;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lblMouseX.Text = e.X.ToString();
            lblMouseY.Text = e.Y.ToString();
            callCount++;
            label1.Text = callCount.ToString();
        }
    }
}
