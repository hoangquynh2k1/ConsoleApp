//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit;
//using NUnit.Framework;

//namespace MyConsoleApp
//{
//    [TestFixture]
//    public class CheckPrimeNumberTest
//    {
//        [Test]
//        public void NumberLessThanTwoTest()
//        {
//            //Arrange
//            int number = 1;

//            //Act
//            var actual = NumberFunc.CheckPrimeNumber(number);

//            //Assert
//            Assert.IsFalse(actual);
//        }

//        [Test]
//        public void NumberEqualTwoTest()
//        {
//            var actual = NumberFunc.CheckPrimeNumber(2);
//            Assert.IsTrue(actual);
//        }

//        [Test]
//        public void NumberIsNotPrimeTest()
//        {
//            var actual = NumberFunc.CheckPrimeNumber(6);
//            Assert.IsFalse(actual);
//        }

//        [Test]
//        public void NumberIsPrimeTest()
//        {
//            var actual = NumberFunc.CheckPrimeNumber(7);
//            Assert.That(actual, Is.EqualTo(true));
//        }
//    }

//    [TestFixture]
//    public class ClassTest
//    {
//        [Test]
//        public void Test0()
//        {
//            int id = 1;

//            var target = new OrderController();
//            var actual = target.Get(id);

//            Assert.That(actual, Is.EqualTo(10));
//        }
//        [Test]
//        public void Test1() { }
//        [Test]
//        public void Test2() { }
//    }
//    public class NumberFunc
//    {
//        public static bool CheckPrimeNumber(int num)
//        {
//            if (num < 2)
//            {
//                return false;
//            }
//            else if (num == 2)
//            {
//                return true;
//            }
//            else
//            {
//                for (int i = 2; i < num; i++)
//                {
//                    if (num % i == 0)
//                    {
//                        return false;
//                    }
//                }
//                return true;
//            }
//        }
//    }
//    public class OrderController
//    {
//        private static readonly List<Order> orders = new List<Order>
//        {
//            new Order { Id = 1, CustomerId = 1 },
//            new Order { Id = 2, CustomerId = 2 },
//        };
//        private static readonly List<OrderDetail> orderDetails = new List<OrderDetail>
//        {
//            new OrderDetail { Id = 1, OrderId = 1, ProductId = 1, Price = 100 },
//            new OrderDetail { Id = 2, OrderId = 1, ProductId = 1, Price = 200 },
//            new OrderDetail { Id = 2, OrderId = 2, ProductId = 1, Price = 150 },
//            new OrderDetail { Id = 2, OrderId = 2, ProductId = 1, Price = 300 },
//        };

//        public int Get(int id)
//        {
//            int sum = 0;
//            List<OrderDetail> details = orderDetails.FindAll(x => x.OrderId == id);
//            for (int i = 0; i < details.Count; i++)
//            {
//                sum += details[i].Price;
//            }
//            return sum;
//        }
//    }
//    public class OrderDetail
//    {
//        public int Id { get; set; }
//        public int OrderId { get; set; }
//        public int ProductId { get; set; }
//        public int Price { get; set; }
//    }
//    public class Order
//    {
//        public int Id { get; set; }
//        public int CustomerId { get; set; }
//        public DateTime OrderDate { get; set; }
//    }
//}
