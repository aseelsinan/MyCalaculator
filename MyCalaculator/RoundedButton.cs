using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MyCalaculator
{
    class RoundedButton:Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphicPath = new GraphicsPath();
            graphicPath.AddEllipse(0, 0, ClientSize.Height, ClientSize.Width);
            //this.BackColor =ColorTranslator.FromHtml("#007acc");
            //this.ForeColor = ColorTranslator.FromHtml("#007acc");
            this.Region =new System.Drawing.Region(graphicPath);

            base.OnPaint(pevent);
        }
    }
}
