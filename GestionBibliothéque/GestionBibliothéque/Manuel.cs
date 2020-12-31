using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliothéque
{
    class Manuel: Livre
    {
        public int Niveau { get; set; }


        public Manuel(int num, string titre, string aut, int nPage, int niv) : base(num, titre, aut, nPage)
        {

            Niveau = niv;

        }

        public override string ToString()
        {
            return "Numero d'enregistrement : " + NumEnreg + ".\n"
                + "le Titre :" + Titre + ".\n "
                + "l'auteur : " + Auteur + ".\n "
                + "le nombre de pages : " + NbrPages + ".\n "
                + "le niveau scolaire : " + Niveau + ".\n ";
        }





    }
}
