using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Bank
{
    internal class Payee:User
    {
        private string payeeName;
        
        public string PayeeName
        {
            set { payeeName = value; }
            get { return payeeName; }
        }

        public bool VerifyPayee()
        {
            return true;
           
        }

    }
}
