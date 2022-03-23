using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sd = new SaveFileDialog();
                sd.DefaultExt = ".txt";
                
                DialogResult res =  sd.ShowDialog();
                if (res == DialogResult.OK) // save in the diolog box is = ok in code
                {
                    StreamWriter sw = new StreamWriter(sd.FileName);
                    sw.WriteLine(rtbox1.Text);
                    sw.Close();
                    MessageBox.Show("ok done");
                }
            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {


                OpenFileDialog od = new OpenFileDialog();
                od.Filter = "Text File|*.txt|All file|*.*";
                DialogResult res1 = od.ShowDialog();
                if (res1 == DialogResult.OK) // save in the diolog box is = ok in code
                {
                    StreamReader sr = new StreamReader(od.FileName);
                    rtbox1.Text = sr.ReadToEnd();
                    sr.Close();
                    MessageBox.Show("ok done");
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
