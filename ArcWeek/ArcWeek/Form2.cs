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
using System.Threading;

namespace ArcWeek
{
    public partial class formGame : Form
    {
        public formGame()
        {
            InitializeComponent();
            btnChoice1.Visible = false;
            btnChoice2.Visible = false;
            btnChoice3.Visible = false;
            btnChoice4.Visible = false;
            lblDay.Visible = false;
            btnReturnToMain.Visible = false;
            lblEventField.Focus();
        }          

        public byte dayNumber = 0;
        public int eventNumber = 0;

        protected void storyGenerate()
        {
            string[] storyTheme = new string[] { "Infection", "War", "Alien", "DNACollapse", "Flood", " AIAttack" };
            string[][] story = new string[storyTheme.Length][];
            //0 - Infection
            //1 - War
            //2 - Alien
            //3 - DNKCollapse
            //4 - Flood
            //5 - AIAttack
            story[0] = new string[35];
            story[1] = new string[35];
            story[2] = new string[35];
            story[3] = new string[35];
            story[4] = new string[35];
            story[5] = new string[35];
            story[0][0] = "В мире появилась неизвестная инфекция. Что вы сделаете в 1 очередь?";
            story[1][0] = "Мир накануне войны. Что вы сделаете в 1 очередь?";
            story[2][0] = "Мир был атакован инопланетянами. Что вы сделаете в 1 очередь?";
            story[3][0] = "У нового поколения человека обнаружены необратимые изменения в ДНК. Что вы сделаете чтобы спасти человечество?";
            story[4][0] = "Скоро мир будет затоплен. Что вы сделаете в 1 очередь?";
            story[5][0] = "Исскуственный интеллект восстал против создателей. Что вы сделаете в 1 очередь?";
        }

        public void saveFunction(string fileName)
        {
            string[] savedData =new string[2];
            savedData[0] = "Текущий день - " + dayNumber.ToString();
            savedData[1] = "Текущее событие - " + eventNumber.ToString();
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
                File.WriteAllLines(fileName, savedData);
            } else
            {
                File.Delete(fileName);
                File.Create(fileName).Close();
                File.WriteAllLines(fileName, savedData);
            }
        }
        public void loadFunction(string fileName)
        {
            string[] loadedData = new string[100];
            if (File.Exists(fileName))
            {
                loadedData = File.ReadAllLines(fileName);
                MessageBox.Show(loadedData[1]);
            }
        }

        private void formGame_Load(object sender, EventArgs e)
        {
            dayNumber = 1;
            eventNumber = 1;
            lblDay.Text = "День " + dayNumber;
        }

        private void btnReturnToMain_Click(object sender, EventArgs e)
        {
            formMain Main = new formMain();
            Main.Visible = true;
            formGame Game = this;
            Game.Close();
        }

        private void cmsSaveItem_Click(object sender, EventArgs e)
        {
            formMain Main = new formMain();
            if (Main.saveFile.ShowDialog() == DialogResult.OK)
            {
                saveFunction(Main.saveFile.FileName);
            }
            else return;
        }

        private void cmsLoadItem_Click(object sender, EventArgs e)
        {
            formMain Main = new formMain();
            if (Main.loadFile.ShowDialog() == DialogResult.OK)
            {
                loadFunction(Main.loadFile.FileName);
            }
            else return;
        }

        private void formGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                btnChoice1.Visible = true;
                btnChoice2.Visible = true;
                btnChoice3.Visible = true;
                btnChoice4.Visible = true;
                lblDay.Visible = true;
                btnReturnToMain.Visible = true;
                storyGenerate();
                timer1.Stop();
                lblPressSpace.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblPressSpace.Visible = false;
            Thread.Sleep(500);
            lblPressSpace.Visible = true;
        }
    }
}
