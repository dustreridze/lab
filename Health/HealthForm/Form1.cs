using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Health;

namespace HealthForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            decimal weight = Convert.ToDecimal(txtWeight.Text);
            decimal height = Convert.ToDecimal(txtHeight.Text);

            decimal bmi = BMI.CalculateBMI(weight, height);

            string classification = BMI.ClassificationBMI(bmi);

            lblBMI.Text = "ИМТ: " + bmi.ToString("F2");
            lblClassification.Text = classification;

            lblBMI.Visible = true;
            lblClassification.Visible = true;
        }
    }
}
