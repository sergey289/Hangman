using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class SportCategory
    {

       static Random ran = new Random();

       string[] EasyWords = new string[] { "Football", "Tennis", "Hockey", "Bobsled", "Boxing" };

       string[] HardWords = new string[] { "Volleyball", "Judo", "Triathlon", "Bobsled", "Snowboard" };

       public string СhooseWord()
        {

            string word = "";


            if (MainWindow.leveldif_easey != false)
            {
                word = EasyWords[ran.Next(0, EasyWords.Length)];

            }
            else if (MainWindow.leveldif_hard != false)
            {

                word = HardWords[ran.Next(0, HardWords.Length)];
               
            }

            return word;


        }
 

    }
}
