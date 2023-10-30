using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.LinQ
{
    public class Product
    {
        #region CÁC THUỘC TÍNH SẢN PHẨM
        public int ID { set; get; }
        public string Name { set; get; }         // tên
        public double Price { set; get; }        // giá
        public string[] Colors { set; get; }     // cá màu 
        public int Brand { set; get; }           // Nhãn hiệu, hãng
        #endregion

        public Product(int id, string name, double price,
            string[] colors, int brand)
        {
            ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
        }
        // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
        override public string ToString() => $"ID {ID} - {Name}, giá {Price}";



    }

    public class Products
    {
        // thành viên biến tĩnh, là danh sách sản phẩm
        public static List<Product> products;

        // Hàm khởi tạo thành viên tĩnh
        static Products()
        {
            // Khởi tạo products với 7 sản phẩm mẫu
            products = new List<Product>()
            {
                new Product(1, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(2, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(3, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(4, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(5, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };
        }

        // In ra các sản phẩm có giá 400
        public static void ProductPrice500()
        {
            var products = Products.products;
            var ketqua = from product in products
                         where product.Price == 400
                         select product;

            foreach (var product in ketqua)
                Console.WriteLine(product.ToString());
            // In ra    
            // ID 3 - Bàn trà, giá 400
            // ID 4 - Tranh treo, giá 400
        }

       
    }

    public class LinQ
    {
        public static void Run()
        {
            var products = Products.products;
            var brands = Brand.Brands;

            #region truy vấn cơ bản

            var QueryResult = from product in products
                         where product.Price == 400
                         select product;
            var MethodResult = products.Where(_ => _.Price == 400);

            Console.WriteLine("Các sản phẩm giá 400:");
            Console.WriteLine("QueryResult");
            foreach (var product in QueryResult)
                Console.WriteLine(product.ToString());

            Console.WriteLine("MethodResult");
            foreach (var product in MethodResult)
                Console.WriteLine(product.ToString());
            
            Console.WriteLine();
            #endregion

            #region tạo đối tượng vô danh kết quả trả về

            //var ketqua1 = from product in products
            //              where product.Price == 400
            //              //select new 
            //              //{
            //              //    Ten = product.Name,
            //              //    Mausac = string.Join(',', product.Colors)
            //              //};
            //              select new ProductShow(product.Name, string.Join(',', product.Colors));
            //Console.WriteLine("Tên, màu sắc sản phẩm có giá 400");
            //foreach (var item in ketqua1) Console.WriteLine(item.Ten + " - " + item.MauSac);
            //Console.WriteLine();
            #endregion

            #region lọc dữ liệu bằng where
            //var ketqua2 = from product in products
            //              where product.Price >= 500
            //              //where product.Name.StartsWith("Giường")
            //              where product.Colors.Contains("Trắng")
            //              select product;
            //Console.WriteLine("Sản phẩm có tên bắt đầu là Giường, giá trên 500");
            //foreach (var product in ketqua2)
            //    Console.WriteLine(product.ToString());
            //Console.WriteLine();
            #endregion

            #region sử dụng from kết hợp để lọc
            //var ketqua3 = from product in products
            //              from color in product.Colors
            //              where product.Price < 500
            //              where color == "Vàng"
            //              select product;
            //Console.WriteLine("Sản phẩm có màu Vàng, giá dưới 500");
            //foreach (var product in ketqua3) Console.WriteLine(product.ToString());
            //Console.WriteLine();
            #endregion

            #region Sắp xếp bằng orderby
            //var ketqua4 = from product in products
            //              where product.Price <= 600
            //              orderby product.Price descending
            //              select product;

            //Console.WriteLine("Sản phẩm giá nhỏ hơn bằng 300, sắp xếp theo giá giảm dần");
            //foreach (var product in ketqua4) Console.WriteLine($"{product.Name} - {product.Price}");
            //Console.WriteLine();
            #endregion

            #region Nhóm kết quả bằng group
            //var ketqua5 = from product in products
            //              where product.Price >= 400 && product.Price <= 500
            //              group product by product.Price;

            //Console.WriteLine("Các sản phẩm nhóm theo giá 400, 500");
            //foreach (var group in ketqua5)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"    {product.Name} - {product.Price}");
            //    }

            //}
            //Console.WriteLine();
            #endregion

            #region dùng biến trong truy vấn
            //var ketqua6 = from product in products
            //              group product by product.Price into gr
            //              let count = gr.Count()
            //              select new
            //              {
            //                  price = gr.Key,
            //                  number_product = count
            //              };
            //Console.WriteLine("Số sản phẩm theo giá");
            //foreach (var item in ketqua6)
            //{
            //    Console.WriteLine($"   Giá {item.price} - có {item.number_product} sp");
            //}
            //var a = (int x, int y) => {
            //    return x + y;
            //};
            //Console.WriteLine(a.Invoke(1, 2));
            #endregion

            #region inner join
            //var ketqua7 = from product in products
            //              join brand in brands on product.Brand equals brand.ID
            //              select new
            //              {
            //                  name = product.Name,
            //                  brand = brand.Name,
            //                  price = product.Price
            //              };

            //Console.WriteLine("Sản phẩm - giá - tên hãng");
            //foreach (var item in ketqua7)
            //{
            //    Console.WriteLine($"{item.name,10} {item.price,4} {item.brand,12}");
            //}
            //Console.WriteLine();
            #endregion

            #region left join
            //var ketqua8 = from product in products
            //              join brand in brands on product.Brand equals brand.ID into t
            //              from brand in t.DefaultIfEmpty()
            //              select new
            //              {
            //                  name = product.Name,
            //                  brand = (brand == null) ? "NO-BRAND" : brand.Name,
            //                  price = product.Price
            //              };
            //Console.WriteLine("Sản phẩm - giá - tên hãng");
            //foreach (var item in ketqua8)
            //{
            //    Console.WriteLine($"{item.name,10} {item.price,4} {item.brand,12}");
            //}
            #endregion
        }
    }

    public class Brand
    {
        public string? Name { set; get; }
        public int ID { set; get; }

        static List<Brand>? _brands;
        public static List<Brand> Brands
        {
            get
            {
                if (_brands == null)
                {
                    _brands = new List<Brand>() {
                        new Brand{ID = 1, Name = "Công ty AAA"},
                        new Brand{ID = 2, Name = "Công ty BBB"},
                        new Brand{ID = 4, Name = "Công ty CCC"},
                    };
                }
                return _brands;
            }
        }
    }

    public record ProductShow(
        string Ten, string MauSac);

}
