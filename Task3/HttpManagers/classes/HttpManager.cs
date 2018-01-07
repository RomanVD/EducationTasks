using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.HttpManagers.interfaces;

namespace Task3.HttpManagers.classes
{
    public class HttpManager :  IHttpManager
    {

        public HttpManager()
        {
            _history = new List<(IHttpRequest request, IHttpResponse response)>();
        }
        public IHttpResponse SendRequest(IHttpRequest request)
        {
            var response = new HttpResponse();
            _history.Add((request, response));

            return response;
        }

        public List<(IHttpRequest request, IHttpResponse response)> GetHiostory()
        {
            return _history;
        }

        private List<(IHttpRequest request, IHttpResponse response)> _history;
    }
}
