using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Roof : IPart
    {
        public bool IsBuilt { get; set; }

        public Roof()
        {
            IsBuilt = false;
        }

        public void Build()
        {
            IsBuilt = true;
            Console.WriteLine("Крыша построена.");
        }
    }
}
