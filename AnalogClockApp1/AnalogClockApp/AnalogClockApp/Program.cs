using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnalogClockApp
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public MainForm()
        {
            

            // Set up the form
            this.Text = "Analog Clock";
            this.Size = new Size(300, 300);
            this.DoubleBuffered = true;

            // Set up the timer to refresh the clock every second
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Force the form to redraw
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Get the current time
            DateTime now = DateTime.Now;

            // Calculate clock hand angles
            float secondAngle = now.Second * 6; // 6 degrees per second
            float minuteAngle = now.Minute * 6 + now.Second * 0.1f; // 6 degrees per minute + additional for seconds
            float hourAngle = now.Hour * 30 + now.Minute * 0.5f; // 30 degrees per hour + additional for minutes

            // Set up the graphics object
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw clock face
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            int clockRadius = Math.Min(centerX, centerY) - 10;
            g.DrawEllipse(Pens.Black, centerX - clockRadius, centerY - clockRadius, 2 * clockRadius, 2 * clockRadius);

            // Draw clock hands
            DrawHand(g, centerX, centerY, secondAngle, clockRadius, 1);
            DrawHand(g, centerX, centerY, minuteAngle, clockRadius - 20, 3);
            DrawHand(g, centerX, centerY, hourAngle, clockRadius - 40, 6);
        }

        private void DrawHand(Graphics g, int centerX, int centerY, float angle, int length, int thickness)
        {
            float radians = angle * (float)Math.PI / 180;
            float x = centerX + length * (float)Math.Sin(radians);
            float y = centerY - length * (float)Math.Cos(radians);
            g.DrawLine(new Pen(Color.Black, thickness), centerX, centerY, x, y);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}