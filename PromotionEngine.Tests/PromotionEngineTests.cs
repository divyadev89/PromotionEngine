using System;
using Xunit;

namespace PromotionEngine
{
    public class PromotionEngineTests
    {
        PromotionOrderBO order = new PromotionOrderBO();
        //Test case to check price for SKU Ids
        [Fact]
        public void TestPrice()
        {
            Product productA = new Product("A");
            Product productB = new Product("B");
            Product productC = new Product("C");
            Product productD = new Product("D");
            Assert.Equal("50",Convert.ToString(productA.Price));
            Assert.Equal("30",Convert.ToString(productB.Price));
            Assert.Equal("20",Convert.ToString(productC.Price));
            Assert.Equal("15",Convert.ToString(productD.Price));
        }
        //Test case to check Total Price for SKU ID 3*A
        [Fact]
        public void TestTotalPriceA()
        {
            List<Product> productList = new List<Product>();
            Product productA = new Product("A");
            for (int i = 0; i < 3; i++)
            {
                productList.Add(productA);
            }
            int total_price = order.GetTotalPrice(productList);
            Assert.Equal("130",Convert.ToString(total_price));
        }
        //Test case to check Total Price for SKU ID 2*B
        [Fact]
        public void TestTotalPriceB()
        {
            List<Product> productList = new List<Product>();
            Product productB = new Product("B");
            for (int i = 0; i < 2; i++)
            {
                productList.Add(productB);
            }
            int total_price = order.GetTotalPrice(productList);
            Assert.Equal("45",Convert.ToString(total_price));
        }
        //Test case to check Total Price for SKU ID C+D
        [Fact]
        public void TestTotalPriceCD()
        {
            List<Product> productList = new List<Product>();
            Product productC = new Product("C");
            Product productD = new Product("D");
             productList.Add(productC);
             productList.Add(productD);
            
            int total_price = order.GetTotalPrice(productList);
            Assert.Equal("30",Convert.ToString(total_price));
        }
    }
}
