using System;
using System.Collections.Generic;
using Task3.TransportStation.interfaces;

namespace Task3.TransportStation.classes
{
    class BigCar : ITransport
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
