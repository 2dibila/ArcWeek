using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicRedactor
{
    public partial class GraphRed : Form
    {
        Graphics g;
        bool isPresed = false;
        Color currentColor = Color.Black;
        Point point;
        Point PreviousPoint;
        bool textWriting = false;
        int penWidth = 1;

        public GraphRed()
        {
            InitializeComponent();
            var bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            g = Graphics.FromImage(bitmap);
            panel1.AutoScroll = true;
            g.Clear(Color.White);
            var font = new Font("Times New Roman", 20);

            var textBox1 = new TextBox { Parent = pictureBox1, BackColor = SystemColors.Control, Size = new Size(200, 200), Font = font, Location = new Point(60, 60) };
            pictureBox1.MouseDown += (o, e) =>
            {
                textBox1.Visible = !textBox1.Visible;
            };

            pictureBox1.Paint += (o, e) =>
            {
                TextRenderer.DrawText(e.Graphics, textBox1.Text, textBox1.Font, textBox1.Location, textBox1.ForeColor);
                //e.Graphics.DrawString(textBox.Text, textBox.Font, new SolidBrush(textBox.ForeColor), textBox.Location);
            };
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf"; ;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog1.FileName);
                int width = image.Width;
                int height = image.Height;
                pictureBox1.Width = width;
                pictureBox1.Height = height;
                var bitmap = new Bitmap(Image.FromFile(openFileDialog1.FileName), width, height);
                pictureBox1.Image = bitmap;
            }    
            else return;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter =
                "Bitmap File(*.bmp)|*.bmp|" +
                "GIF File(*.gif)|*.gif|" +
                "JPEG File(*.jpg)|*.jpg|" +
                "TIF File(*.tif)|*.tif|" +
                "PNG File(*.png)|*.png";
            savedialog.ShowHelp = true;

            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = savedialog.FileName;
                string strFilExtn =
                    fileName.Remove(0, fileName.Length - 3);
                switch (strFilExtn)
                {
                    case "bmp":
                        pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
          isPresed = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            PreviousPoint = point;
            point = e.Location;

            Pen Pen = new Pen(currentColor, penWidth);

            // Рисовать так: 
            Graphics g = Graphics.FromImage(pictureBox1.Image);

            if (isPresed)
            {
                g.DrawLine(Pen, PreviousPoint, point);

                Pen.Dispose();
                g.Dispose();

                pictureBox1.Invalidate();
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isPresed = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void изменитьРазмерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            //g.Clear(Color.White);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.DrawString(textBox1.Text, new Font("Cambria", 48), Brushes.Black, new PointF(0, 0));
        }

        private void выборЦветаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
            }
        }

        private void размерToolStripMenuItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number<=47 || number>=58) && number!=8 && number!=44)
            {
                e.Handled = true;
            }
        }

        private void размерToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                penWidth = Convert.ToInt32(размерToolStripMenuItem.Text);
            }
            catch
            {
                penWidth = 1;
            }
        }
    }
}
