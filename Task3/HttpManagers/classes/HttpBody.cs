using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.HttpManagers.interfaces;

namespace Task3.HttpManagers.classes
{
    class HttpBody : IHttpBody
    {
        public HttpBody(string type, string body)
        {
            Type = type;
            Body = body;
        }
        public string Type { get; }
        public string Body { get; }
    }
}
