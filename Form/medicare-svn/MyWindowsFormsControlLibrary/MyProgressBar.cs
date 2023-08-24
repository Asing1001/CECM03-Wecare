using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormsControlLibrary
{
    public class MyProgressBar : ProgressBar
    {
        public MyProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {            
            Rectangle rec = e.ClipRectangle;
            SolidBrush brush1= new SolidBrush(Color.FromArgb(103, 24, 138));
            
            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height - 4;
            e.Graphics.FillRectangle(brush1, 2, 2, rec.Width, rec.Height);
        }
    }
}
