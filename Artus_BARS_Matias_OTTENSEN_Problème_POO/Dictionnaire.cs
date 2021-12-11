using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Artus_BARS_Matias_OTTENSEN_Problème_POO
{
    class Dictionnaire
    {
        private List<string> mots;
        private List<List<string>> motsTriés;
        private string langue;
        public Dictionnaire()
        {
            this.langue = "français";
            string[] dico = File.ReadAllLines("Francais.txt");
            this.mots = null;
            foreach (string line in dico)
            {
                for (int k = 0; k < dico.Length; k++)
                {
                    if (k % 2 == 0)
                    {
                        this.mots.Add(line);
                    }
                }
                this.motsTriés.Add(this.mots);
            }
        }
        public override string ToString()
        {
            string result = "Langue : " + this.langue + "\n";
            int longueurMot = 1;
            foreach(List<string> listeMots in this.motsTriés)
            {
                int nbMots = 0;
                longueurMot++;
                for (int k = 0; k < listeMots.Count; k++)
                {
                    nbMots++;
                }
                result += "Mots de longueur " + longueurMot + " : " + nbMots + "\n";
            }
            return result;
        }
        public bool RechDichoRécursif(string mot)
        {
            bool result = true;
            int middle = this.mots.Count / 2;
            if(mots[middle] == mot)
            {
                return result;
            }
            else
            {
                
            }
            
        }

    }
}
