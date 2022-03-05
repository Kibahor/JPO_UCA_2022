using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Timers;

namespace JPO_2022
{
    class Player : Entite
    {
        Queue<Action> commandes = new Queue<Action>();

        public Player(double hauteur, double largeur) : base(hauteur, largeur)
        {
            this.X = 20;
            this.Y = 20;
            this.HAUTEUR = hauteur;
            this.LARGEUR = largeur;

            Timer newTimer = new Timer();
            newTimer.Elapsed += new ElapsedEventHandler(TimerEvent);
            newTimer.Interval = 750;
            newTimer.Start();
        }

        public void DeplacementDroite()
        {
            commandes.Enqueue(()=> { this.X += this.LARGEUR; });
        }

        public void DeplacementGauche()
        {
            commandes.Enqueue(() => { this.X -= this.LARGEUR; });
        }

        public void DeplacementHaut()
        {
            commandes.Enqueue(() => { this.Y -= this.HAUTEUR; });
        }

        public void DeplacementBas()
        {
            commandes.Enqueue(() => { this.Y += this.HAUTEUR; });
        }



        public void TimerEvent(object source, ElapsedEventArgs e)
        {
            if(commandes.Count != 0)
                commandes.Dequeue().Invoke();
        }

        public void PickKey(Key key)
        {
            commandes.Enqueue(() =>
            {
                if (this.X > key.X + key.LARGEUR ||
                    this.Y > key.Y + key.HAUTEUR ||
                    key.X > this.X + this.LARGEUR ||
                    key.Y > this.Y + this.HAUTEUR)
                    return;
                key.Visible = System.Windows.Visibility.Hidden;
            });
        }
    }
}
