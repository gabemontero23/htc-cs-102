using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Final_Project
{
    class userMusic : Music
    {
        public userMusic(string mysongname, string mytype, string mycomposed_by, int myyearreleased, string mylyrics)
        {
            this.Name = mysongname;
            this.Type = mytype;
            this.Composed_by = mycomposed_by;
            this.Year_Released = myyearreleased;
            this.Lyrics = mylyrics;
        }

    }
}
