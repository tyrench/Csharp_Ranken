using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLoanNew
{
    class Loan
    {
        public int LoanNumber { get; set; }
        public string LastName { get; set; }

        public const double MINIMUM_LOAN = 5000;
        protected double loanAmount;

        public double LoanAmount
        {
            set
            {
                if (value < MINIMUM_LOAN)
                    loanAmount = MINIMUM_LOAN;
                else
                    loanAmount = value;
            }
            get
            {
                return loanAmount;
            }
        }
        public Loan(int num, string name, double amount)
        {
            LoanNumber = num;
            LastName = name;
            LoanAmount = amount;
        }
    }
}
