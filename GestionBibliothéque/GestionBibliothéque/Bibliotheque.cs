using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliothéque
{
    class Bibliotheque
    {
        public List<Document> listDoc;
        public Document document;

        public Bibliotheque(int cap)
        {
            listDoc = new List<Document>(cap);
        }

        public int GetNbrDocs()
        {
            int n = listDoc.Count;

            return n;

        }

        public Document GetDocument(int i)
        {
            
            return listDoc[i];
        }

        public bool AddDoc(Document document)
        {
            bool exist = listDoc.Exists(x => x.NumEnreg == document.NumEnreg);
            if (exist == true)
            {
                return false;
            }
            else
            {
                listDoc.Add(document);
                return true;
            }
        }


        public bool DeleteDoc(Document document)
        {
            listDoc.Remove(document);
            bool exist = listDoc.Exists(x => x.NumEnreg == document.NumEnreg);
            if(exist == true)
            {
                return false;
            }
            else
            {
                return true;
            }


        }


        public void AfficherDocuments()
        {
            foreach( Document document in listDoc)
            {
                Console.WriteLine(document.ToString());
            }
        }

        public void AfficherAuteurs()
        {
            var instance = new Livre();
            var instanceType = instance.GetType();
            foreach (Document document in listDoc)
            {
                if(instanceType.IsInstanceOfType(document) == true)
                {
                    Console.WriteLine(instance.Auteur);
                }
                continue;
            }
        }




    }
}
