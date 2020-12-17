using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Categories
{
    class FoodCategory
    {
        static Random ran = new Random();

        string[] EasyWords = new string[] { "Apple", "Banana", "Beef", "Bread", "Cabbage" };

        string[] HardWords = new string[] { "Cranberry", "Cucumber", "Grapefruit", "Hamburger", "Lobster" };
        public string СhooseWord()
        {

            string word = "";


            if (MainWindow.leveldif_easey != false)
            {
                word = EasyWords[ran.Next(0, EasyWords.Length)];

            }
            else if (MainWindow.leveldif_hard != false)
            {

                word = HardWords[ran.Next(0, EasyWords.Length)];

            }

            return word;


        }

    }
}
