using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class House
    {
        public List<IPart> Parts { get; set; }

        public House()
        {
            Parts = new List<IPart>();
        }

        public void AddPart(IPart part)
        {
            Parts.Add(part);
        }

        public bool IsBuilt()
        {
            return Parts.TrueForAll(part => part.IsBuilt);
        }
    }
}
