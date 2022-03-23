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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnCreatFil_Click(object sender, EventArgs e)
        {
            string path = @"E:\c.netclass\File.IO.Opeartion";
            if (Directory.Exists(path))
            {

                MessageBox.Show("Folder Alraedy exits");
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Created");
            }
        }

        private void BtnCreatFil_Click_1(object sender, EventArgs e)
        {
            string path = @"E:\c.netclass\File.IO.Opeartion\Sample1.txt";
            if (File.Exists(path))
            {
                MessageBox.Show("File Is There");
            }
            else
            {
                File.Create(path);
                MessageBox.Show("File Created");
            }
        }

        private void BtnBinW_Click(object sender, EventArgs e)
        {
            try
            {
                //1 Create file & open in Write Mode & make mak obj of FileStreame Class
                FileStream fs = new FileStream(@"E:\c.netclass\File.IO.Opeartion\Sample2.txt", FileMode.Create, FileAccess.Write);
                //2 Write to File with BinaryWriter Obj
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtDeptID.Text));
                bw.Write(txtName.Text);
                bw.Write(txtLocation.Text);
                //3 Close BinaryWriter & FileStreme
                bw.Close();
                fs.Close();
                MessageBox.Show("Data Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnBinR_Click(object sender, EventArgs e)
        {
            try
            {
                
                FileStream fs = new FileStream(@"E:\c.netclass\File.IO.Opeartion\Sample2.txt", FileMode.Open, FileAccess.Read);
              
                BinaryReader br = new BinaryReader(fs);
                txtDeptID.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtLocation.Text = br.ReadString();
                
                br.Close();
                fs.Close();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
