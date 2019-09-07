using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
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

        public void FadeOutPlayerImage()
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1.0;
            animation.To = 0.0;
            animation.Duration = new Duration(TimeSpan.FromSeconds(2));
            animation.AutoReverse = true;

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            Storyboard.SetTargetName(animation, PlayerMove.Name);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Image.OpacityProperty));

            storyboard.Begin(this);
        }

        private void RockBtn_Click(object sender, RoutedEventArgs e)
        {
            FadeOutPlayerImage();
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
