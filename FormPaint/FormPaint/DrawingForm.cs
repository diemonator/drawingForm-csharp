using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPaint
{
    public partial class DrawingForm : Form
    {
        private List<Point> points;

        public DrawingForm()
        {
            InitializeComponent();
            points = new List<Point>();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            gr.Clear(SystemColors.Control);
            points.Clear();
        }

        private void DrawingForm_Paint(object sender, PaintEventArgs e)
        {
            float formX = ClientRectangle.Width - AutoScaleDimensions.Width;
            float formY = ClientRectangle.Height - AutoScaleFactor.Height;
            Graphics gr = e.Graphics;
            DrawEllipses(gr, formX, formY, 75);
            DrawLines(gr, formX, formY);
            DrawDots(gr, 10);
        }

        private void DrawingForm_MouseClick(object sender, MouseEventArgs e)
        {
            cordinatesLb.Text = string.Format("Cordinates: {0}:{1}", e.X, e.Y);
            points.Add(e.Location);
            Refresh();
        }

        private void DrawingForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void DrawEllipses(Graphics gr, float formX, float formY, int r)
        {
            float circleX = formX - r;
            float circleY = formY - r;
            gr.DrawEllipse(Pens.Blue, 0, 0, r, r);
            gr.DrawEllipse(Pens.Red, circleX, 0, r, r);
            gr.DrawEllipse(Pens.Purple, 0, circleY, r, r);
            gr.DrawEllipse(Pens.Green, circleX, circleY, r, r);
            gr.DrawEllipse(Pens.Aqua, circleX / 2, circleY / 2, r, r);
        }

        private void DrawLines(Graphics gr, float formX, float formY)
        {
            gr.DrawLine(Pens.Black, 0, 0, formX, formY);
            gr.DrawLine(Pens.Black, 0, formY, formX, 0);
        }

        private void DrawDots(Graphics gr, int r)
        {
            int radiusCenter = r / 2;
            if (points.Count > 1)
            {
                foreach (Point item in points)
                    gr.FillEllipse(Brushes.Black, item.X - radiusCenter, item.Y - radiusCenter, r, r);
                gr.DrawLines(Pens.Black, points.ToArray());
            }
            else if (points.Count == 1) gr.FillEllipse(Brushes.Black, points.Last().X - radiusCenter, points.Last().Y - radiusCenter, r, r);
        }
    }
}
