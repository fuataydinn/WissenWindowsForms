using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (!int.TryParse(input, out int number))
            {
                if (string.IsNullOrEmpty(input))
                {
                    label3.Text = "Bir sayı giriniz!";
                }
                else
                {
                    label3.Text = "Yazdığınız ifade bir sayı değil!";
                }

            }
            else
            {
                label3.Text = "Sayı Uygun";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input01 = textBox1.Text;
            string input02 = textBox2.Text;

            int number01 = int.Parse(input01);
            int number02 = int.Parse(input02);

            int total = number01 + number02;

            MessageBox.Show((total.ToString()));


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmed_Click(object sender, EventArgs e)
        {
            //bool isChecked = chkConfirmed.Checked;
            if (chkConfirmed.Checked)
            {
                MessageBox.Show("İşaretlenmiş");
            }
            else
            {
                MessageBox.Show("İşaretlenmemiş");
            }
        }

        private void btnDisplayCity_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbCity.SelectedItem.ToString());
        }

        private void labelNumber01_Load(object sender, EventArgs e)
        {

            cmbCity.SelectedIndex = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            DateTime birthDate = dtpDateOfBirth.Value;
            MessageBox.Show(birthDate.ToString());
            //dtpDateOfBirth.Value = DateTime.Today.AddDays(-30); // değerini böyle set edebiliriz 7
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnChangeChecked_Click(object sender, EventArgs e)
        {
            //Ternary999/
            chkConfirmed.Checked = chkConfirmed.Checked ? false : true;

            // chkConfirmed.Checked = true;
        }

        private void btnShowNumValue_Click(object sender, EventArgs e)
        {
            decimal value = numUnitInStock.Value;
            MessageBox.Show(value.ToString());
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
