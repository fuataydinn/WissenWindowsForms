using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ternary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string militaryStatus;
            militaryStatus = rbtFemale.Checked
                ? "Muaf"
                : chkMilitaryServiceStatus.Checked
                    ? txtMilitaryServiceLocation.Text
                    : "Yapılmadı";

            MessageBox.Show(militaryStatus);

            //if (rbtFemale.Checked)
            //{
            //    militaryStatus = "Muaf";

            //}
            //else
            //{
            //    if (chkMilitaryServiceStatus.Checked)
            //    {
            //        militaryStatus = txtMilitaryServiceLocation.Text;
            //    }
            //    else
            //    {
            //        militaryStatus = "Yapılmadı";
            //    }
               
            //}
        }
    }
}
