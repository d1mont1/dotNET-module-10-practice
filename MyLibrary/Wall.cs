using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Wall : IPart
    {
        public bool IsBuilt { get; set; }

        public Wall()
        {
            IsBuilt = false;
        }

        public void Build()
        {
            IsBuilt = true;
            Console.WriteLine("Стена построена.");
        }
    }
}
