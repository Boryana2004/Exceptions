using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
             int a = int.Parse(Console.ReadLine());
                double b = Math.Sqrt(a);
                Console.WriteLine(b);
                if (b<0)
                {
                    throw new Exception();
                }
            }
            
            catch (FormatException)
            {
               Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
