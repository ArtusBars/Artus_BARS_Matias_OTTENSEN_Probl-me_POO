using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Artus_BARS_Matias_OTTENSEN_Problème_POO
{
    class Joueur
    {
        private string nom;
        private int score;
        private List<string> motsTrouvés;
        public Joueur(string nom, int score, List<string> motsTrouvés)
        {
            this.nom = nom;
            this.score = 0;
            this.motsTrouvés = null;
        }
        public Joueur()
        {
            try
            {
                string[] joueur = File.ReadAllLines(@"Joueurs.txt");
                char séparateur = ';';
                for (int k = 0; k < joueur.Length; k++)
                {
                    if (k == 0)
                    {
                        string[] line = joueur[0].Split(séparateur, 2);
                        this.nom = line[0];
                        this.score = int.Parse(line[1]);
                    }
                    else
                    {
                        if (k == 1)
                        {
                            string[] line2 = joueur[1].Split(séparateur);
                            for (int i = 0; i < line2.Length; i++)
                            {
                                this.motsTrouvés.Add(line2[i]);
                            }
                        }
                    }
                }
                
            }
            catch (FileNotFoundException erreur)
            {
                Console.WriteLine("Le fichier n'existe pas " + erreur.Message);
            }
            finally
            {
                Console.WriteLine("Le joueur a été créé avec succès.");
            }
        }
        public void Add_Mot(string mot)
        {
           this.motsTrouvés.Add(mot);
        }
        public override string ToString()
        {
            string s = "";
            string totmots = "";
            for (int i = 0; i < this.motsTrouvés.Count; i++)
            {
                totmots += this.motsTrouvés[i] + "\n";
            }

            s += "Nom : " + this.nom + "  Score :" + this.score + "  Mots Trouvés : \n" + totmots;
            return s;
        }
        public void Add_Score(int val)
        {
            this.score += val;
        }
        public List<Jeton> mainCourante = new List<Jeton>(6);
        public void Add_Main_Courante(Jeton monJeton)
        {
            if (mainCourante.Count < 7)
            {
                mainCourante.Add(monJeton);
            }
            else
            {
                Console.WriteLine("Main courante pleine!");
            }
        }
        public void Remove_Main_Courante(Jeton monJeton)
        {
            if (mainCourante.Count > 0)
            {
                mainCourante.Remove(monJeton);
            }
            else
            {
                Console.WriteLine("Main courante vide!");
            }
        }
    }
}
