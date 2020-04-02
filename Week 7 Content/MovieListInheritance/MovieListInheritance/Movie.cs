using System.Windows;

namespace MovieList
{
    public class AnimatedMovie
    {
        public string Title
        {
            get;
            set;
        }

        public int ReleaseYear
        {
            get;
            set;
        }

        public virtual void ShowDetails()
        {
            string infoString = "Title: " + this.Title;
            infoString += "\nRelease Year: " + this.ReleaseYear;
            MessageBox.Show(infoString);
        }

        public AnimatedMovie() { }

        public AnimatedMovie(string myTitle, int myReleaseYear)
        {
            this.Title = myTitle;
            this.ReleaseYear = myReleaseYear;
        }
    }
}
