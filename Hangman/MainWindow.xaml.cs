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

namespace Hangman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static bool leveldif_easey=false;

        public static bool leveldif_hard = false;

        public static int categorynumber=0;
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Rad_easy_Checked_1(object sender, RoutedEventArgs e)
        {
            leveldif_hard = false;
            leveldif_easey = true;
        }

        private void Rad_hard_Checked(object sender, RoutedEventArgs e)
        {
            leveldif_easey = false;
            leveldif_hard = true;
        }

        private void Btn_sport_Click(object sender, RoutedEventArgs e)
        {
           
            categorynumber = 1;

            GameWindow GameWindow= new GameWindow();

            GameWindow.Show();

            this.Close();
        }

        private void Btn_anim_Click(object sender, RoutedEventArgs e)
        {
            
            categorynumber = 2;

            GameWindow GameWindow = new GameWindow();

            GameWindow.Show();

            this.Close();
        }

        private void Btn_food_Click(object sender, RoutedEventArgs e)
        {
            categorynumber = 3;

            GameWindow GameWindow = new GameWindow();

            GameWindow.Show();

            this.Close();
        }

        private void Btn_cont_Click(object sender, RoutedEventArgs e)
        {
            categorynumber = 4;

            GameWindow GameWindow = new GameWindow();

            GameWindow.Show();

            this.Close();
        }
    }
}
