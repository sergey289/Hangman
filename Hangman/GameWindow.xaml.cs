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


namespace Hangman
{
    
    public partial class GameWindow : Window
    {
        

        public GameWindow()
        {
           
            InitializeComponent();

            

            gameManager.ChooseWordFromCategory();

            if (MainWindow.leveldif_hard != false)
            {

               img_hangman.Source = gameManager.pic2Url;

            }
            else
            {
               img_hangman.Source = gameManager.pic1Url;

            }

        }

        GameManager gameManager = new GameManager();

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {


            MainWindow MainWin = new MainWindow();
            MainWin.Show();
            this.Close();
        }

        private void btn_new_game_Click(object sender, RoutedEventArgs e)
        {
            
            gameManager. Newgame();
        }

        private void btn_new_word_Click(object sender, RoutedEventArgs e)
        {
           
            gameManager. Clean();
            gameManager. ChooseWordFromCategory();
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            
           

            Button bt = (Button)sender;

            object labalTag=default;

            labalTag = bt.Tag;


            gameManager. letterForSearch = Convert.ToChar( bt.Tag);

            gameManager. SearchAndOpenLetter();


                if (gameManager.SearchAndOpenLetter() != true)
                {

                   
                   bt.IsEnabled = false;


                foreach (Label label in grid1.Children.OfType<Label>())
                {

                    if (label.Tag != null)
                    {

                        if (label.Tag.Equals(labalTag))
                        {
                            label.Visibility = Visibility.Visible;

                        }

                    }
                    continue;
                   

                }


                if (img_hangman.Source == gameManager.pic1Url)
                    {
                        img_hangman.Source = gameManager.pic2Url;

                    }
                    else if (img_hangman.Source == gameManager.pic2Url)
                    {
                        img_hangman.Source = gameManager. pic3Url;

                    }
                    else if (img_hangman.Source == gameManager. pic3Url)
                    {
                        img_hangman.Source = gameManager.pic4Url;

                    }
                    else if (img_hangman.Source == gameManager.pic4Url)
                    {
                        img_hangman.Source = gameManager.pic5Url;

                    }
                    else if (img_hangman.Source == gameManager.pic5Url)
                    {
                        img_hangman.Source = gameManager.pic6Url;

                    }
                    else if (img_hangman.Source == gameManager. pic6Url)
                    {

                        img_hangman.Source = gameManager.pic7Url;

                        lab_gameover.Visibility = Visibility.Visible;


                        bt.IsEnabled = false;

                    }
                }
                if (txt_word.Text == gameManager. WordOfGame)
                {

                    lab_win.Visibility = Visibility.Visible;
                }

        }
    }
}
