using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace taskOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            //
            int s1 = 10;
            double s2 = 2.55;
            string s3 = "Yazeed";
            float s4 = 4.6f;
            bool s5 = false;
            char s6 = 'a';
            const int s7 = 5;

            Console.WriteLine($"The output {s1} {s2} {s3} {s4} {s5} {s6} {s7}");

            string[] cars = { "ford", "bmw", "toyota" };

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            for (int i = 0; i < cars.Length; i++)
            {

                Console.WriteLine(cars[i]);
            }
            Console.WriteLine("Input your firstname");
            string fname = Console.ReadLine();

            Console.WriteLine("Input your lastname");
            string surname = Console.ReadLine();

            Console.WriteLine("Input your year of birth");
            string birth = Console.ReadLine();

            Console.WriteLine(fname + " " + surname + " " + birth);

            Console.WriteLine("Enter length of array");
            int len1 = int.Parse(Console.ReadLine());
            int[] arr = new int[len1];


            for (int i = 0; i < len1; i++)
            {
                Console.WriteLine($"enter element arr num {i} ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < len1; i++)
            {

                Console.WriteLine($"element {i} = {arr[i]}");
            }

            Console.WriteLine("Enter length of array");
            int len2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[len2];


            for (int i = 0; i < len2; i++)
            {
                Console.WriteLine($"enter element arr num {i} ");
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < len2; i++)
            {
                sum += arr2[i];

            }

            Console.WriteLine(sum);





        }

    }
}
