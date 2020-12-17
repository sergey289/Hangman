using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Hangman.Categories;


namespace Hangman
{
    class GameManager
    {

      

        public BitmapImage pic1Url = new BitmapImage(new Uri("/Resources/pic1.png", UriKind.Relative));
        public BitmapImage pic2Url = new BitmapImage(new Uri("/Resources/pic2.png", UriKind.Relative));
        public BitmapImage pic3Url = new BitmapImage(new Uri("/Resources/pic3.png", UriKind.Relative));
        public BitmapImage pic4Url = new BitmapImage(new Uri("/Resources/pic4.png", UriKind.Relative));
        public BitmapImage pic5Url = new BitmapImage(new Uri("/Resources/pic5.png", UriKind.Relative));
        public BitmapImage pic6Url = new BitmapImage(new Uri("/Resources/pic6.png", UriKind.Relative));
        public BitmapImage pic7Url = new BitmapImage(new Uri("/Resources/pic7.png", UriKind.Relative));


        SportCategory Sportcategory = new SportCategory();
        AnimalCategory AnimalCategory = new AnimalCategory();
        FoodCategory Foodcategory = new FoodCategory();
        CountriesCategory Countriescategory = new CountriesCategory();

       

        public string WordOfGame;
        public  char letterForSearch;

      

        public void Clean()
        {
            var gameWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is GameWindow) as GameWindow;

            if (MainWindow.leveldif_hard != false)
            {
               
                
                gameWindow.img_hangman.Source =pic2Url;
               
            }
            else
            {
                gameWindow.img_hangman.Source = pic1Url;

            }


            gameWindow.lab_gameover.Visibility = Visibility.Hidden;

            gameWindow.lab_win.Visibility = Visibility.Hidden;

            

            foreach (Button bt in gameWindow.grid1.Children.OfType<Button>())
            {


                if (bt.Name != "btn_new_word" | bt.Name != "btn_new_game")
                {
                    bt.IsEnabled = true;
                }

            }

            foreach (Label lb in gameWindow.grid1.Children.OfType<Label>())
            {

                lb.Visibility = Visibility.Hidden;


            }



            







        }  
        public void Newgame()
        {
             var gameWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is GameWindow) as GameWindow;
           
            Clean();

            gameWindow.txt_word.Text = HideWord(WordOfGame);

        }  
        private string HideWord(string word)
        {
            StringBuilder encryption = new StringBuilder();

            encryption.Clear();

            int wordlength = word.Length;


            for (int i = 0; i < wordlength; i++)
            {
                encryption.Append("*");

            }

            return encryption.ToString();
        } 
        public void ChooseWordFromCategory()
        {
     
            var gameWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is GameWindow) as GameWindow;


            if (MainWindow.categorynumber == 1)
            {
                
                WordOfGame = Sportcategory.СhooseWord();
                
                gameWindow.txt_word.Text = HideWord(WordOfGame);

            }
            else if (MainWindow.categorynumber == 2)
            {

                WordOfGame = AnimalCategory.СhooseWord();

                gameWindow.txt_word.Text = HideWord(WordOfGame);

            }
            else if (MainWindow.categorynumber == 3)
            {

                WordOfGame = Foodcategory.СhooseWord();

                gameWindow.txt_word.Text = HideWord(WordOfGame);


            }
            else if (MainWindow.categorynumber == 4)
            {

                WordOfGame = Countriescategory.СhooseWord();

                gameWindow.txt_word.Text = HideWord(WordOfGame);


            }

        } 
        public bool SearchAndOpenLetter()
        {
           
            bool ifletterexist = true;

            var gameWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is GameWindow) as GameWindow;

            StringBuilder wordhide = new StringBuilder();

            StringBuilder currentword = new StringBuilder();


            if (WordOfGame.Contains(Char.ToLower(letterForSearch)) || WordOfGame.Contains(Char.ToUpper(letterForSearch)) && gameWindow.img_hangman.Source != pic7Url)
            {


                currentword.Append(WordOfGame);//footbol

                wordhide.Append(gameWindow.txt_word.Text); //*******

                for (int i = 0; i < currentword.Length; i++)
                {

                    if (currentword[i] == Char.ToLower(letterForSearch) && gameWindow.img_hangman.Source != pic7Url)
                    {

                        wordhide[i] = Char.ToLower(letterForSearch);

                        continue;

                    }


                    if (currentword[i] == Char.ToUpper(letterForSearch) && gameWindow.img_hangman.Source != pic7Url)
                    {


                        wordhide[i] = Char.ToUpper(letterForSearch);

                        continue;
                    }



                }



                gameWindow.txt_word.Text = wordhide.ToString();




            }
            else
            {
                ifletterexist = false;

            }

            return ifletterexist;

        } 


    }

}
