using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExceptionDemo
{
    class BookExceptionDemo
    {
        static void Main(string[] args)
        {
            Write("Enter the title please  ");
            string title = Convert.ToString(ReadLine());
            Write("What is the price of the book?   ");
            double priceBook = Convert.ToDouble(ReadLine());
            Write("How many pages are in your book?   ");
            double pricePage = Convert.ToDouble(ReadLine());
            double pagePrice = 0;
            try
            {
                BookException.bookName = title;
                BookException.priceBook = priceBook;
                BookException.pricePage = pricePage;
                BookException.PagePrice(pagePrice);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
       
        }
    }


    class BookException : Exception
    {
    public static double priceBook { get; set; }
    public static double pricePage { get; set; }
    public static string bookName { get; set; }
    private static string msg = "Your price pre page exceeds .10 cents";

        public BookException() : base(msg)
            {
            WriteLine(msg + "for {0}", bookName);
            }

        public static double PagePrice(double pagePrice)
        {
            pagePrice = priceBook / pricePage;
            if (pagePrice < .10)
            {
                WriteLine("{0} has a page price of {1}", bookName, pagePrice);

            }
            else
            {
                WriteLine(msg);
            }
            
            return pagePrice;
        }
    }
    
    class Book
    {

    }

}
