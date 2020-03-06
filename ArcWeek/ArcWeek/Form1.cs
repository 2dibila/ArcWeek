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

        public void saveFunction(string fileName)
        {
            formGame Game = new formGame();
            Game.Owner = this;
            string[,] Data = new string[2, 2];
            Data[0, 0] = "Текущий день";
            Data[0, 1] = Game.dayNumber.ToString();
            Data[1, 0] = "Текущее событие";
            Data[1, 1] = Game.eventNumber.ToString();
            if (File.Exists(fileName))
            {
                File.Create(fileName);
                for (int i=0;i<=Data.Length;i++)
                {
                    File.WriteAllText(fileName, Data[i, 0] + " - " + Data[i, 1]);
                }
            }
        }
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
            Game.Show();
            formMain Main = this;
            Main.Hide();
            pbLogo.Image.Dispose();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            btnStartGame_Click(sender, e);
        }
    }
}
