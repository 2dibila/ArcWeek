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
    public partial class formGame : Form
    {
        public formGame()
        {
            InitializeComponent();
        }

        public byte dayNumber = 0;
        public int eventNumber = 0;

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
            //string loadedData = new string[]
            if (File.Exists(fileName))
            {
                File.Create(fileName).Close();
                //loadedData=File.ReadAllLines(fileName);
            }
            else
            {
               
            }
        }

        private void formGame_Load(object sender, EventArgs e)
        {
            lblDay.Text = "День "+dayNumber;
            lblDay.Visible = true;
            dayNumber = 1;
            eventNumber = 1;
        }

        private void tbEventField_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
    }
}
