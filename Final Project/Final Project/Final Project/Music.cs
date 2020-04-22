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

        public virtual void Speak()
        {
            // Do nothing if the song is not specific
        }
    }
}
