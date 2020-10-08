using System;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace Serialize_JSON_Dot_Net
{
    class Program
    {
        static void Main(string[] args)


        {

            //string path1 = Directory.GetCurrentDirectory();
            //var path2 = Path.GetFullPath(Path.Combine(path1, @"..\..\..\Location\"));

            // create product
            Product product = new Product();
            product.Name = "Pear";
            product.ExpiryDate = new DateTime(2020, 12, 28);
            product.Price = 3.99M;
            product.Sizes = new string[] { "Small", "Medium", "Large" };
            product.Raw = true;

            //serialize
            string output = JsonConvert.SerializeObject(product);
            Console.WriteLine(output);


            // de-serialize
            Product deserializedProduct = JsonConvert.DeserializeObject<Product>(output);
            Console.WriteLine(deserializedProduct.Name);
        }
    }
    class Product
    {
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Price { get; set; }
        public string[] Sizes { get; set; }
        public bool Raw { get; set; }
    }
}