using System.ComponentModel;
using System.Numerics;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_1
{
    internal class Program
    {
        class Book
        {
            public string Title { get; set; }
            public int Pages { get; set; }


            public override string ToString()
            {
                return $"title: {Title}, pages: {Pages}";
            }

            public override bool Equals(object? obj)
            {
                Book b2 = (Book)obj;
                return this.Title == b2.Title && this.Pages == b2.Pages;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Title, Pages);
            }

        }
        static void Main(string[] args)
        {


            #region Question1
            ////1. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it
            ////in a variable of type object.Print it.

            //Book b1 = new Book();
            //object obj = b1;
            //Console.WriteLine(obj);

            #endregion



            #region Question2
            //// 2.Using the Book class above, print the result of calling ToString(), Equals() (compare book
            ////with itself), GetHashCode(), and GetType() on book.

            //Book b2 = new Book();
            //b2.Title = "The great man";
            //b2.Pages = 300;

            //Console.WriteLine(b2.ToString());
            //Console.WriteLine(b2.Equals(b2));
            //Console.WriteLine(b2.GetHashCode());
            //Console.WriteLine(b2.GetType());

            #endregion



            #region Question3
            //// Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
            ////int pages = "464";

            ////          the solution:  it is a compile - time error     and we fix it as
            //int pages = 464;

            #endregion



            #region Question4
            //// Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot
            ////divide by zero", and then prints "Done" in a finally block.

            //try
            //{
            //    int num = 10;
            //    int result = num / 0;

            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}

            #endregion



            #region Question5
            ////Declare an int pages = 300; then store it in a double variable without using a cast.

            //int pages = 300;
            //double newPages = pages;

            #endregion

        }
    }
}