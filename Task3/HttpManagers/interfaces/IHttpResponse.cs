namespace Task3.HttpManagers.interfaces
{
    public interface IHttpResponse
    {
        void SetResponse(IHttpBody body, IHttpHeader[] headers);
    }
}