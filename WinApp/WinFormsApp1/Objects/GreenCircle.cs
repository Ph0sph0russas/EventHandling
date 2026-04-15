using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Objects
{
    class GreenCircle : BaseObject
    {
        int lifeTimer = 70;
        public Action<GreenCircle> OnCircleLapOutOfTimer;
        public GreenCircle(float x, float y, float angle) : base(x, y, angle)
        {
        }

        public override void Render(Graphics g)
        {

            g.DrawEllipse(new Pen(Color.White),10, 10, 50, 50);
            g.FillEllipse(new SolidBrush(Color.Lime),10,10,50,50);
            g.DrawString(
            lifeTimer.ToString(),
            new Font("Verdana", 8), 
            new SolidBrush(Color.Green), 
            10, 10 
            );
            if (lifeTimer>0)
            {
                lifeTimer--;
            }
            else
            {
                if (OnCircleLapOutOfTimer!=null)
                {
                    OnCircleLapOutOfTimer(this);
                }
            }

        }
        public override GraphicsPath GetGraphicsPath()
        {
            var path = base.GetGraphicsPath();
            path.AddEllipse(10,10,50,50);
            return path;
        }
    }
}
