using RintegerImageProcessingBA.CompressFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RintegerImageProcessing
{
    public partial class CompressForm : Form
    {
        public CompressForm()
        {
            InitializeComponent();
        }

        private void Compress_Click(object sender, EventArgs e)
        {
            CompressFile(FilePath.Text,1024,1024);

        }

        public void CompressFile(string file, int width, int height)
        {
            Image imgToResize = Image.FromFile(file);
            Size size = new Size(width, height);
            Bitmap b = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, new Rectangle(0, 0, width, height));

            System.Configuration.AppSettingsReader app = new System.Configuration.AppSettingsReader();

            b.Save(app.GetValue("imagedirectory", "".GetType()).ToString() + "\\" + System.IO.Path.GetFileNameWithoutExtension(file) + "1" + System.IO.Path.GetExtension(file));
        }
    }
}
