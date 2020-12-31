using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliothéque
{
    class Dictionnaire : Document
    {
        public string Langue { get; set; }

        public Dictionnaire(int num, string titre, string lang) : base (num, titre)
        {
            Langue = lang;
        }

        public override string ToString()
        {
            return "Numero d'enregistrement : " + NumEnreg + ".\n"
                + "le Titre :" + Titre + ".\n "
                + "la langue : " + Langue + ".\n ";
        }










    }
}
