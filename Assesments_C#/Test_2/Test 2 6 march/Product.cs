using Assesment_4__March;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_4__March

/*2. Create a Class called Products with Productid, Product Name, Price. Accept 10 Products,
 * sort them based on the price, and display the sorted Products*/
{



    public class Product //created the class called product with datamembers;
    {
        static void Main(string[] args)
        {
            Hashtable products = new Hashtable();

            AddProduct(products, 1, "Laptop", 1000);
            AddProduct(products, 2, "Phone", 20);
            AddProduct(products, 3, "Headphones", 16);
            AddProduct(products, 4, "Tablet", 908);
            AddProduct(products, 5, "Smartwatch", 2);
            AddProduct(products, 6, "Tv", 8888);
            AddProduct(products, 7, "car", 10000);
            AddProduct(products, 8, "Truck", 8000000);
            AddProduct(products, 9, "Book", 29);
            AddProduct(products, 10, "Alligator", 9990);



            DisplaySortedProducts(products);
        }
        //public Product(productId, productName, price)
        static void AddProduct(Hashtable products, int productId, string productName, double price)
        {
            products.Add(price, new Productdet(productId, productName, price));
        }

        static void DisplaySortedProducts(Hashtable products)
        {
            SortedList sortedProducts = new SortedList(products);

            Console.WriteLine("Sorted Products on the basis of their price:");
            foreach (DictionaryEntry price in sortedProducts)
            {
                Console.WriteLine(price.Value);
                Console.ReadLine();
                
            }
        }
    }

    class Productdet
    {
        public int ProductId;
        public string ProductName;
        public double Price;

        public Productdet(int productId, string productName, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ProductName} (ID: {ProductId}) - rs{Price}";
            Console.ReadLine();
        }
       
    }
}
//output 
/*:
/*:
/*:Sorted Products on the basis of their price:
Smartwatch(ID: 5) - rs2

Headphones(ID: 3) - rs16

Phone(ID: 2) - rs20

Book(ID: 9) - rs29

Tablet(ID: 4) - rs908

Laptop(ID: 1) - rs1000

Tv(ID: 6) - rs8888

Alligator(ID: 10) - rs9990

car(ID: 7) - rs10000

Truck(ID: 8) - rs8000000
*/