using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsrNam.Text == "Admin" && txtPass.Text == "Admin")
             MessageBox.Show("Correct"); 
            else
                MessageBox.Show("Fail");
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtUsrNam.Clear();
        }
    }
}
