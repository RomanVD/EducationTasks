using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.TransportStation.interfaces;

namespace Task3.TransportStation.classes
{
    class Station : IStation
    {
        public void SetPeople(ITransport transport, List<IHunam> people)
        {
            transport.SetPeople(people);
        }

        public List<IHunam> GetPople(ITransport transport)
        {
            return transport.GetPeople();
        }
    }
}
