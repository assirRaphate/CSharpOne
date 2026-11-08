using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_PROGRAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //Variable
            double Weight;
            double Height;
            double Calculate;
            //tryparse
            if (double.TryParse(txtweight.Text, out Weight) & double.TryParse(txtheight.Text, out Height))
         
            {
                Weight = double.Parse(txtweight.Text);
                Height = double.Parse(txtheight.Text);
                Calculate = Weight * 703 / (Height * Height);
                double result = Calculate;
                //condition
                if (Weight < 18.5)
                {
                    listBox1.Items.Add("Under Weight");
                    listBox1.Items.Add(result + "KG");
                }
                else if (Weight >= 18.5 && Weight <= 25)
                {

                    listBox1.Items.Add("Optimal Weight");
                    listBox1.Items.Add(result + "KG");
                }
                else if (Weight > 25)
                {
                    listBox1.Items.Add("over Weight");
                    listBox1.Items.Add(result + "KG");
                }
                else
                {
                    MessageBox.Show("soo gali weight");
                }
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            //clear
            txtweight.Clear();
            txtheight.Clear();
            listBox1.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
