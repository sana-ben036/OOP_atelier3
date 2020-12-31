using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliothéque
{
    class Livre : Document
    {
        public string Auteur { get; set; }
        public int NbrPages { get; set; }

        public Livre()
        {

        }

        public Livre(int num, string titre, string auteur, int nPage) : base(num, titre)
        {
            Auteur = auteur;
            NbrPages = nPage;
        }



        public override string ToString()
        {
            return "Numero d'enregistrement : " + NumEnreg + ".\n"
                + "le Titre :" + Titre + ".\n "
                + "l'auteur : " +Auteur + ".\n "
                + "le nombre de pages : " + NbrPages + ".\n ";
        }


    }
}
