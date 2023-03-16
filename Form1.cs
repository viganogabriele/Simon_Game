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
        Random random = new Random();

        bool inStampa = false;
        bool tastoAcceso = false;

        private void btnStart_Click(object sender, EventArgs e)
        {
            /*
            sequenza.Add(0);
            sequenza.Add(1);
            sequenza.Add(2);
            sequenza.Add(3);
            sequenza.Add(3);
            */
            
            AllungaSequenza(sequenza);
            InizioStampa(sequenza);
        }

        void AllungaSequenza(List<int> sequenza)
        {
            sequenza.Add(random.Next(4));
        }

        void InizioStampa(List<int> sequenza)
        {
            inStampa = true;
            //Stampa(); Da attivare per versione senza timer
        }


        // Versione con timer, sbianca tutti i tasti e colora il nuovo tasto allo stesso tempo. Non riusciamo a mettere 
        // un tempo distop con sleep tra lo sbiancamento e il colorare

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
                if (contatore == sequenza.Count)
                {
                    contatore = 0;
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
                        ColoraTasto(sequenza[contatore]);
                        contatore++;
                    }
                }
            }
            else
            {
                // In gioco
            }
        }


    }
}
