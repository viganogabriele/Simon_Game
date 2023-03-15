using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //AllungaSequenza(sequenza); Da mettere dopo
            InizioStampa(sequenza);
        }
        void AllungaSequenza(List<int> sequenza)
        {
            sequenza.Add(random.Next(4));
        }
        void InizioStampa(List<int> sequenza)
        {
            inStampa = true;
            Stampa();
        }
        void Stampa()
        {
            if (inStampa == true)
            {
                //System.Threading.Thread.Sleep(500);
                foreach (int tasto in sequenza)
                {

                    switch (tasto)
                    {
                        case 0:
                            picR.BackColor = Color.Cyan;
                            System.Threading.Thread.Sleep(1000);
                            picR.BackColor = Color.Red;
                            break;
                        case 1:

                            picB.BackColor = Color.Fuchsia;
                            System.Threading.Thread.Sleep(1000);
                            picB.BackColor = Color.Blue;
                            break;
                        case 2:

                            picY.BackColor = Color.Orange;
                            System.Threading.Thread.Sleep(1000);
                            picY.BackColor = Color.Yellow;
                            break;
                        case 3:
                            picG.BackColor = Color.Lime;
                            System.Threading.Thread.Sleep(1000);
                            picG.BackColor = Color.Green;
                            break;
                    }
                    System.Threading.Thread.Sleep(1000);

                }
                inStampa = false;
            }
        }
    }
}
