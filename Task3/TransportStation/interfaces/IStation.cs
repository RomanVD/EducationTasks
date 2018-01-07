using System.Collections.Generic;

namespace Task3.TransportStation.interfaces
{
    public interface IStation
    {
        void SetPeople(ITransport transport, List<IHunam> people);

        List<IHunam> GetPople(ITransport transport);
    }
}