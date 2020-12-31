using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliothéque
{
    class Roman: Livre
    {
        public int PrixLitt { get; set; }


        public Roman(int num,string titre ,string aut , int nPage, int Prix) : base(num,titre,aut,nPage )
        {

            PrixLitt = Prix;



        }

        public override string ToString()
        {
            return "Numero d'enregistrement : " + NumEnreg + ".\n"
                + "le Titre :" + Titre + ".\n "
                + "l'auteur : " + Auteur + ".\n "
                + "le nombre de pages : " + NbrPages + ".\n "
                + "le prix littéraire : " + PrixLitt + ".\n ";
        }









    }
}
