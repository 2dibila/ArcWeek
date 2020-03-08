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

        public void stories()
        {
            //0 - Infection
            //1 - War
            //2 - Alien
            //3 - DNACollapse
            //4 - Flood
            //5 - AIAttack
            story[0] = new string[100];
            story[1] = new string[100];
            story[2] = new string[100];
            story[3] = new string[100];
            story[4] = new string[100];
            story[0][0] =
                "В мире появилась неизвестная инфекция. Вы работаете врачом. Что вы сделаете в 1 очередь?";
            story[1][0] =
                "Мир накануне войны. Что вы сделаете в 1 очередь?";
            story[2][0] =
                "Мир был атакован инопланетянами. Вы обычный чел. Что вы сделаете в 1 очередь?";
            story[3][0] =
                "Скоро мир будет затоплен. Что вы сделаете в 1 очередь?";
            story[4][0] =
                "Исскуственный интеллект начал появляться повсюду, люди считают, что они планируют атаковать человечество. Что вы сделаете в 1 очередь?";
        }

        protected void storyGenerate()
        {
            storyNumber = rand.Next(0, 4);
            stories();
            currentQuestion = story[storyNumber][0];
            lblEventField.Text = currentQuestion;
            firstAnswerGenerate();
        }

        public void questionsInfection()
        {
            story[0][1] = "Вашу больницу заполнили больные этим вирусом, что вы будете делать?";
            story[0][2] = "Люди спокойны, но врачи уже не справляются.";
            story[0][3] = "";
            story[0][4] = "";
            story[0][5] = "";
            story[0][6] = "";
            story[0][7] = "";
            story[0][8] = "";
            story[0][9] = "";
            story[0][10] = "";
            story[0][11] = "";
            story[0][12] = "";
            story[0][13] = "";
            story[0][14] = "";
            story[0][15] = "";
            story[0][16] = "";
            story[0][17] = "";
            story[0][18] = "";
            story[0][19] = "";
            story[0][20] = "";
            story[0][21] = "";
            story[0][22] = "";
            story[0][23] = "";
            story[0][24] = "";
            story[0][25] = "";
            story[0][26] = "";
            story[0][27] = "";
            story[0][28] = "";
            story[0][29] = "";
            story[0][30] = "";
            story[0][31] = "";
            story[0][32] = "";
            story[0][33] = "";
            story[0][34] = "";
        }

        public void questionsFlood()
        {
            story[3][1] = "Неужели вы правда собираетесь это сделать? Как?";
            story[3][2] = "Где вы возьмете столько людей?";
            story[3][3] = "Вы нашли людей, но мало.";
            story[3][4] = "У вас большая команда. Так держать!";
            story[3][5] = "Вы не нашли людей.";
            story[3][6] = "К вам пришёл 1 человек.";
            story[3][7] = "Люди пришли к вам.";
            story[3][8] = "Со временем люди начали сомневаться в вас и ваших намерениях.";
            story[3][9] = "Люди посчитали вас больным.";
            story[3][10] = "Что? Зачем?";
            story[3][11] = "Какой корабль построите?";
            story[3][12] = "В этом подводном мире вы можете дышать под водой! Это ваше спасение!";
            story[3][13] = "Это настоящий город под водой! Здесь невероятно красиво!";
            story[3][14] = "Вы не заметили поломку акваланга. Из-за кислородного голодания у вас были галлюцинации, а затем вы погибли. Ну хоть не из-за наводнения ¯/_(ツ)_/¯";
            story[3][15] = "Вы слышите странное шипение..";
            story[3][16] = "Черт!! Акваланг сломался!!";
            story[3][17] = "Вы выжили, но что делать дальше? Надежда потеряна?";
            story[3][18] = "Всё-таки где вы возьмете столько людей?";
            story[3][19] = "Люди продолжили работать как ни в чем не бывало.";
            story[3][20] = "Ого.. Хорошо..";
            story[3][21] = "Вы потратили все деньги на запасы. Корабль получился ужасным и вы потонули вместе с своей едой :)";
            story[3][44] = "Вы потратили все деньги на дерево. Корабль получился отличным но вы умерли от голода :)";
            story[3][22] = "Ты сломал корабль!";
            story[3][23] = "Вы спасли всех. Вы герой. Стоп.. Что это за хруст....";
            story[3][40] = "Вы уехали один, а остальные люди погибли.";
            story[3][24] = "Этот человек привёз вас в гигантский бункер под землей с большими запасами еды и своей экосистемой. Это рай под землей. Вы спасены.";
            story[3][25] = "Вы встретили человека, который что-то знает...";
            story[3][26] = "Происходит эвакуация. Пойти со всеми?";
            story[3][27] = "Наводнение произошло. Мир гибнет.";
            story[3][28] = "Спустя долгое количество времени вы видите что-то светящееся глубоко в воде...";
            story[3][29] = "Вам повезло! Вы нашли настолько высокую гору, где вода вас не достанет.";
            story[3][30] = "Вы погибли.";
            story[3][31] = "Вы спасли всех. Вы герой.";
            story[3][32] = "Вы спасли континент.";
            story[3][33] = "Вы спасли свою команду, но у вас крайне мало запасов. Через несколько месяцев вы умрете.";
            story[3][34] = "Вам не удалось никого спасти.";
            story[3][35] = "Ваш корабль просто гигантских размеров! Туда поместятся все люди и запасы!!";
            story[3][39] = "Ваш корабль просто гигантских размеров! Туда поместятся все люди и запасы!!!";
            story[3][36] = "Корабль рушится!!! Все погибнут!";
            story[3][37] = "Вы починили корабль.";
            story[3][38] = "Корабль рушится!!! Вас настигла карма! Ну, хоть люди выжили";
            story[3][42] = "Вы построили хороший корабль, но один вы долго не протянете.\nВы погибли через полгода.";
            story[3][43] = "Эвакуация потерпела неудачу. Волна всех забрала.";
            story[3][45] = "В этом подводном мире вы можете дышать под водой! Это ваше спасение!!";
            story[3][46] = "По пути тебя съела акула.";
            story[3][47] = "Вы умерли в одиночестве.";
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
                    btnChoice1.Text = "Построю корабль";
                    btnChoice2.Text = "Пойду в горы";
                    btnChoice3.Text = "Найду подводный мир";
                    btnChoice4.Text = "Смирюсь";
                    break;
                case 4:
                    btnChoice1.Text = "Ничего, считаю, что все хорошо";
                    btnChoice2.Text = "Выброшу всю технику";
                    btnChoice3.Text = "Выключу всех роботов";
                    btnChoice4.Text = "Напишу вирус";
                    break;
            }
        }


        public void saveFunction()
        {
            string[] savedData = new string[100];

            savedData[0] = "День " + dayNumber.ToString();
            savedData[1] = "Текущая история - " + storyTheme[storyNumber];
            savedData[2] = currentQuestion;
            savedData[3] = storyNumber.ToString();

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
            stories();

            if (File.Exists("data.txt"))
            {
                loadedData = File.ReadAllLines("data.txt");
                MessageBox.Show(loadedData[1],loadedData[0]);
            }
            currentDay = loadedData[0];
            currentQuestion = loadedData[2];
            storyNumber = Convert.ToInt32(loadedData[3]);

            lblDay.Text = currentDay;
            lblEventField.Text = currentQuestion;

            if ((currentQuestion == story[0][0]) ||
                (currentQuestion == story[1][0]) ||
                (currentQuestion == story[2][0]) ||
                (currentQuestion == story[3][0]) ||
                (currentQuestion == story[4][0]))
                
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

        bool work = false;
        bool alone = false;
        private void btnChoice1_Click(object sender, EventArgs e)
        {
            switch (storyTheme[storyNumber])
            {
                case "Инфекция":

                    questionsInfection();
                    if (currentQuestion == story[0][0]) 
                    {
                        currentQuestion = story[0][1];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Text = "Не допущу паники";
                        btnChoice2.Text = "Вызову подмогу";
                        btnChoice3.Text = "Вам здесь не рады";
                        btnChoice4.Text = "Сбегу";
                    }
                   else if(currentQuestion == story[0][1])
                    {
                        currentQuestion = story[0][2];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Text = "Дать врачам отдохнуть";
                        btnChoice2.Text = "Заставить работать";
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                    }
                    break;
                case "Война":

                    break;
                case "Нашествие":

                    break;

                case "Наводнение":
                    questionsFlood();
                    if (currentQuestion == story[3][0])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][1];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 11);
                        btnChoice1.Text = "Сплотить всех людей для его создания.";
                        btnChoice2.Text = "Своими руками";
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                    }
                    else if (currentQuestion == story[3][1])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][2];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Агитация";
                        btnChoice2.Text = "Заплачу";
                        btnChoice3.Enabled = true;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "Воодушевлю";
                        btnChoice4.Text = "";
                    }
                    else if(currentQuestion == story[3][2])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][9];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Продолжу искать";
                        btnChoice2.Text = "Сам сделаю..";
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if(currentQuestion == story[3][9])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][18];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Заплачу";
                        btnChoice2.Text = "Воодушевлю";
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                        dayNumber++;
                    }
                    else if (currentQuestion == story[3][18])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][4];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Отлично. Приступим.";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][4])
                    {
                        dayNumber++;
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][8];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Заплачу им ещё.";
                        btnChoice2.Text = "Воодушевлю красивой речью.";
                        btnChoice2.Enabled = true;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][8])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][19];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 11F);
                        btnChoice2.Font = new Font("Century Gothic", 11F);
                        btnChoice1.Text = "Я должен работать вместе с ними";
                        btnChoice2.Text = "Работайте, а я пока отдохну";
                        btnChoice2.Enabled = true;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][19])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][22];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 11F);
                        btnChoice2.Font = new Font("Century Gothic", 11F);
                        btnChoice1.Text = "Уп-с, ну, починим...";
                        btnChoice2.Text = "";
                        btnChoice2.Enabled = false; 
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][22])
                    {
                        dayNumber = 5;
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][37];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 11F);
                        btnChoice2.Font = new Font("Century Gothic", 11F);
                        btnChoice1.Text = "Фух, наконец-то";
                        btnChoice2.Text = "";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][37])
                    {
                        dayNumber = 6;
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][35];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 11F);
                        btnChoice2.Font = new Font("Century Gothic", 11F);
                        btnChoice1.Text = "Отлично! Все на борт!!!";
                        btnChoice2.Text = "ХАХАХА Я ПОЕДУ ОДИН";
                        btnChoice2.Enabled = true;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][35])
                    {
                        dayNumber = 7;
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][23];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 11F);
                        btnChoice2.Font = new Font("Century Gothic", 11F);
                        btnChoice1.Text = "Что?!!!";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][23])
                    {
                        dayNumber = 7;
                        if (alone == false)
                        {
                            currentQuestion = story[3][36];
                        }
                        else
                        {
                            currentQuestion = story[3][38];
                        }
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 11F);
                        btnChoice2.Font = new Font("Century Gothic", 11F);
                        btnChoice1.Text = "НЕТ!!!!!!!!!!";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][26])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][25];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Text = "Пойти с ним";
                        btnChoice2.Text = "Эвакуироваться";
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                    }
                    else if (currentQuestion == story[3][25])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][24];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Text = "Ура!!";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                    }
                    else if ((currentQuestion == story[3][21])||
                               (currentQuestion==story[3][36])||    
                               (currentQuestion == story[3][38])||
                               (currentQuestion == story[3][40])|| 
                               (currentQuestion == story[3][42])||
                               (currentQuestion == story[3][27])||
                               (currentQuestion == story[3][24])||
                               (currentQuestion == story[3][43])||
                               (currentQuestion == story[3][14])||
                               (currentQuestion == story[3][12])||
                               (currentQuestion == story[3][46])||
                               (currentQuestion == story[3][44])||
                               (currentQuestion == story[3][29])||
                               (currentQuestion == story[3][47]))
                    {
                        dayNumber = 7;
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = endOfGame;
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Visible = false;
                        btnChoice2.Visible = false;
                        btnChoice3.Visible = false;
                        btnChoice4.Visible = false;
                    }
                    else if (currentQuestion == story[3][45])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][14];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Уп-с";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][28])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][13];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Вау!";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][13])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][15];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Проверить";
                        btnChoice2.Text = "Не обращать внимания";
                        btnChoice2.Enabled = true;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][15])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][16];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Плыть до города под водой";
                        btnChoice2.Text = "Плыть наверх";
                        btnChoice2.Enabled = true;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][16])
                    {
                        lblDay.Text = "День " + 6;
                        currentQuestion = story[3][12];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Ура!!";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][12])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][14];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Уп-с";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][20])
                    {
                        dayNumber = 7;
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][44];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Уп-с..";
                        btnChoice2.Enabled = false;
                        btnChoice2.Text = "";
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    break;
                case "Искуственный интеллект":

                    break;
            }
        }
        
        private void btnChoice2_Click(object sender, EventArgs e)
        {
            switch (storyTheme[storyNumber])
            {
                case "Инфекция":

                    questionsInfection();
                    if (currentQuestion == story[0][0])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[0][1];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Text = "Не допущу паники";
                        btnChoice2.Text = "Вызову подмогу";
                        btnChoice3.Text = "Вам здесь не рады";
                        btnChoice4.Text = "Сбегу";
                    }
                    else if (currentQuestion == story[0][1])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[0][2];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Text = "Дать врачам отдохнуть";
                        btnChoice2.Text = "Заставить работать";
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                    }
                    

                    break;
                case "Война":

                    break;
                case "Нашествие":

                    break;

                case "Наводнение":
                    questionsFlood();
                    if (currentQuestion == story[3][0])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][29];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Ура";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][9])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][42];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Заплачу";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                        dayNumber++;
                    }
                    else if (currentQuestion == story[3][8])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][19];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 11F);
                        btnChoice2.Font = new Font("Century Gothic", 11F);
                        btnChoice1.Text = "Я должен работать вместе с ними";
                        btnChoice2.Text = "Работайте, а я пока отдохну";
                        btnChoice2.Enabled = true;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][16])
                    {
                        lblDay.Text = "День " + 6;
                        currentQuestion = story[3][17];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Снова плыть до города под водой";
                        btnChoice2.Text = "Попытаться доплыть до острова рядом";
                        btnChoice2.Enabled = true;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][17])
                    {
                        lblDay.Text = "День " + 6;
                        currentQuestion = story[3][46];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "М-да..";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][15])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][45];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Ура!";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][1])
                    {
                        dayNumber++;
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][20];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Потратить деньги на дерево";
                        btnChoice2.Text = "Потратить деньги на запасы";
                        btnChoice3.Enabled = true;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "Баланс";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][20])
                    {
                        dayNumber = 7;
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][21];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Уп-с..";
                        btnChoice2.Enabled = false;
                        btnChoice2.Text = "";
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][2])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][4];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Отлично. Приступим.";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][19])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        work = true;
                        currentQuestion = story[3][35];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 11F);
                        btnChoice2.Font = new Font("Century Gothic", 11F);
                        btnChoice1.Text = "Отлично! Все на борт!!!";
                        btnChoice2.Text = "ХАХАХА Я ПОЕДУ ОДИН";
                        btnChoice2.Enabled = true;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][35])
                    {
                        dayNumber = 7;
                        lblDay.Text = "День " + dayNumber.ToString();
                        if (work == true)
                        {
                            dayNumber = 7;
                            lblDay.Text = "День " + dayNumber.ToString();
                            currentQuestion = story[3][40];
                            lblEventField.Text = currentQuestion;
                            btnChoice1.Font = new Font("Century Gothic", 11F);
                            btnChoice2.Font = new Font("Century Gothic", 11F);
                            btnChoice1.Text = "АХАХАХА";
                            alone = true;
                            btnChoice2.Enabled = false;
                            btnChoice3.Enabled = false;
                            btnChoice4.Enabled = false;
                            btnChoice3.Text = "";
                            btnChoice4.Text = "";
                        }
                        else
                        {
                            dayNumber = 7;
                            lblDay.Text = "День " + dayNumber.ToString();
                            currentQuestion = story[3][38];
                            lblEventField.Text = currentQuestion;
                            btnChoice1.Font = new Font("Century Gothic", 11F);
                            btnChoice2.Font = new Font("Century Gothic", 11F);
                            btnChoice1.Text = "Что?!!!";
                            btnChoice2.Enabled = false;
                            btnChoice3.Enabled = false;
                            btnChoice4.Enabled = false;
                            btnChoice3.Text = "";
                            btnChoice4.Text = "";
                        }
                        
                    }
                    else if (currentQuestion == story[3][25])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][43];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Text = "Уп-с";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                    }
                    else if (currentQuestion == story[3][26])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][47];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Text = "Хорошо.";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                    }

                    break;
                case "Искуственный интеллект":

                    break;
            }
        }

        private void btnChoice3_Click(object sender, EventArgs e)
        {
            switch (storyTheme[storyNumber])
            {
                case "Инфекция":

                    questionsInfection();
                    if (currentQuestion == story[0][0])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[0][1];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Text = "Не допущу паники";
                        btnChoice2.Text = "Вызову подмогу";
                        btnChoice3.Text = "Вам здесь не рады";
                        btnChoice4.Text = "Сбегу";
                    }
                    else if (currentQuestion == story[0][1])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[0][2];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Text = "Дать врачам отдохнуть";
                        btnChoice2.Text = "Заставить работать";
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                    }

                    break;
                case "Война":

                    break;
                case "Нашествие":

                    break;

                case "Наводнение":
                    questionsFlood();
                    if (currentQuestion == story[3][20])
                    {
                        dayNumber = 7;
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][42];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "...";
                        btnChoice2.Enabled = false;
                        btnChoice2.Text = "";
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][0])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][28];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Ого! Что это?";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][2])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][4];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 15.75F);
                        btnChoice1.Text = "Отлично. Приступим.";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][8])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][19];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Font = new Font("Century Gothic", 11F);
                        btnChoice2.Font = new Font("Century Gothic", 11F);
                        btnChoice1.Text = "Я должен работать вместе с ними";
                        btnChoice2.Text = "Работайте, а я пока отдохну";
                        btnChoice2.Enabled = true;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                        btnChoice3.Text = "";
                        btnChoice4.Text = "";
                    }
                    else if (currentQuestion == story[3][26])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][27];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Text = "...";
                        btnChoice2.Enabled = false;
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                    }
                    break;
                case "Искуственный интеллект":

                    break;
            }
        }

        private void btnChoice4_Click(object sender, EventArgs e)
        {
            switch (storyTheme[storyNumber])
            {
                case "Инфекция":

                    questionsInfection();
                    if (currentQuestion == story[0][0])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[0][1];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Text = "Не допущу паники";
                        btnChoice2.Text = "Вызову подмогу";
                        btnChoice3.Text = "Вам здесь не рады";
                        btnChoice4.Text = "Сбегу";
                    }
                    else if (currentQuestion == story[0][1])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[0][2];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Text = "Дать врачам отдохнуть";
                        btnChoice2.Text = "Заставить работать";
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                    }

                    break;
                case "Война":

                    break;
                case "Нашествие":

                    break;

                case "Наводнение":
                    questionsFlood();
                    if (currentQuestion == story[3][0])
                    {
                        lblDay.Text = "День " + dayNumber.ToString();
                        currentQuestion = story[3][26];
                        lblEventField.Text = currentQuestion;
                        btnChoice1.Text = "Да";
                        btnChoice2.Text = "Нет";
                        btnChoice3.Enabled = false;
                        btnChoice4.Enabled = false;
                    }
                    break;
                case "Искуственный интеллект":

                    break;
            }
        }
    }
}
