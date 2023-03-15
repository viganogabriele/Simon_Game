using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SimonGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> sequenza = new List<int>();
        int contatore = 0;
        Random random = new Random();
        bool inStampa = false;

        private void btnStart_Click(object sender, EventArgs e)
        {
            sequenza.Add(0);
            sequenza.Add(1);
            sequenza.Add(2);
            sequenza.Add(3);
            sequenza.Add(3);
            //AllungaSequenza(sequenza); Da mettere dopo aver tolto la sequenza di prova
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
                picR.BackColor = Color.Cyan;
            }
            else if (tasto == 1)
            {
                picB.BackColor = Color.Fuchsia;
            }
            else if (tasto == 2)
            {
                picY.BackColor = Color.Orange;
            }
            else if (tasto == 3)
            {
                picG.BackColor = Color.Lime;
            }

        }

        private void SbiancaTasti()
        {
            picR.BackColor = Color.Red;
            picB.BackColor = Color.Blue;
            picY.BackColor = Color.Yellow;
            picG.BackColor = Color.Green;
        }
        private void StampaProssimoElemento()
        {
            SbiancaTasti();
            Thread.Sleep(1000);
            ColoraTasto(sequenza[contatore]);
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
                    StampaProssimoElemento();
                    contatore++;
                }
            }
            else
            {
                // In gioco
            }
        }


// --------------------------------------------------------------------------------------------------------------------------------------------------------------
 /* Versione senza Timer non funzionante: I tempi con gli sleep si sommano e dopo quel tempo stampa tutto insieme
        
        
        void Stampa()
        {
            if (inStampa == true)
            {
                foreach (int tasto in sequenza)
                {
                    switch (tasto)
                    {
                        case 0:
                            picR.BackColor = Color.Cyan;
                            foo();
                            break;
                        case 1:
                            picB.BackColor = Color.Fuchsia;
                            break;
                        case 2:
                            picY.BackColor = Color.Orange;
                            Thread.Sleep(2000);
                            break;
                        case 3:
                            picG.BackColor = Color.Lime;
                            Thread.Sleep(2000);
                            break;
                    }
                }
                inStampa = false;
            }
        }


        //Copiato da StackOverFlow
       async void foo()
        {
            await Task.Delay(2000);
        }
        */
    }
}
