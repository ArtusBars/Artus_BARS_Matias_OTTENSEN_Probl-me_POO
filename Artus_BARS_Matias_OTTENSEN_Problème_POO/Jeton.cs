using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artus_BARS_Matias_OTTENSEN_Problème_POO
{
    class Jeton
    {
        private char lettre;
        private int scoreJeton;
        private int nbJetons;

        public Jeton(char lettre, int scoreJeton, int nbJetons)
        {
            this.lettre = lettre;
            this.scoreJeton = scoreJeton;
            this.nbJetons = nbJetons;
        }

        public override string ToString()
        {
            return this.lettre + " " + this.scoreJeton + " " + this.nbJetons;
        }
    }
}
