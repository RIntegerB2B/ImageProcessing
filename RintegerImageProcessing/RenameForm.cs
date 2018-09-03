using RintegerImageProcessingBA.RenameFile;
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
    public partial class RenameForm : Form
    {
        public RenameForm()
        {
            InitializeComponent();
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            string path = FolderPath.Text;
            string preffix = Preffix.Text;
            string suffix = Suffix.Text;
            RenameMgr renameMgr = new RenameMgr();
            renameMgr.DirSearch(path, preffix, suffix);

        }
    }
}
