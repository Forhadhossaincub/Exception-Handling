using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("Software Development Day 01");

                Console.Write("Enter Your Name : ");
                string name = Console.ReadLine();

                Console.Write("Enter Your Age : ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Enter Your MontlySalary : ");
                decimal salary = decimal.Parse(Console.ReadLine());

                Console.WriteLine($" Your Name is:{name} . Your Age is :{age} . Your Montly Salary is :{salary} ");

                Console.ReadKey();


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }

    }
}

