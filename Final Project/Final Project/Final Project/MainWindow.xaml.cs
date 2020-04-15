using Final_Project;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Final_Project
{

    public partial class MainWindow : Window
    {
        public ObservableCollection <Music> Music;

        public MainWindow()
        {
            InitializeComponent();
            Music = new ObservableCollection<Music>();

            // Define some songs
            Country country = new Country("Country roads, take me home, To the place, I belong, West Virginia, mountain mama, Take me home, country roads", "Country Roads");
            Pop pop = new Pop("Huh, because I'm happy, Clap along if you feel like a room without a roof, Because I'm happy, Clap along if you feel like happiness is the truth", "Happy");

            // Add the songs to the list
            Music.Add(country);


            lvSongs.ItemsSource = Songs;
        }

        private void lvAnimals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Animal selectedAnimal = lvAnimals.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                selectedAnimal.Speak();
            }
        }

        private void SayLyrics_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Song a in Songs)
            {
                a.SayName();
            }
        }
    }
}
