using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.LinQ
{
    public class Delegate
    {
        

        public static void DogHello(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello " + name + "! I am a Dog");
        }

        public static void CatHello(string name)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello " + name + "! I am a Cat");
        }

        public delegate string Speak();

        public static string DogSpeak()
        {
            return "Woo Woo";
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static string CatSpeak()
        {
            return "Meo Meo";
        }

        public static void Run()
        {
            Speak speak = DogSpeak;
            //Console.WriteLine(speak.Invoke());
            //Console.WriteLine(speak());


            Action<string> action = DogHello;
            ////action += CatHello;
            //action("Kaopiz");

            Func<string> func = DogSpeak;
            Console.WriteLine(func.Invoke());

            Func<int, int, int> Calc = Sum;
            Console.WriteLine(Calc(1,4));
        }
    }
}
