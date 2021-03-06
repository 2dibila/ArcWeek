﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphRed main = this.Owner as GraphRed;

            int width, height;

            bool isInt = int.TryParse(textBox1.Text, out width);
            bool isInt1 = int.TryParse(textBox2.Text, out height);

            if (isInt && isInt1)
            {
                Image image = main.pictureBox1.Image;
                int width1 = image.Width;
                int height1 = image.Height;
                main.pictureBox1.Width = width;
                main.pictureBox1.Height = height;
                var bitmap = new Bitmap(main.pictureBox1.Image, width, height);
                main.pictureBox1.Image = bitmap;
                this.Close();
            }

            else
            {
                DialogResult r8 = MessageBox.Show(this, "Вы не ввели данные, хотите оставить всё как есть?",
                                   "Подтверждение", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button1, 0);
                if(r8 == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            

        }
    }
}
