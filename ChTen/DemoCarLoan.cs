using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLoanNew
{
    class DemoCarLoan
    {
        static void Main(string[] args)
        {
            Loan aLoan = new Loan(333, "Hanson", 7000.00);
            CarLoan aCarLoan = new CarLoan(444, "Carlisile", 30000.00, 2011, "BMW");

            WriteLine("Loan #{0} for {1} is for {2}", aLoan.LoanNumber, aLoan.LastName, aLoan.LoanAmount.ToString("C2"));
            WriteLine("Loan #{0} for {1} is for {2}", aCarLoan.LoanNumber, aCarLoan.LastName, aCarLoan.LoanAmount.ToString("C2"));
            WriteLine("   Loan #{0} is for a {1} {2}", aCarLoan.LoanNumber, aCarLoan.Year, aCarLoan.Make);
        }
    }
}