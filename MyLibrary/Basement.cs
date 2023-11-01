using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Basement : IPart
    {
        public bool IsBuilt { get; set; }

        public Basement()
        {
            IsBuilt = false;
        }

        public void Build()
        {
            IsBuilt = true;
            Console.WriteLine("Фундамент построен.");
        }
    }
}
