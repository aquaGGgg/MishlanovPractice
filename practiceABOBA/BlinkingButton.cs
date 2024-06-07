using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ServiceDeskApp
{
    public class BlinkingButton : Button
    {
        private Timer timer;
        private float shinePosition = 0;
        private bool shiningForward = true;

        public BlinkingButton()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            timer = new Timer();
            timer.Interval = 10; // Частота обновления (мс)
            timer.Tick += Timer_Tick;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            timer.Start();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            timer.Stop();
            shinePosition = 0;
            this.Invalidate(); // Перерисовать кнопку
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (shiningForward)
            {
                shinePosition += 0.05f;
                if (shinePosition >= 1)
                {
                    shinePosition = 1;
                    shiningForward = false;
                }
            }
            else
            {
                shinePosition -= 0.05f;
                if (shinePosition <= 0)
                {
                    shinePosition = 0;
                    shiningForward = true;
                }
            }
            this.Invalidate(); // Перерисовать кнопку
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (shinePosition > 0)
            {
                DrawShine(pevent.Graphics);
            }
        }

        private void DrawShine(Graphics g)
        {
            Rectangle rect = this.ClientRectangle;
            LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(180, Color.White),
                Color.FromArgb(0, Color.White),
                LinearGradientMode.Horizontal);

            g.FillRectangle(brush, rect.X + (rect.Width * shinePosition) - (rect.Width / 2), rect.Y, rect.Width / 2, rect.Height);
        }
    }
}
