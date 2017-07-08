using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmBlock : Form
    {
        public HttpWebRequest request;
        public frmBlock()
        {
            InitializeComponent();

            txtUrl1.Text = "http://www.google.co.th";
            txtUrl2.Text = "http://www.google.co.th";
        }

        private void button1_Click(object sender,EventArgs e)
        {
            string url1 = txtUrl1.Text;
            txtResponse1.Clear();

            string msg = Request(url1);
            txtResponse1.Text = msg;

        }

        private void btnGetcontent_Click(object sender,EventArgs e)
        {

            string url2 = txtUrl2.Text;
            txtResponse2.Clear();

            string msg = Request(url2);
            txtResponse2.Text = msg;
        }

        private string Request(string url)
        {
            string respMsg = string.Empty;

            request = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse httpResponse = (HttpWebResponse)request.GetResponse();
            
            var encoding = ASCIIEncoding.ASCII;

            using(var reader = new StreamReader(httpResponse.GetResponseStream(),encoding))
            {
                respMsg= reader.ReadToEnd();                
            }

            return respMsg;

        }

        private void btnClear1_Click(object sender,EventArgs e)
        {
            txtResponse1.Clear();
        }

        private void btnClear2_Click(object sender,EventArgs e)
        {
            txtResponse2.Clear();
        }
    }
}
