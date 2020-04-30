using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Final_Project
{
    public class Music
    {
        internal object Remove;

        public string Name
        {
            get;
            set;
        }
        public string Lyrics
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public string Composed_by
        {
            get;
            set;
        }

        public int Year_Released
        {
            get;
            set;
        }

        public void SayLyrics()
        {
            MessageBox.Show(Lyrics);
        }

        public void ShowDetails()
        {
            string infoString = "Song Name: " + this.Name;
            infoString += "\nType: " + this.Type;
            infoString += "\nComposed by: " + this.Composed_by;
            infoString += "\nYear Released: " + this.Year_Released;
            MessageBox.Show(infoString);
        }

    }
}
