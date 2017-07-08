using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.Request;
using WindowsFormsApp1.Handler;
using static WindowsFormsApp1.Handler.HttpHandler;

namespace UnitTestProject1
{
    [TestClass]
    public class RequestTest
    {
        readonly HttpHandler _httpHandle;
        IRequestService requestService;
        public RequestTest()
        {
            _httpHandle = new HttpHandler();
            _httpHandle.WebConentReturned   +=_httpHandle_WebConentReturned;
        }

        private void _httpHandle_WebConentReturned(object sender,EventArgs e)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [DataRow(@"http://www.google.co.th")]
        public void TestRequest(string url)
        {
            bool expected = true;

            requestService = new RequestService(url,_httpHandle, WindowsFormsApp1.Contant.ElementConstant.MessageResponse1);
            requestService.RequestAync();

            bool actual = true;
            
            Assert.AreEqual(expected, actual);
        }
    }
}
