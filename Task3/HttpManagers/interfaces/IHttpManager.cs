using System.Collections.Generic;

namespace Task3.HttpManagers.interfaces
{
    public interface IHttpManager
    {
        IHttpResponse SendRequest(IHttpRequest request);

        List<(IHttpRequest request, IHttpResponse response)> GetHiostory();
    }
}