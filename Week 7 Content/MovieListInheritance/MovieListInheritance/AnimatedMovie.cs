using MovieList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieListInheritance
{
    class AnimatedMovie : MovieList.AnimatedMovie
    {
        public string AnimationStudio
        {
            get;
            set;
        }
        public string AnimationType
        {
            get;
            set;
        }

        public AnimatedMovie(string Title, int ReleaseYear, string AnimationStudio, string AnimationType)
        {
            
        }
        public override void ShowDetails()
        {
            string infoString = "Title: " + this.Title;
            infoString += "\nRelease Year: " + this.ReleaseYear;
            MessageBox.Show(infoString);
        }
    }
}
