using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Lisazy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }

        private Thread thread;
        
        public bool _flag = false;
        public float x, y, z, q;
        public double t, r, fix, fiy, alfa, beta, omegax, omegay, x0, y0, tm;

        //Control.Invoke(public Graphics g = Graphics.FromHwnd(pictureBox1.Handle));

        private void btnDots_Click(object sender, EventArgs e)
        {
            thread = new Thread(drawByDots);
            thread.Start();
        }

        private void btnLines_Click(object sender, EventArgs e)
        {
            thread = new Thread(drawByLines);
            thread.Start();
        }

        void drawByDots()
        {
            //Graphics g = Graphics.FromHwnd(pbField.Handle);
            Graphics g = pbFieldPrime.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);
            g.Clear(Color.Snow);
            if (!chkFix.Checked)
            {
                alfa = 100;
                beta = 100;
                omegax = 8.99;
                omegay = 1.01;
                fix = 1.01;
                fiy = 9.03;

            }
            else
            {
                double.TryParse(txta.Text, out alfa);
                double.TryParse(txtb.Text, out beta);
                double.TryParse(txtox.Text, out omegax);
                double.TryParse(txtoy.Text, out omegay);
                double.TryParse(txtfx.Text, out fix);
                double.TryParse(txtfy.Text, out fiy);
            }



            // x0 = 350;
            // y0 = 350;

            /* t = 120;

             while (t <= 100 * Math.PI)

                 //x = (float)Math.Round(x0 + 100 * Math.Sin(0.99 * t) - 100 * Math.Cos(3.01 * t));
                 //y = (float)Math.Round(y0 - 100 * Math.Cos(1.01 * t) + 100 * Math.Sin(15.03 * t));
                // x = (float)Math.Round(x0 + alfa * Math.Sin(omegax * t )/*-alfa* Math.Cos(fix* t )*///);
                                                                                                      //y = (float)Math.Round(y0 - beta * Math.Cos(omegay * t )/*+beta* Math.Sin(fiy * t)*/);
                                                                                                      //x = (float)Math.Round(x0 + alfa * Math.Sin(omegax * t+fix)/*-alfa* Math.Cos(fix* t )*/);
                                                                                                      //y = (float)Math.Round(y0 - beta * Math.Sin(omegay * t+fiy)/*+beta* Math.Sin(fiy * t)*/);

            // putpixel(x, y, clpurple);
            //g.DrawRectangle(pen, x, y, 1, 1);
            //      t = t + 0.001 * Math.PI;

            x0 = 250;
            y0 = 250;
            tm = 120;
            for (t = 0; t <= tm; t += Math.PI * 0.001/*/ 360*/)
            {

                // if (_flag) return;

                //x = (Convert.ToSingle(x0 + alfa * Math.Sin(omegax * t + fix)));
                //y = (Convert.ToSingle(y0 + beta * Math.Sin(omegay * t + fiy)));
                //x = (float)Math.Round(x0 + alfa * Math.Sin(omegax * t+fix)-alfa* Math.Cos(omegax * t - fix));
                //y = (float)Math.Round(y0 - beta * Math.Cos(omegay * t+fiy)+beta* Math.Sin(omegay * t - fiy));
                // x = (float)(Math.Round(x0 + 100 * Math.Sin(4.99 * t) - 100 * Math.Cos(13.01 * t)));
                //y = (float)Math.Round(y0 - 100 * Math.Cos(16.01 * t) + 100 * Math.Sin(15.03 * t));
                x = (float)(Math.Round(x0 + alfa * Math.Sin(omegax * t) - 100 * Math.Cos(fix * t)));
                y = (float)Math.Round(y0 - beta * Math.Cos(omegay * t) + 100 * Math.Sin(fiy * t));

                g.DrawRectangle(pen, x, y, 1, 1);

            }
        }

        void drawByLines()
        {
            //float x, y, z, q;
            //double t, r, fix, fiy, alfa, beta, omegax, omegay, x0, y0, tm;
            //Graphics g = Graphics.FromHwnd(pbField.Handle);
            Graphics g = pbFieldSecond.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);
            g.Clear(Color.Snow);

            if (!chkFix.Checked)
            {
                alfa = 100;
                beta = 100;
                omegax = 8.99;
                omegay = 1.01;
                fix = 1.01;
                fiy = 9.03;
            }
            else
            {
                double.TryParse(txta.Text, out alfa);
                double.TryParse(txtb.Text, out beta);
                double.TryParse(txtox.Text, out omegax);
                double.TryParse(txtoy.Text, out omegay);
                double.TryParse(txtfx.Text, out fix);
                double.TryParse(txtfy.Text, out fiy);
            }

            x0 = 250;
            y0 = 250;
            tm = 120;
            for (t = 0; t <= tm; t += Math.PI / 360)
            {
                if (_flag) return;
                // x = (float)(Math.Round(x0 + 100 * Math.Sin(4.99 * t) - 100 * Math.Cos(13.01 * t)));
                //y = (float)Math.Round(y0 - 100 * Math.Cos(13.01 * t) + 100 * Math.Sin(5.03 * t));
                x = (float)(Math.Round(x0 + alfa * Math.Sin(omegax * t) - 100 * Math.Cos(fix * t)));
                y = (float)Math.Round(y0 - beta * Math.Cos(omegay * t) + 100 * Math.Sin(fiy * t));
                var k = new PointF(x, y);
                r = t + Math.PI / 360;

                //z = (float)(Math.Round(x0 + 100 * Math.Sin(4.99 * r) - 100 * Math.Cos(13.01 * r)));
                //q = (float)Math.Round(y0 - 100 * Math.Cos(13.01 * r) + 100 * Math.Sin(5.03 * r));
                z = (float)(Math.Round(x0 + alfa * Math.Sin(omegax * r) - 100 * Math.Cos(fix * r)));
                q = (float)Math.Round(y0 - beta * Math.Cos(omegay * r) + 100 * Math.Sin(fiy * r));
                var o = new PointF(z, q);
                
                g.DrawLine(pen, k, o);
                
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            thread.Abort();
        }
        
         
        private void Lesazy_Load(object sender, EventArgs e)
        {
            txta.Text = "100";
            txtb.Text = "100";
            txtox.Text = "8,99";
            txtoy.Text = "1,01";
            txtfx.Text = "1,01";
            txtfy.Text = "9,03";
        }

        
    } 
}
    

