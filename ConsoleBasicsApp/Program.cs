using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleBasicsApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ascending sorting from 1-100
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine("----------------------------------------------");


            //Descending sorting from 100-1
            for (int j = 100; j > 0; j--)
            {
                Console.WriteLine(j);
            }


            Console.WriteLine("------------------------------------");


            //Call Sum method with parameter
            Console.WriteLine(Sum(5));



            Console.WriteLine("-----------------");


            Console.WriteLine(Sum_A(5));



            Console.WriteLine("----------------------------");
            Console.WriteLine(Sum_B(5));

        }

        //Sum Method with int n parameter
        public static int Sum(int n)
        {
            int sum = 0;

            for (int number = 0; number <= n; number++)
            {
                sum = sum + number;
            }
            return sum;
        }


        public static int Sum_A(int n)
        {
            int sum = 0;
            int num = 1;

            while (num<=n)
            {
                sum = sum + num;
                num++;
            }
            
            
            
            return sum;

        }



        public static int Sum_B(int n)
        {
            List<int> numbList = new List<int>();
            for (int number = 0; number <= n; number++)
            {
                numbList.Add(number);

                
            }

            int sum = numbList.Sum();
            return sum;
        }
       
    }
}
