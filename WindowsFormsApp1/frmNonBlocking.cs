using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Handler;
using WindowsFormsApp1.Request;
using WindowsFormsApp1.Response;

namespace WindowsFormsApp1
{
    public partial class frmNonBlocking : Form
    {
        HttpHandler myHandle;

        delegate void SetResponseCallback(TextBox el, string responseBody);
        
        public frmNonBlocking()
        {
            InitializeComponent();

            myHandle = new HttpHandler();
            myHandle.WebConentReturned +=MyHandle_WebConentReturned;
           

            //Initial URL.
            txtUrl1.Text = "http://www.google.co.th";
            txtUrl2.Text = "http://www.google.co.th";
        }

        private void SetResponseBody(TextBox el, string responseBody)
        {
            if(this.txtResponse1.InvokeRequired)
            {
                SetResponseCallback callback = new SetResponseCallback(SetResponseBody);
                this.Invoke(callback,new object[] { el,responseBody });
            } else
            {
                el.Text = responseBody;
            }
        }

        private void Requester1()
        {
             string url = txtUrl1.Text;
            if(string.IsNullOrEmpty(url))
            {
                SetResponseBody(txtResponse1,"Please enter a URL!");
                return;
            }

            RequestProcess(url,Contant.ElementConstant.MessageResponse1);
            SetResponseBody(txtResponse1,"Requesting...");
        }

        private void MyHandle_WebConentReturned(object sender,EventArgs e)
        {
            if(e==null)
            {
                txtResponse1.Clear();
                txtResponse2.Clear();
                return;
            }

            HttpResponseArgs resp = (HttpResponseArgs)e;
            switch(resp.ELConstant)
            {
                case Contant.ElementConstant.MessageResponse1:
                    SetResponseBody(txtResponse1,resp.httpBody);
                    break;
                case Contant.ElementConstant.MessageResponse2:
                    SetResponseBody(txtResponse2,resp.httpBody);
                    break;
            }
        }


        private void btnGetcontent_Click(object sender, EventArgs e)
        {
            Requester1();
            Requester2();
        }

        private void button1_Click(object sender,EventArgs e)
        {
            //Requester2();
        }

        private void Requester2()
        {
            string url = txtUrl2.Text;
            if(string.IsNullOrEmpty(url))
            {
                SetResponseBody(txtResponse2,"Please enter a URL!");
                return;
            }

            RequestProcess(url,Contant.ElementConstant.MessageResponse2);
            SetResponseBody(txtResponse2,"Requesting...");
        }

        private void btnClear1_Click(object sender,EventArgs e)
        {
            txtResponse1.Clear();
        }

        private void btnClear2_Click(object sender,EventArgs e)
        {
            txtResponse2.Clear();
        }

        public Task RequestProcess(string url, Contant.ElementConstant ResponseConstant)
        {
            return Task.Run(() => {
                new RequestService(url,myHandle,ResponseConstant).RequestAync();
            });                        
        }
    }
}
