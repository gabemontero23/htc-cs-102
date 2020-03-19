using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Cat : Animal
    {
        private bool IsSpotted;
        public void Meow()
        {
            MessageBox.Show("Meow");
        }

        public Cat()
        {

        }

        public Cat(int height, string name, bool isSpotted)
        {
            Height = height;
            Name = name;
            IsSpotted = isSpotted;

        }

    }
}
