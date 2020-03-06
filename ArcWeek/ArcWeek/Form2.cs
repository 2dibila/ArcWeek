﻿using System;
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
            }
        }
    }
}
