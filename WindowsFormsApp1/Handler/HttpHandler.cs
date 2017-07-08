using System;
using WindowsFormsApp1.Response;

namespace WindowsFormsApp1.Handler
{
    public class HttpHandler
    {
        public delegate void OnWebContentreturnedHandler(HttpResponseArgs e);
        public event EventHandler WebConentReturned;        
        
        public void Response(HttpResponseArgs data)
        {
            onWebContentReturned(data);
        }

        protected virtual void onWebContentReturned(HttpResponseArgs e) {
            EventHandler handler = WebConentReturned;
            if(handler != null)
            {
                handler(this, e);
            }
        }        
    }
}
