using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace RintegerImageProcessingBA.CompressFile
{
    public class CompressMgr
    {
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
