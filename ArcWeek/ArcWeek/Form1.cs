using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArcWeek
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        public int xpos, ypos;
        public Point lastPointMain;

        private void btnExit_Click(object sender, EventArgs e)
        {
            string[] exitHeader = { "Ты же вернешься снова?", "Шалом", "Ты нашел секретный выход!"};
            string[] exitText = { "Вы точно хотите покинуть приключеньице?" ,"Вы пытаетесь все бросить?"};
            Random rndText = new Random();
            Random rndHeader = new Random();
            string Text = exitText[rndText.Next(0, exitText.Length)]; 
            string Header = exitHeader[rndHeader.Next(0, exitHeader.Length)];
            DialogResult result = MessageBox.Show("Вы точно хотите покинуть приключеньице?", Header, MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else return;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            formGame Game = new formGame();
            formMain Main = this;
            Game.Owner = this;
            Main.Hide();
            Game.ShowDialog();
            Main.Dispose();
            pbProgress.Image.Dispose();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            btnStartGame_Click(sender, e);
        }

        private void formMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPointMain.X;
                this.Top += e.Y - lastPointMain.Y;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            formGame Game = new formGame();
            Game.saveFunction();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            formGame Game = new formGame();Game.loadFunction();
                Game.btnChoice1.Visible = true;
                Game.btnChoice2.Visible = true;
                Game.btnChoice3.Visible = true;
                Game.btnChoice4.Visible = true;
                Game.lblDay.Visible = true;
                Game.btnReturnToMain.Visible = true;
                Game.timer1.Stop();
                Game.lblPressSpace.Visible = false;
                formMain Main = this;
                Game.Owner = this;
                Main.Hide();
                Game.ShowDialog();
                Main.Dispose();
                pbProgress.Image.Dispose();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
        }

        private void formMain_Shown(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer("music.wav").PlayLooping();
        }

        private void formMain_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointMain = new Point(e.X, e.Y);
        }
    }
}
