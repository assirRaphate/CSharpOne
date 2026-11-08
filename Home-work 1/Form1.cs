using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            String name = txtname.Text;
            int studentID = int.Parse(txtstudentId.Text);
            String Department = txtDepartment.Text;
            int semester = int.Parse(txtSemester.Text);
            String output = " " + name + " " + studentID + "\n " + Department + " " + semester;

            lbloutput.Text = output;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentId.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();

            lbloutput.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
