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

namespace Week09
{
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        Bitmap bmp = new Bitmap("D:\\59030194.jpg");
        this.SetClientSizeCore(bmp.Width + 20, bmp.Height + 20);
        g.DrawImage(bmp, 10, 10);
        g.Dispose();
    }
    
}
