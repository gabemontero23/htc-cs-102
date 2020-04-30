using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Rap : Music
    {
        public Rap() { }

        public Rap(string name, string type, string composed_by, int year_released, string lyrics)
        {
            this.Name = name;
            this.Type = type;
            this.Composed_by = composed_by;
            this.Year_Released = year_released;
            this.Lyrics = lyrics;
        }
    }
}
