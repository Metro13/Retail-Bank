using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Bank
{
    internal class Savings_Account:Account
    {
        private double accountThreshold;
        private double interestRate;
        private string openingDate;
        private bool eligiblePeriod;
        private int transactionLimit;

        public double AccountThreshold
        {
            set
            {
                accountThreshold = value;   
            }
            get
            {
                return accountThreshold;
            }
        }
        public double InterestRate
        {
            set
            {
                interestRate = value;   
            }
            get { return interestRate; }    
        }

        public string OpeningDate
        {
            set { openingDate = value; }
            get
            {
                return openingDate;
            }
        }

        public int TransactionLimit
        {
            set
            {
                transactionLimit = value;
            }
            get
            {
                return transactionLimit;
            }
        }

        public bool IsEligiblePeriod
        {
            set => eligiblePeriod = value;
            get => eligiblePeriod;  
        }

        public void DepositInterest()
        {
           

        }
        public void CalculateInterest()
        {
            
        }
    }
}
