using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliothéque
{
    class Document
    {
        public int NumEnreg { get; set; }
        public string Titre { get; set; }


        public Document()
        {

        }
        public Document(int Num, string titre)
        {
            NumEnreg = Num;
            Titre = titre;
        }

        public override String  ToString()
        {
            
            return "Numero d'enregistrement : " + NumEnreg + ".\n" 
                + "le Titre :" + Titre + ".\n ";
        }





    }
}
