using Task3.HttpManagers.interfaces;

namespace Task3.HttpManagers.classes
{
    class HttpResponse : IHttpResponse
    {
        private IHttpBody _body;
        private IHttpHeader[] _headers;
        public void SetResponse(IHttpBody body, IHttpHeader[] headers)
        {
            _body = body;
            _headers = headers;
        }
    }
}
