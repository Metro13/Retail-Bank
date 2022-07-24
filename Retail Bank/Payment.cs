using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Bank
{
    internal class Payment
    {
        private string paymentReference;
        private string paymentType;
        private double amount;

        public Payment(string paymentReference, string paymentType, double amount)
        {
            PaymentReference = paymentReference;
            PaymentType = paymentType;
            Amount = amount;
        }

        public Payment()
        {

        }

        public string PaymentReference
        {
            set { paymentReference = value; }
            get { return paymentReference; }
        }
        public string PaymentType
        {
            set { paymentType = value; }
            get { return paymentType; }
        }
        public double Amount
        {
            set { amount = value; }
            get
            {
                return amount;
            }
        }
        public void VerifyPayment()
        {

        }

        public void ProcessPayment(Payment payment)
        {
            
        }

    }
}
