# JPO UCA 2022
![JPO_UCA_2022](https://www.uca.fr/medias/photo/jpo-2022-site-compos-1060x431px_1643122711061-jpg "JPO_UCA_2022")

## Introduction
Ce git contient le code, qui a été utilisé dans le cadre de la journée porte ouverte du 5 mars 2022, à l'IUT Informatique de Clermont-Ferrand (Université Clermont Auvergne).
Ce code a pour but de faire découvrir la programmation, à travers un atelier de 30min.
Le code est écrit en .NET 3.1/WPF, l'utilisateur doit par l'intermédiaire de méthodes pré-écrite déplacé un "joueur" vers une clé et de la prendre.
Une démo est disponible dans les [releases](https://github.com/Kibahor/JPO_UCA_2022/releases/tag/Stable)

## Comment sa fonctionne ?
Le code doit être écrit dans ```protected override void OnKeyDown(KeyEventArgs e)``` présent [ici](https://github.com/Kibahor/JPO_UCA_2022/blob/main/JPO_2022/MainWindow.xaml.cs).
Le fonctionnement est simple, l'utilisateur utilise les méthodes de `Player` afin d'éxécuter des actions sur la fenêtre, ces dites actions sont éxécuté à la pression de la barre d'espace.

### La première étape
L'utilisateur doit écrire en "dur", les déplacement du joueur.

**Solution :**
```csharp
            if (e.Key.Equals(System.Windows.Input.Key.Space))
            {
                player.DeplacementBas();
                player.DeplacementBas();
                player.DeplacementBas();
                player.DeplacementBas();
                player.DeplacementDroite();
                player.DeplacementDroite();
                player.PickKey(key);
                
                //Autre manière
                for(int i=0;i<4;i++)
                    player.DeplacementBas();
                for (int i = 0; i < 2; i++)
                    player.DeplacementDroite();
                player.PickKey(key);
            }
```

### La deuxième étape 
L'utilisateur doit maintenant attribuer les action a des touches afin de déplacer le joueur librement.

**Solution :**
```csharp
            if (e.Key.Equals(System.Windows.Input.Key.DOWN))
                player.DeplacementBas();
            else if (e.Key.Equals(System.Windows.Input.Key.UP))
                player.DeplacementHaut();
            else if (e.Key.Equals(System.Windows.Input.Key.RIGHT))
                player.DeplacementDroite();
            else if (e.Key.Equals(System.Windows.Input.Key.LEFT))
                player.DeplacementGauche();
            else if (e.Key.Equals(System.Windows.Input.Key.SPACE))
                player.PickKey(key);
```
### Autre possibilité
Si l'utilisateur est rapide, il peut aller plus loin, en gérant les collision du joueur avec la fenêtre, il peut également ajouté une porte qu'il faut atteindre pour obtenir un message de victoire. Les possibilités sont infini !
Durant l'atelier la moitié des utilisateurs sont directemment passer à la deuxième étape, sur environ 50 participant seulement un à écrit le code pour les collisions, cela peut donner une idée du temps que peut mettre une personne n'ayant jamais ou quasiment jamais écrit de code à réaliser l'atelier.

**Ce code a été écrit en collaboration avec :** 
Martin Raoult, Lorianne L'hostis, Alexandre Blondel
