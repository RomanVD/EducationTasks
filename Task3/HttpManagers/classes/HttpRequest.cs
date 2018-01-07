using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.HttpManagers.interfaces;

namespace Task3.HttpManagers.classes
{
    class HttpRequest : IHttpRequest
    {
        private IHttpBody _body;
        private IHttpHeader[] _headers;

        public void SetRequest(IHttpBody body, IHttpHeader[] headers)
        {
            _body = body;
            _headers = headers;
        }
    }
}
