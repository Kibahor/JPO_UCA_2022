using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace JPO_2022
{
    class Entite : INotifyPropertyChanged
    {
        private double x;
        public double X
        {
            get => x;
            protected set
            {
                if (x == value) return;
                x = value;
                OnPropertyChanged(nameof(X));
            }
        }
        private double y;
        public double Y
        {
            get => y;
            protected set
            {
                if (y == value) return;
                y = value;
                OnPropertyChanged(nameof(Y));
            }
        }

        public double HAUTEUR;

        public double LARGEUR;

        private Visibility visible = Visibility.Visible;
        public Visibility Visible
        {
            get => visible;
            set
            {
                if (visible == value) return;
                visible = value;
                OnPropertyChanged(nameof(Visible));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Entite(double hauteur, double largeur)
        {
            this.X = 20;
            this.Y = 20;
            this.HAUTEUR = hauteur;
            this.LARGEUR = largeur;
        }

        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
