using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RintegerImageProcessing
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

        private void CompressFile_Click(object sender, EventArgs e)
        {
            //this.Close();
            CompressForm compressForm = new CompressForm();
            compressForm.Show();
        }

        private void RenameFile_Click(object sender, EventArgs e)
        {
            //this.Close();
            RenameForm renameForm = new RenameForm();
            renameForm.Show();
        }
    }
}
