using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class TeamLeader : IWorker
    {
        public string Name { get; set; }

        public TeamLeader(string name)
        {
            Name = name;
        }

        public void Work(IPart part)
        {
            Console.WriteLine($"Бригадир проверяет, что {part.GetType().Name} уже построено.");
        }
    }
}
