using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            /*int a= int.Parse(Console.ReadLine());
              int b = int.Parse(Console.ReadLine());
              int sum = a + b;

              Console.WriteLine(sum);

            //задание2
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(a + "+" + b + "+" + c + "=" + c + "+" + b + "+" + a); 

            //Задание 3
            /* int a = int.Parse(Console.ReadLine());
             int b = int.Parse(Console.ReadLine());
             int c = int.Parse(Console.ReadLine());
             int sum = a + b + c;
             Console.WriteLine(sum); */

            //Задание 4
            /*double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double proiz = a * b ;
            Console.WriteLine(" {0:#.#} * {1:#.#} = {2:#.#}", a,b,proiz); */

            //задание 5
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double proiz = a / b;
            Console.WriteLine(" {0:#.###} / {1:#.###} = {2:#.###}", a, b, proiz);

            //Задание 6
            /*double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(" <{0:#.###} + {1:#.###}> + {2:#.###} = {0:#.###} + <{1:#.###} + {2:#.###}>", a, b, c);*/

        }
    }
}
