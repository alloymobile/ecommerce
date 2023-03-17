using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    public class ProductService
    {
        public List<Product> products = new List<Product>();    

        public ProductService() { 
            this.addBaseProducts();
        }

        public List<Product> GetProducts() 
        {
            return products;
        }

        public Product GetProduct(int id)
        {
            return null;
        }

        public Product AddProduct(Product product)
        {
            this.products.Add(product);
            return product;
        }

        public Product UpdateProduct(int id,Product product)
        {
            return null;
        }

        public void DeleteProduct(int id)
        {

        }

        public void addBaseProducts()
        {
            Product p1 = new Product(1,"Phone",1500,10);
            Product p2 = new Product(2, "Laptop", 2500, 5);
            products.Add(p1);
            products.Add(p2);
        }
    }
}
