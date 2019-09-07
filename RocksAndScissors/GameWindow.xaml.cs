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
using System.Windows.Shapes;

namespace RocksAndScissors
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        private void RockBtn_Click(object sender, RoutedEventArgs e)
        {
            PlayerMove.Source = new BitmapImage(new Uri(this.Resources["RockImg"].ToString()));
        }

        private void PaperBtn_Click(object sender, RoutedEventArgs e)
        {
            PlayerMove.Source = new BitmapImage(new Uri(this.Resources["PaperImg"].ToString()));
        }

        private void Scissor_Click(object sender, RoutedEventArgs e)
        {
            PlayerMove.Source = new BitmapImage(new Uri(this.Resources["ScissorImg"].ToString()));
        }

        private void Lizard_Click(object sender, RoutedEventArgs e)
        {
            PlayerMove.Source = new BitmapImage(new Uri(this.Resources["LizardImg"].ToString()));
        }

        private void Spock_Click(object sender, RoutedEventArgs e)
        {
            PlayerMove.Source = new BitmapImage(new Uri(this.Resources["SpockImg"].ToString()));
        }
    }
}
