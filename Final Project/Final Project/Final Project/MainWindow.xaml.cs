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
        public ObservableCollection <Music> MusicList;

        public MainWindow()
        {
            InitializeComponent();
            MusicList = new ObservableCollection<Music>();

            // Define some songs
            Music pop = new Pop("Happy", "Pop", "Pharrell Williams", 2013, "Huh, because I'm happy Clap along if you feel like a room without a roof Because I'm happy Clap along if you feel like happiness is the truth");
            Music rock = new Rock("Bohemian Rhapsody", "Rock", "Queen", 1975, "Country roads, take me home To the place I belong West Virginia, mountain mama Take me home, country roads");
            Music country = new Country("Country Roads", "Country", "John Denver", 1971, "Country roads, take me home To the place I belong West Virginia, mountain mama Take me home, country roads");
            Music rap = new Rap("Lose Yourself", "Rap", "Eminem", 2002, "Yo His palms are sweaty, knees weak, arms are heavy There's vomit on his sweater already, mom's spaghetti He's nervous, but on the surface he looks calm and ready To drop bombs, but he keeps on forgettin'");
            Music disco = new Disco("September", "Disco", "Earth, Wind & Fire", 1978, "Hey hey hey Ba de ya, say do you remember Ba de ya, dancing in September Ba de ya, never was a cloudy day");

            // Add the songs to the list
            MusicList.Add(pop);
            MusicList.Add(rock);
            MusicList.Add(country);
            MusicList.Add(rap);
            MusicList.Add(disco);
            lvSongs.ItemsSource = MusicList;

        }


        private void lvSongs_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Music selectedSong = lvSongs.SelectedItem as Music;
            if (selectedSong != null)
            {
                selectedSong.ShowDetails();
            }
        }

        private void SayLyrics_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Music m in MusicList)
            {
                m.SayLyrics();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Music musicToAdd = new userMusic(songInput.Text, typeInput.Text, composerInput.Text, int.Parse(yearInput.Text), lyricsInput.Text);

            MusicList.Add(musicToAdd);

            songInput.Clear();
            typeInput.Clear();
            composerInput.Clear();
            yearInput.Clear();
            lyricsInput.Clear();
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Music m in MusicList)
            {
                m.ShowDetails();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Music musicToAdd = new userMusic(songInput.Text, typeInput.Text, composerInput.Text, int.Parse(yearInput.Text), lyricsInput.Text);
            MusicList.Remove(musicToAdd);

            songInput.Clear();
            typeInput.Clear();
            composerInput.Clear();
            yearInput.Clear();
            lyricsInput.Clear();
        }
    }
}
