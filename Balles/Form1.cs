using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Random aleatoire = new Random();
            int entier = aleatoire.Next(); //Génère un entier aléatoire positif
            int mois2 = aleatoire.Next(10); //Génère un entier compris entre 0 et 9
            int mois = aleatoire.Next(1, 13); // Génère un entier compris entre 1 et 12
            //int mois2 = aleatoire.Next(1, 13);
            int mois3 = aleatoire.Next(1, 15);

            balle1.lancer(mois, mois2);
            balle2.lancer(mois3, mois);
            balle3.lancer(mois2, mois3);
        }
    }
}
