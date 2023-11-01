using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Worker : IWorker
    {
        public string Name { get; set; }

        public Worker(string name)
        {
            Name = name;
        }

        public void Work(IPart part)
        {
            part.Build();
        }
    }
}
