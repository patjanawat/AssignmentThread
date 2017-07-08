using System;
using System.IO;
using System.Net;
using System.Text;
using WindowsFormsApp1.Contant;
using WindowsFormsApp1.Handler;
using WindowsFormsApp1.Response;

namespace WindowsFormsApp1.Request
{
    public class RequestService: IRequestService
    {
        HttpWebRequest request;  //request instant.

        readonly HttpHandler responseEvent;        //inject event to constructor.       
        string Url;                                      //inject url to constructor.
        readonly ElementConstant ELConstant;        //inject enum to constructor.

        public RequestService(string _url,HttpHandler _responseEvent,ElementConstant _elConstant)
        {
            Url = _url;
            responseEvent = _responseEvent;
            ELConstant = _elConstant;

        }

        public void RequestAync()
        {
            HttpResponseArgs Model = new HttpResponseArgs();

            #region Comment
            try
            {
                if(!Url.Contains("http://"))
                {
                    Url = Url.Insert(0,"http://");
                }
                request = WebRequest.Create(Url) as HttpWebRequest;
                HttpWebResponse httpResponse = (HttpWebResponse)request.GetResponse();

                var encoding = Encoding.ASCII;

                using(var reader = new StreamReader(httpResponse.GetResponseStream(),encoding))
                {
                    int statusCode = GetResonseStatus(httpResponse.StatusCode);
                    string responseBody = reader.ReadToEnd();

                    SetResponse(statusCode,responseBody,ELConstant);
                }
            } 
            catch(WebException ex)
            {
                int statusCodeDefault = 500;
                if(ex.Response==null)
                {
                    statusCodeDefault = 500;
                } else
                {
                    var statusCode = ((HttpWebResponse)ex?.Response).StatusCode;
                    statusCodeDefault = GetResonseStatus(statusCode);
                }
                              
                SetResponse(500,"An error occurred, status code: " + statusCodeDefault,ELConstant);
                
            }
            catch(Exception ex)
            {                
                SetResponse(500,"An error occurred, status code: " + 500,ELConstant);
            }
            #endregion

            #region Asynchronous Logic
            //var resp = await request.GetResponseAsync();
            //using(var stream = new StreamReader(resp.GetResponseStream(),true))
            //{
            //    Model.httpBody=  stream.ReadToEnd();
            //    Model.ResponseCode = 200;
            //    Model.ELConstant =ELConstant;

            //    responseEvent.Response(Model);
            //}

            #endregion

        }

        public void SetResponse(int statusCode, string httpBody,ElementConstant el )
        {
            HttpResponseArgs Model = new HttpResponseArgs();

            Model.ResponseCode = statusCode;
            Model.httpBody= httpBody;
            Model.ELConstant =el;

            OnResponseHandler(Model);
        }

        public void OnResponseHandler(HttpResponseArgs Model)
        {
            responseEvent.Response(Model);
        }

        public int GetResonseStatus(HttpStatusCode statusCode)
        {
            switch (statusCode)
            {               
                case HttpStatusCode.OK:
                    return 200;                                             
                case HttpStatusCode.NoContent:
                    return 204;
                case HttpStatusCode.BadRequest:
                    return 400;              
                case HttpStatusCode.NotFound:
                    return 404;                           
                case HttpStatusCode.RequestTimeout:
                    return 408;                      
                case HttpStatusCode.InternalServerError:
                    return 500;
                case HttpStatusCode.BadGateway:
                    return 502;
                case HttpStatusCode.Unauthorized:
                case HttpStatusCode.PaymentRequired:
                case HttpStatusCode.Forbidden:
                case HttpStatusCode.MethodNotAllowed:
                case HttpStatusCode.NotAcceptable:
                case HttpStatusCode.ProxyAuthenticationRequired:
                case HttpStatusCode.Conflict:
                case HttpStatusCode.Gone:
                case HttpStatusCode.LengthRequired:
                case HttpStatusCode.PreconditionFailed:
                case HttpStatusCode.RequestEntityTooLarge:
                case HttpStatusCode.RequestUriTooLong:
                case HttpStatusCode.UnsupportedMediaType:
                case HttpStatusCode.RequestedRangeNotSatisfiable:
                case HttpStatusCode.ExpectationFailed:
                case HttpStatusCode.UpgradeRequired:
                case HttpStatusCode.ResetContent:
                case HttpStatusCode.PartialContent:
                case HttpStatusCode.MultipleChoices:
                case HttpStatusCode.MovedPermanently:
                case HttpStatusCode.SeeOther:                
                case HttpStatusCode.NotModified:
                case HttpStatusCode.UseProxy:
                case HttpStatusCode.Unused:
                case HttpStatusCode.TemporaryRedirect:
                case HttpStatusCode.ServiceUnavailable:
                case HttpStatusCode.GatewayTimeout:
                case HttpStatusCode.HttpVersionNotSupported:
                default:                    
                case HttpStatusCode.NotImplemented:
                    return 501;                                 
            }
        }                
    }
}
