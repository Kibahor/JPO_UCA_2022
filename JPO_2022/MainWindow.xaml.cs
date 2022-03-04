using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JPO_2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        Player player;
        Key key;

        public MainWindow()
        {
            InitializeComponent();
            player = new Player(Player1.Width, Player1.Height);
            key = new Key(150,300,Key.Width,Key.Height);
            Player1.DataContext = player;
            Key.DataContext = key;
            
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Key.Equals(System.Windows.Input.Key.Space))
            {
                player.DeplacementBas();
                player.DeplacementBas();
                player.DeplacementBas();
                player.DeplacementBas();
                player.DeplacementDroite();
                player.DeplacementDroite();
                player.PickKey(key);
            }
        }
       
    }
}
