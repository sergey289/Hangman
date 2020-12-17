using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Categories
{
    class CountriesCategory
    {
            static Random ran = new Random();

            string[] EasyWords = new string[] { "Israel", "Egypt", "India", "Spain", "Italy" };

            string[] HardWords = new string[] { "Lesotho", "Malaysia", "Morocco", "Montserrat", "Netherlands" };

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
