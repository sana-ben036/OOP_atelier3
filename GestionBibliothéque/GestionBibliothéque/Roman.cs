using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliothéque
{
    class Roman: Livre
    {
        Dictionary<int, string> prixList { get; set; }


        public Roman(int num,string titre ,string auteur, int nPage, int Prix) : base(num,titre, auteur, nPage )
        {
            prixList = new Dictionary<int, string>();
            prixList.ContainsKey(Prix);
            
        }

        public void AddPrixToList(int key , string value)
        {
            prixList.Add(key,value);
        }

        public void ShowPrixList()
        {
            foreach(KeyValuePair<int, string> prix in prixList)
            {
                Console.WriteLine("Clé: {0}, Valeur: {1}", prix.Key, prix.Value);

            }
        }

        public override string ToString()
        {
            return "Numero d'enregistrement : " + NumEnreg + ".\n"
                + "le Titre :" + Titre + ".\n "
                + "l'auteur : " + Auteur + ".\n "
                + "le nombre de pages : " + NbrPages + ".\n "
                + "le prix littéraire : " + prixList.Values + ".\n ";
        }









    }
}
