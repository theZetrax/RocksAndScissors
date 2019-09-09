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
        private GameMove player_move_choice;
        private GameMove opponent_move_choice;
        private int player_score; // Players score
        private int opponent_score; // Opponents
        private bool hasMoved = false;

        public GameWindow()
        {
            InitializeComponent();

            /* 
             * Player and Opponent must have 0 point(s) when beggining.
             * 
             */

            player_score = 0;
            opponent_score = 0;
            Result_lbl.Content = "You can Begin. Fight!!!";
            UpdatePlayerScores();
        }

        public void ChooseOponentMove()
        {
            int randomChoice = new Random(DateTime.Now.Millisecond).Next(0, 4);
            switch(randomChoice)
            {
                case 0:
                    opponent_move_choice = GameComponents.Rock;
                    OpponentMove.Source = new BitmapImage(new Uri(this.Resources["RockImg"].ToString()));
                    break;
                case 1:
                    opponent_move_choice = GameComponents.Paper;
                    OpponentMove.Source = new BitmapImage(new Uri(this.Resources["PaperImg"].ToString()));
                    break;
                case 2:
                    opponent_move_choice = GameComponents.Scissor;
                    OpponentMove.Source = new BitmapImage(new Uri(this.Resources["ScissorImg"].ToString()));
                    break;
                case 3:
                    opponent_move_choice = GameComponents.Lizard;
                    OpponentMove.Source = new BitmapImage(new Uri(this.Resources["LizardImg"].ToString()));
                    break;
                case 4:
                    opponent_move_choice = GameComponents.Spock;
                    OpponentMove.Source = new BitmapImage(new Uri(this.Resources["SpockImg"].ToString()));
                    break;
            }
        }

        private void RockBtn_Click(object sender, RoutedEventArgs e)
        {
            if (hasMoved) return;
            player_move_choice = GameComponents.Rock;
            PlayerMove.Source = new BitmapImage(new Uri(this.Resources["RockImg"].ToString()));
        }

        private void PaperBtn_Click(object sender, RoutedEventArgs e)
        {
            if (hasMoved) return;
            player_move_choice = GameComponents.Paper;
            PlayerMove.Source = new BitmapImage(new Uri(this.Resources["PaperImg"].ToString()));
        }

        private void Scissor_Click(object sender, RoutedEventArgs e)
        {
            if (hasMoved) return;
            player_move_choice = GameComponents.Scissor;
            PlayerMove.Source = new BitmapImage(new Uri(this.Resources["ScissorImg"].ToString()));
        }

        private void Lizard_Click(object sender, RoutedEventArgs e)
        {
            if (hasMoved) return;
            player_move_choice = GameComponents.Lizard;
            PlayerMove.Source = new BitmapImage(new Uri(this.Resources["LizardImg"].ToString()));
        }

        private void Spock_Click(object sender, RoutedEventArgs e)
        {
            if (hasMoved) return;
            player_move_choice = GameComponents.Spock;
            PlayerMove.Source = new BitmapImage(new Uri(this.Resources["SpockImg"].ToString()));
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            if (player_move_choice == null) return; // If player didnot coose a move what can I do.
            if (hasMoved)
            {
                // After a move player must restart the process of choosing a move.
                // This restarts the whole move, both opponents and players.
                GoButton.Content = "Go";
                PlayerMove.Source = new BitmapImage(new Uri(this.Resources["ChooseImg"].ToString()));
                player_move_choice = null;
                OpponentMove.Source = new BitmapImage(new Uri(this.Resources["ChooseImg"].ToString()));
                opponent_move_choice = null;
                hasMoved = false;
                return;
            }

            ChooseOponentMove();
            GameResult move_result = GameComponents.Eval(player_move_choice, opponent_move_choice); // Player's move stored here.
            Result_lbl.Content = move_result.ToString();

            if (move_result.Equals(GameComponents.Win))
                player_score++;
            else if (move_result.Equals(GameComponents.Loose))
                opponent_score++;
            UpdatePlayerScores();
            hasMoved = true;
            GoButton.Content = "Again";
        }

        private void NewGame_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            GameWindow newGame = new GameWindow();
            newGame.Show();
            this.Close();
        }

        private void SaveGame_MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GoToMainMenu_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainMenu = new MainWindow();
            mainMenu.Show();
            this.Close();
        }

        private void ExitGame_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void UpdatePlayerScores()
        {
            PlayerScore_Lbl.Content = player_score.ToString();
            OpponentScore_Lbl.Content = opponent_score.ToString();
        }
    }
}
