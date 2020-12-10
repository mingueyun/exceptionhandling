using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numerals = new List<int> { 12, 7, 55, 33, 70, 50 };
                Console.WriteLine("pick a number");
                int numb = Convert.ToInt32(Console.ReadLine());

                for (int a = 0; a < numerals.Count; a++)
                {
                    var result1 = numerals[a] / numb;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;             
            }
            catch (DivideByZeroException )
            {
                Console.WriteLine("dont divide by zero");
            }
            finally
            {
                Console.WriteLine("It has emerged VICTORIOUSLY!.. WELL DONE!!!!. NOW PAY THE $9.99 FEE MINION!!!!!!" );
                
            }
            Console.ReadLine();

            //int[] numArray3 = { 10, 2, 10, 200, 5000 };

            //Console.WriteLine("pick a number");
            //int numb = Convert.ToInt32(Console.ReadLine());
            //foreach (var d in numArray3)
            //{
            //    var result = d / numb;
            //    Console.WriteLine("divide by " + numb + "  is " + result);
            //}
            //Console.ReadLine();

            // exception message that popped up
            //added whole numbers and it gave me whole numbers
            // added decimals and it gave me input was wrong format
            // added zero and it gave me wrong format
            //added string gave me wrong format



            //try
            //{
            //    Console.WriteLine("pick a number");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("pick a  second number");
            //    int numberOneTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two....");
            //    int numberThree = numberOne / numberOneTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberOneTwo + " equals " + numberThree);
            //    Console.ReadLine();

            //}
            //catch (FormatException ex)
            //{
            //    //Console.WriteLine(ex.Message);
            //    Console.WriteLine("please type a whole numnber");
            //    return;
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("dont divide by zero");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}


        }
    }
}
