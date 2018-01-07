using System.Collections.Generic;

namespace Task3.TransportStation.interfaces
{
    public interface ITransport
    {
        void SetPeople(List<IHunam> hunam);
        List<IHunam> GetPeople();
    }
}