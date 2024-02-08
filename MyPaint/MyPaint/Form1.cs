using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        Color C = Color.FromName("Red");       
        Boolean draw = false;
        int mode = 0;
        int x = 0;
        int y = 0;
        int s = 10; //PEN SIZE
        public Form1()
        {
            InitializeComponent();
            blankCanvas(600,400);
            sizeTB.Text = s.ToString();

        }

        private void newCanvas_Click(object sender, EventArgs e)
        {
            Form2 dp = new Form2();
            dp.ShowDialog();
            int w = dp.getWidth();
            int h = dp.getHeight();
            blankCanvas(w,h);
            pickColor.BackColor = C;
        }

        private void blankCanvas(int w, int h)
        {
            Color clr =  Color.FromName("White");
            Bitmap bmp = new Bitmap(w, h);
            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                    bmp.SetPixel(i,j, clr);
            canvas.Image = bmp;
        }

        private void pickColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            C = colorDialog1.Color;
            pickColor.BackColor = C;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            x = e.X;
            y = e.Y;
            if (mode == 4) //COLOR FROM SCREEN
            {
                Bitmap bmp = canvasExport();
                C = bmp.GetPixel(e.X, e.Y);
                pickColor.BackColor = C;
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {            
            canvas.Image = canvasExport();
            draw = false;
            
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graphics g = canvas.CreateGraphics();
                switch (mode)
                {
                    case 0://BRUSH MDOE
                        g.FillEllipse(new SolidBrush(C), e.X, e.Y, s, s);
                        break;
                    case 1: //EMPTY RECTANGLE
                        canvas.Refresh();
                        g.DrawRectangle(new Pen(C,s), x, y, e.X - x, e.Y - y);
                        break;
                    case 2: //EMPTY ELLIPSE
                        canvas.Refresh();
                        g.DrawEllipse(new Pen(C, s), x, y, e.X - x, e.Y - y);
                        break;
                    case 3: //STRAIGHT LINE
                        canvas.Refresh();
                        g.DrawLine(new Pen(C, s), x, y, e.X, e.Y);
                        break;

                    case 5: //SOLID RECTANGLE
                        canvas.Refresh();
                        g.FillRectangle(new SolidBrush(C), x, y, e.X - x, e.Y - y);
                        break;
                }
                
                g.Dispose();
            }
        }

        private void penMode_Click(object sender, EventArgs e)
        {
            mode = 0;
        }

        private void rectangleMode_Click(object sender, EventArgs e)
        {
            mode = 1;
        }

        private void elipseMode_Click(object sender, EventArgs e)
        {
            mode = 2;
        }

        private void lineMode_Click(object sender, EventArgs e)
        {
            mode = 3;
        }

        private void bucketMode_Click(object sender, EventArgs e)
        {
            mode = 5;
        }

        private void colorPickerMode_Click(object sender, EventArgs e)
        {
            mode = 4;
        }

        private Bitmap canvasExport()
        {
            Bitmap bmp = new Bitmap(canvas.Width, canvas.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle r = canvas.RectangleToScreen(canvas.ClientRectangle);
            g.CopyFromScreen(r.Location, Point.Empty, canvas.Size);
            g.Dispose();
            return bmp;
        }

        private void openImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            canvas.Image=Image.FromFile(openFileDialog1.FileName);

        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            canvas.Image.Save(saveFileDialog1.FileName);
        }

        private void canvas_Click(object sender, EventArgs e)
        {

        }

        private void sizeTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                s = int.Parse(sizeTB.Text);
            }
            catch { }
        }
    }
}/*if (mode == 1)//SOLID RECTANGLE
            {
                Graphics g = canvas.CreateGraphics();
                g.FillRectangle(new SolidBrush(C), x, y, e.X - x, e.Y - y);
                g.Dispose();
            }
            else if (mode == 2) {//SOLID CIRCLE
                Graphics g = canvas.CreateGraphics();
                g.FillEllipse(new SolidBrush(C), x, y, e.X - x, e.Y - y);
                g.Dispose();
            }
            else if (mode == 3)//STRAIGHT LINE
            {
                Graphics g = canvas.CreateGraphics();
                g.DrawLine(new Pen(C, 10), x, y, e.X, e.Y);
                g.Dispose();
            }*/
