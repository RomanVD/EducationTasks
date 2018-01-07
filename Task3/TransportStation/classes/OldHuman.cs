using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.TransportStation.interfaces;

namespace Task3.TransportStation.classes
{
    class OldHuman : IHunam
    {
        public string Name { get; set; }
        public bool IsMale { get; set; }
        public int Age { get; set; }
        public string Descritpion { get; set; }
    }
}
