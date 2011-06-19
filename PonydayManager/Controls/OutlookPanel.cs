using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace PonydayManager.Controls
{
    public class OutlookPanel : Panel
    {
        private static Color HEADER_BACKGROUND_COLOR_1 = Color.FromArgb(122, 150, 223);
        private static Color HEADER_BACKGROUND_COLOR_2 = Color.FromArgb(0, 78, 152);

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if ((this.ClientRectangle.Width > 0) && (this.ClientRectangle.Height > 0))
            {
                using (LinearGradientBrush lnBrush = new LinearGradientBrush(this.ClientRectangle,
                                                                             HEADER_BACKGROUND_COLOR_1,
                                                                             HEADER_BACKGROUND_COLOR_2, 
                                                                             LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(lnBrush, this.ClientRectangle);
                }
            }
        }
    }
}
