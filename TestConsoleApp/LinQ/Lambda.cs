using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.LinQ
{
    public class Lambda
    {
        public static void Run()
        {
            var square = (int x) => x * x;
            //Console.WriteLine(square(5));

            var Sum = (int a, int b) => a + b;
            //Console.WriteLine(Sum(5,9));

            List<int> numbers = Enumerable.Range(1, 10).ToList();

            //Parallel.ForEach(numbers, num =>
            //{
            //    // Xử lý song song dựa trên giá trị num
            //    Console.WriteLine(num * 2);
            //});

            //var result = numbers.AsParallel()
            //      .Where(num => num % 2 == 0)
            //      .Select(num => num * 2)
            //      .ToList();

            int magicNum = 20;
            Func<int, int> MulByMagic = i => i * magicNum;
            Console.WriteLine(MulByMagic(10));
            var AddOne = () =>
            {
                magicNum++;
                Console.WriteLine(magicNum);
            };
            AddOne();
            Console.WriteLine(magicNum);
        }
    }
}
