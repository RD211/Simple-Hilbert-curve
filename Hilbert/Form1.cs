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

namespace Hilbert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static PointF RotatePoint(PointF pointToRotate, PointF centerPoint, double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * (Math.PI / 180);
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);
            return new Point
            {
                X =
                    (int)
                    (cosTheta * (pointToRotate.X - centerPoint.X) -
                    sinTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.X),
                Y =
                    (int)
                    (sinTheta * (pointToRotate.X - centerPoint.X) +
                    cosTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.Y)
            };
        }
        public List<PointF> GenerateHilbert(int order, float width, float height, float xOff, float yOff)
        {
            if (order == 1)
            {
                return new List<PointF>() { new PointF(xOff + 0 + width/4, yOff + 0 + width/4), new PointF(xOff + 0 + width/4, yOff + height - height/4), new PointF(xOff + width - width/4, yOff + height - height/4), new PointF(xOff + width - width/4, yOff + 0 + height/4) };
            }
            else
            {
                var leftUp = GenerateHilbert(order - 1, width / 2, height / 2, xOff, yOff);
                for(int i =0;i<leftUp.Count;i++)
                {
                    leftUp[i] = RotatePoint(leftUp[i], new PointF(xOff + (float)width / 4, yOff + (float)height / 4), -90);
                }
                leftUp.Reverse();
                var rightUp = GenerateHilbert(order - 1, width / 2, height / 2, xOff + width / 2, yOff);
                for (int i = 0; i < rightUp.Count; i++)
                {
                    rightUp[i] = RotatePoint(rightUp[i], new PointF(xOff + (width / 4)*3, yOff + height / 4), 90);
                }
                rightUp.Reverse();
                var leftDown = GenerateHilbert(order - 1, width / 2, height / 2, xOff, yOff + height / 2);
                var rightDown = GenerateHilbert(order - 1, width / 2, height / 2, xOff + width / 2, yOff + height / 2);
                List<PointF> r = new List<PointF>();
                
                return r.Concat(leftUp).Concat(leftDown).Concat(rightDown).Concat(rightUp).ToList();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_generate_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(1023, 1023);
            Graphics g = Graphics.FromImage(bmp);
            Pen pn = new Pen(Color.BlueViolet, 2f);
            g.DrawLines(pn, GenerateHilbert((int)num_order.Value, bmp.Width, bmp.Height, 0, 0).ToArray());
            this.pbox_view.Image = bmp;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Width = this.Height;
        }
    }
}
