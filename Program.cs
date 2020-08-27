using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            /* we can use Dependency Injection here to create object but for this test I have 
              used console application */
            List<Product> productList = new List<Product>();
            PromotionOrderBO order = new PromotionOrderBO();
            
            Console.WriteLine("Please Enter total number of order:");
            int orderCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < orderCount; i++)
            {                
                Console.WriteLine("Please enter the type of product:A or B or C or D");
                string type= Console.ReadLine();
                Product productType = new Product(type);                
                productList.Add(productType);
            }

            int totalPrice = order.GetTotalPrice(productList);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }
    }
}
