using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.HttpManagers.interfaces;

namespace Task3.HttpManagers.classes
{
    class HttpHeader : IHttpHeader
    {
        public HttpHeader(string name, string value)
        {
            Value = value;
            Name = name;
        }
        public string Name { get; }
        public string Value { get; }
    }
}
