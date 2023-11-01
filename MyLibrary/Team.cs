using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Team
    {
        private List<IWorker> workers;

        public Team()
        {
            workers = new List<IWorker>();
        }

        public void AddWorker(IWorker worker)
        {
            workers.Add(worker);
        }

        public void BuildHouse(House house)
        {
            Console.WriteLine("Бригада начинает строительство дома.");

            foreach (var part in house.Parts)
            {
                foreach (var worker in workers)
                {
                    worker.Work(part);
                }
            }

            Console.WriteLine("Строительство дома завершено.");
        }
    }
}
