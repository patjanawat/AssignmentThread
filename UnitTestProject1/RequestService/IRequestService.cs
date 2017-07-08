using System.Net;
using WindowsFormsApp1.Contant;
using WindowsFormsApp1.Response;

namespace WindowsFormsApp1.Request
{
    public interface IRequestService
    {        
        void RequestAync();
        void SetResponse(int statusCode,string httpBody,ElementConstant el);
        int GetResonseStatus(HttpStatusCode statusCode);
        void OnResponseHandler(HttpResponseArgs Model);
    }
}
