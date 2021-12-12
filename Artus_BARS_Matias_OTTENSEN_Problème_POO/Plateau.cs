using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Artus_BARS_Matias_OTTENSEN_Problème_POO
{
    class Plateau
    {
        private char[,] plateau = new char[15, 15];
        private Dictionnaire dico;
        public Plateau(int param)
        {
            if (param == 0)
            {
                for (int i = 0; i < this.plateau.GetLength(0); i++)
                {
                    for (int j = 0; j < this.plateau.GetLength(1); j++)
                    {
                        this.plateau[i, j] = '_';
                    }
                }
            }
            else
            {
                if (param == 1)
                {
                    this.plateau = null;
                    int nbligne = -1;
                    string[] tabString = File.ReadAllLines(@"InstancePlateau.txt");
                    foreach (string line in tabString)
                    {
                        nbligne++;
                        char[] ligne = line.ToCharArray();
                        for (int k = 0; k < ligne.Length; k++)
                        {
                            if (ligne[k] != ';')
                            {
                                this.plateau[nbligne, k] = ligne[k];
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Veuillez saisir 0 ou 1");
                }
            }
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < this.plateau.GetLength(0); i++)
            {
                for (int j = 0; j < this.plateau.GetLength(1); j++)
                {
                    result += this.plateau[i, j] + " ";
                }
                result += "\n";
            }
            return result;
        }
        public bool Test_Plateau(string mot, int ligne, int colonne, char direction)
        {
            bool result = false;
            if (dico.RechDichoRécursif(mot, 0, dico.Mots.Count))
            {
                if ()
            }
        }
    }
}
