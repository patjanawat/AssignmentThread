using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Contant;

namespace WindowsFormsApp1.Response
{
    public class HttpResponseArgs : EventArgs
    {
        public string httpBody { get; set; }
        public int ResponseCode { get; set; }
        public ElementConstant ELConstant { get; set; }
    }
}
