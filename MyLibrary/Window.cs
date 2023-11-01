using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Window : IPart
    {
        public bool IsBuilt { get; set; }

        public Window()
        {
            IsBuilt = false;
        }

        public void Build()
        {
            IsBuilt = true;
            Console.WriteLine("Окно построено.");
        }
    }
}
