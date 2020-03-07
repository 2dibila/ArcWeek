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
        Point lastPointGame;
        static Random rand = new Random();

        public byte dayNumber = 0;
        public int eventNumber = 0;
        public static string[] storyTheme = new string[] 
        { "Инфекция", "Война", "Нашествие", "Коллапс ДНК", "Наводнение", "Искуственный интеллект" };
        string[][] story = new string[storyTheme.Length][];

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
            formMain MainForm = Owner as formMain;
        }

        int storyNumber = rand.Next(0, 5);

        public string currentQuestion;
        public string currentDay;

        public string[] loadedData = new string[100];

        public void stories()
        {
            //0 - Infection
            //1 - War
            //2 - Alien
            //3 - DNACollapse
            //4 - Flood
            //5 - AIAttack
            story[0] = new string[35];
            story[1] = new string[35];
            story[2] = new string[35];
            story[3] = new string[35];
            story[4] = new string[35];
            story[5] = new string[35];
            story[0][0] =
                "В мире появилась неизвестная инфекция. Что вы сделаете в 1 очередь?";
            story[1][0] =
                "Мир накануне войны. Что вы сделаете в 1 очередь?";
            story[2][0] =
                "Мир был атакован инопланетянами. Что вы сделаете в 1 очередь?";
            story[3][0] =
                "У нового поколения человека обнаружены необратимые изменения в ДНК. Что вы сделаете чтобы спасти человечество?";
            story[4][0] =
                "Скоро мир будет затоплен. Что вы сделаете в 1 очередь?";
            story[5][0] =
                "Исскуственный интеллект начал появляться повсюду, люди считают, что они планируют атаковать человечество. Что вы сделаете в 1 очередь?";
        }

        protected void storyGenerate()
        {
            stories();
            currentQuestion = story[storyNumber][0];
            lblEventField.Text = currentQuestion;
            firstAnswerGenerate();
        }

        protected void firstAnswerGenerate()
        {
            dayNumber = 1;

            switch (storyNumber)
            {
                case 0:
                    btnChoice1.Text = "Сделаю всё возможное";
                    btnChoice2.Text = "Постараюсь выжить";
                    btnChoice3.Text = "Ничего..";
                    btnChoice4.Text = "Воспользуюсь положением";
                    break;
                case 1:
                    btnChoice1.Text = "Беречь семью";
                    btnChoice2.Text = "Пойду на фронт";
                    btnChoice3.Text = "Спрячусь, страшно";
                    btnChoice4.Text = "Перейду на сторону врага";
                    break;
                case 2:
                    btnChoice1.Text = "Стану героем";
                    btnChoice2.Text = "Исследовать их оружие";
                    btnChoice3.Text = "Позабочусь о себе";
                    btnChoice4.Text = "Сдамся";
                    break;
                case 3:
                    btnChoice1.Text = "ПОКА ХЗ";
                    btnChoice2.Text = "ПОКА ХЗ";
                    btnChoice3.Text = "ПОКА ХЗ";
                    btnChoice4.Text = "ПОКА ХЗ";
                    break;
                case 4:
                    btnChoice1.Text = "Построю корабль";
                    btnChoice2.Text = "Пойду в горы";
                    btnChoice3.Text = "Найду подводный мир";
                    btnChoice4.Text = "Смирюсь";
                    break;
                case 5:
                    btnChoice1.Text = "Ничего, считаю, что все хорошо";
                    btnChoice2.Text = "Выброшу всю технику";
                    btnChoice3.Text = "Выключу всех роботов";
                    btnChoice4.Text = "Напишу вирус";
                    break;
            }
        }


        public void saveFunction(string fileName)
        {
            string[] savedData = new string[100];

            savedData[0] = "День " + dayNumber.ToString();
            savedData[1] = "Текущая история - " + storyTheme[storyNumber];
            savedData[2] = currentQuestion;

            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
                File.WriteAllLines(fileName, savedData);
            }
            else
            {
                File.Delete(fileName);
                File.Create(fileName).Close();
                File.WriteAllLines(fileName, savedData);
            }
        }

        

        public void loadFunction(string fileName)
        {
            stories();

            if (File.Exists(fileName))
            {
                loadedData = File.ReadAllLines(fileName);
                MessageBox.Show(loadedData[1],loadedData[0]);
            }
            currentDay = loadedData[0];
            currentQuestion = loadedData[2];

            lblDay.Text = currentDay;
            lblEventField.Text = currentQuestion;

            if ((currentQuestion == story[0][0]) ||
                (currentQuestion == story[1][0]) ||
                (currentQuestion == story[2][0]) ||
                (currentQuestion == story[3][0]) ||
                (currentQuestion == story[4][0]) ||
                (currentQuestion == story[5][0]))
            {
                firstAnswerGenerate();
            }
        }

        private void formGame_Load(object sender, EventArgs e)
        {
        }

        private void btnReturnToMain_Click(object sender, EventArgs e)
        {
            formMain Main = new formMain();
            formGame Game = this;
            Main.Owner = this;
            Game.Hide();
            Main.ShowDialog();
            Game.Dispose();
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

        

        private void formGame_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPointGame.X;
                this.Top += e.Y - lastPointGame.Y;
            }
        }

        private void formGame_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointGame = new Point(e.X, e.Y);
        }
    }
}
