using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ecommerce;

namespace ProductTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void ProductService_AddProduct_Valid()
        {
            Product p = new Product(3,"Computer",5,1000);
            ProductService service = new ProductService();
            int expected = 3;
            Product p1 = service.AddProduct(p);
            int actual = p1.getId();
            Assert.AreEqual(expected, actual);
        }
    }
}
