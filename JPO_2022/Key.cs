using System;
using System.Collections.Generic;
using System.Text;

namespace JPO_2022
{
    class Key : Entite
    {
        public Key(double x, double y, double hauteur, double largeur) : base(hauteur, largeur)
        {
            //Random x,y avec algo pour aller jusqu'à la clé
            this.X = x;
            this.Y = y;
        }
    }
}
