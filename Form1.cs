using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimonGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> sequenza = new List<int>();
        int contInserisci = 0;
        int contStampa = 0;
        int score = 0;
        Random random = new Random();
        int contSbianca = 0;

        bool inStampa = false;
        bool tastoAcceso = false;

        private void btnStart_Click(object sender, EventArgs e)
        {
            contInserisci = 0;
            contStampa = 0;
            lblGameOver.Visible = false;
            sequenza.Clear();
            score = 0;
            AllungaSequenza(sequenza);
            InizioStampa();
        }

        void AllungaSequenza(List<int> sequenza)
        {
            sequenza.Add(random.Next(4));
        }

        void InizioStampa()
        {
            inStampa = true;
        }

        private void ColoraTasto(int tasto)
        {
            if (tasto == 0)
            {
                picR.BackColor = Color.Red;
                EmettiSuono(310);
            }
            else if (tasto == 1)
            {
                picB.BackColor = Color.Blue;
                EmettiSuono(209);
            }
            else if (tasto == 2)
            {
                picY.BackColor = Color.Yellow;
                EmettiSuono(252);
            }
            else if (tasto == 3)
            {
                picG.BackColor = Color.Green;
                EmettiSuono(415);
            }

            tastoAcceso = true;

        }

        private void EmettiSuono(int freq)
        {
            System.Threading.Tasks.Task.Run(() => Console.Beep(freq, timer.Interval));
        }

        private void SbiancaTasti()
        {
            picR.BackColor = Color.DarkGray;
            picB.BackColor = Color.DarkGray;
            picY.BackColor = Color.DarkGray;
            picG.BackColor = Color.DarkGray;

            tastoAcceso = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (inStampa == true)
            {
                if (contStampa == sequenza.Count)
                {
                    contInserisci = 0;
                    inStampa = false;
                    SbiancaTasti();
                }
                else
                {
                    if (tastoAcceso)
                    {
                        SbiancaTasti();
                    }
                    else
                    {
                        ColoraTasto(sequenza[contStampa]);
                        contStampa++;
                    }
                }
            }
            else
            {
                if (tastoAcceso)
                {
                    SbiancaTasti();
                }
            }
        }

        private void picR_Click(object sender, EventArgs e)
        {
            if (inStampa == false)
            {
                ColoraTasto(0);
                if (sequenza[contInserisci] == 0 && contInserisci == sequenza.Count-1)
                {
                    AllungaSequenza(sequenza);
                    contInserisci = 0;
                    contStampa = 0;
                    score++;
                    lblScore.Text = score.ToString();
                    InizioStampa();
                }
                else if (sequenza[contInserisci] == 0)
                {
                    contInserisci++;
                }
                else
                {
                    lblGameOver.Visible = true;
                    sequenza.Clear();
                }
                tastoAcceso = true;
            }
        }

        private void picB_Click(object sender, EventArgs e)
        {
            if (inStampa == false)
            {
                ColoraTasto(1);
                if (sequenza[contInserisci] == 1 && contInserisci == sequenza.Count-1)
                {
                    AllungaSequenza(sequenza);
                    contInserisci = 0;
                    contStampa = 0;
                    score++;
                    lblScore.Text = score.ToString();
                    InizioStampa();
                }
                else if (sequenza[contInserisci] == 1)
                {
                    contInserisci++;
                }
                else
                {
                    lblGameOver.Visible = true;
                    sequenza.Clear();
                }
                tastoAcceso = true;
            }
        }

        private void picY_Click(object sender, EventArgs e)
        {
            if (inStampa == false)
            {
                ColoraTasto(2);
                if (sequenza[contInserisci] == 2 && contInserisci == sequenza.Count - 1)
                {
                    AllungaSequenza(sequenza);
                    contInserisci = 0;
                    contStampa = 0;
                    score++;
                    lblScore.Text = score.ToString();
                    InizioStampa();
                }
                else if (sequenza[contInserisci] == 2)
                {
                    contInserisci++;
                }
                else
                {
                    lblGameOver.Visible = true;
                    sequenza.Clear();
                }
                tastoAcceso = true;
            }
        }

        private void picG_Click(object sender, EventArgs e)
        {
            if (inStampa == false)
            {
                ColoraTasto(3);
                if (sequenza[contInserisci] == 3 && contInserisci == sequenza.Count - 1)
                {
                    AllungaSequenza(sequenza);
                    contInserisci = 0;
                    contStampa = 0;
                    score++;
                    lblScore.Text = score.ToString();
                    InizioStampa();
                }
                else if (sequenza[contInserisci] == 3)
                {
                    contInserisci++;
                }
                else
                {
                    lblGameOver.Visible = true;
                    sequenza.Clear();
                }
                tastoAcceso = true;
            }
        }
    }
}
