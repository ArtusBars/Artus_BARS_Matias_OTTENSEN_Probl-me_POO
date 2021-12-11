using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Artus_BARS_Matias_OTTENSEN_Problème_POO
{
    class Sac_Jetons
    {
        private List<Jeton> sacJetons;
        public Sac_Jetons()
        {
            try
            {
                string[] sac = File.ReadAllLines("Jetons.txt");
                char séparateur = ';';
                foreach (string line in sac)
                {
                    string[] tab = line.Split(séparateur, 3);
                    Jeton j = new Jeton(char.Parse(tab[0]), int.Parse(tab[1]), int.Parse(tab[2]));
                    sacJetons.Add(j);
                }
            }
            catch (FileNotFoundException erreur)
            {
                Console.WriteLine("Le fichier n'existe pas " + erreur.Message);
            }
            finally
            {
                Console.WriteLine("Le sac de jetons a été créé avec succès.");
            }
        }
        public Jeton RetireJeton(Random aléa)
        {
            aléa = new Random();
            int a = aléa.Next(1, sacJetons.Count);
            Jeton jetonAléa = sacJetons[a];
            return jetonAléa;
        }
   
    }
}
