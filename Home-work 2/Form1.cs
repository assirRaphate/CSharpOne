using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_work2
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

        private void btnshow_Click(object sender, EventArgs e)
        {
            String day_of_the_week = txtdayofweek.Text;
            String name_of_the_month = txtmonth.Text;
            int numeric_day = int.Parse(txtnumeric.Text);
            int Year = int.Parse(txtyear.Text);

            String Full_date = day_of_the_week + ", " + name_of_the_month + " " + numeric_day + ", " + Year;

            lbloutput.Text = Full_date;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdayofweek.Clear();
            txtmonth.Clear();
            txtnumeric.Clear();
            txtyear.Clear();
            lbloutput.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
