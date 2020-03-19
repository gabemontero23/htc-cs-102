using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceIntro
{
    class Tree : Organism
    {
        public string Brown_Trunk;
        public string Green_Leaves;
        public string Photosynthesis;

        public Tree() { }

        public Tree(string trunk, string color, string process)
        {
            this.Brown_Trunk = trunk;
            this.Green_Leaves = color;
            this.Photosynthesis = process;
        }
    }
}
