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
        public string endOfGame = "\n\n\nКонец игры.\n\n\n Создатели :\nArcKontyR\nholo";

        public static string[] storyTheme = new string[]

        { "Инфекция", "Война", "Нашествие", "Наводнение", "Искуственный интеллект" };

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

        int storyNumber;

        public string currentQuestion;
        public string currentDay;

        public string[] loadedData = new string[100];

        public void saveFunction()
        {
            string[] savedData = new string[100];

            savedData[0] = "День " + dayNumber.ToString();
            savedData[1] = currentQuestion;
            savedData[2] = storyNumber.ToString();

            if (!File.Exists("data.txt"))
            {
                File.Create("data.txt").Close();
                File.WriteAllLines("data.txt", savedData);
            }
            else
            {
                File.Delete("data.txt");
                File.Create("data.txt").Close();
                File.WriteAllLines("data.txt", savedData);
            }
        }



        public void loadFunction()
        {

            if (File.Exists("data.txt"))
            {
                loadedData = File.ReadAllLines("data.txt");
                MessageBox.Show(loadedData[1], loadedData[0]);
            }
            currentDay = loadedData[0];
            currentQuestion = loadedData[1];

            lblDay.Text = currentDay;
            lblEventField.Text = currentQuestion;
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
            saveFunction();
        }

        private void cmsLoadItem_Click(object sender, EventArgs e)
        {
            loadFunction();
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

        public void ClearButtons()
        {
            btnChoice1.Enabled = false;
            btnChoice2.Enabled = false;
            btnChoice3.Enabled = false;
            btnChoice4.Enabled = false;

            btnChoice1.Text = "";
            btnChoice2.Text = "";
            btnChoice3.Text = "";
            btnChoice4.Text = "";
        }

        public void ButtonVisibleFalse(byte choice)
        {
            switch (choice)
            {
                case 1:
                    btnChoice1.Visible = false;
                    break;

                case 2:
                    btnChoice2.Visible = false;
                    break;
                case 3:
                    btnChoice3.Visible = false;
                    break;
                case 4:
                    btnChoice4.Visible = false;
                    break;
            }
        }

        public void ButtonVisibleTrue(byte choice)
        {
            switch (choice)
            {
                case 1:
                    btnChoice1.Visible = true;
                    break;
                case 2:
                    btnChoice2.Visible = true;
                    break;
                case 3:
                    btnChoice3.Visible = true;
                    break;
                case 4:
                    btnChoice4.Visible = true;
                    break;
            }
        }

        private void btnChoice1_Click(object sender, EventArgs e)
        {

        }
        private void btnChoice2_Click(object sender, EventArgs e)
        {

        }
        private void btnChoice3_Click(object sender, EventArgs e)
        {

        }
        private void btnChoice4_Click(object sender, EventArgs e)
        {

        }
    }
}
