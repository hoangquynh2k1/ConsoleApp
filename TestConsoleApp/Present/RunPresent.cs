using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MyConsoleApp.Present
{
    public class RunPresent
    {
        public static void Run()
        {
            ThreadTest.Run();
        }
        interface IMammal
        {
            void GiveBirth();
        }
        public interface IWingedAnimal
        {
            void Fly();
        }

        class Bat : IMammal, IWingedAnimal
        {
            void IWingedAnimal.Fly()
            {

            }

            void IMammal.GiveBirth()
            {

            }

            //Good
            //public async Task<string> GetNameAsync()
            //{
            //    string a = "";

            //    //Good
            //    var firstName = string.Empty;

            //    //Bad
            //    var secondName = "";


            //    string s = await Console.ReadLine();
            //    return a;


            //}
        }

        public class Product
        {
            public int Id { get; set; }

            [Required]
            [StringLength(10)]
            public string Name { get; set; }

            [Required]
            public string Description { get; set; }

            [DisplayName("Price")]
            public decimal UnitPrice { get; set; }
        }
    }
}
