namespace Task3.HttpManagers.interfaces
{
    public interface IHttpRequest
    {
        void SetRequest(IHttpBody body, IHttpHeader[] headers);
    }
}