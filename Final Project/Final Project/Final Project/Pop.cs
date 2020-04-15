using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Final_Project
{
    public class Pop : Music
    {

        public string Name
        {
            get;
        }

        public override void Speak()
        {
            MessageBox.Show("Hee-hee");
        }

        public Pop() { }

        public Pop(string lyrics, string name)
        {
            this.Lyrics = lyrics;
            this.Name = name;
        }
    }
}