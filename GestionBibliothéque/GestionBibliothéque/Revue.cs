using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliothéque
{
    class Revue : Document
    {
        public int Mois { get; set; }
        public int Annee { get; set; }

        public Revue(int num, string titre, int m, int y): base(num, titre)
        {

            Mois = m;
            Annee = y;



        }

        public override string ToString()
        {
            return "Numero d'enregistrement : " + NumEnreg + ".\n"
                + "le Titre :" + Titre + ".\n "
                + "le mois: " + Mois + ".\n "
                + "l'année : " + Annee + ".\n ";
        }













    }
}
