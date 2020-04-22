using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Final_Project
{
    public class Rock : Music
    {

        public string Name
        {
            get;
        }

        public override void Speak()
        {
            MessageBox.Show("Are you ready to rock?!");
        }

        public Rock() { }

        public Rock(string lyrics, string name, string type, string composed_by, int year_released)
        {
            this.Lyrics = lyrics;
            this.Name = name;
            this.Type = type;
            this.Composed_by = composed_by;
            this.Year_Released = year_released;
        }
    }
}