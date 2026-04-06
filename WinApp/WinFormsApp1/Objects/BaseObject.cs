using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
namespace WinFormsApp1.Objects
{
    class BaseObject
    {
        public float X;
        public float Y;
        public float Angle;
        public BaseObject(float x, float y, float angle)
        {
            X = x;
            Y = y;
            Angle = angle;
        }
        public Matrix GetTransform()
        {
            var matrix = new Matrix();
            matrix.Translate(X, Y);
            matrix.Rotate(Angle);

            return matrix;
        }
        public virtual void Render(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Yellow), -25, -15, 50, 30);
            g.DrawRectangle(new Pen(Color.Red, 2), -25, -15, 50, 30);
        }
    }
}
