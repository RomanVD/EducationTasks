using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.TransportStation.interfaces;

namespace Task3.TransportStation.classes
{
    class Bus : ITransport
    {
        public void SetPeople(List<IHunam> hunam)
        {
            //sending logic
        }

        public List<IHunam> GetPeople()
        {
            List<IHunam> people = new List<IHunam>();

            //get people logic

            return people;
        }
    }
}
