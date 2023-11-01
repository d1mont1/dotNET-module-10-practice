using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Door : IPart
    {
        public bool IsBuilt { get; set; }

        public Door()
        {
            IsBuilt = false;
        }

        public void Build()
        {
            IsBuilt = true;
            Console.WriteLine("Дверь построена.");
        }
    }
}
