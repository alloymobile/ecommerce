﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    public class ProductResource
    {
        private ProductService service = new ProductService();
       
        
        public List<Product> GetProducts()
        {
            return service.GetProducts();
        }

        public Product GetProduct(int id)
        {
            return null;
        }

        public Product AddProduct(Product product)
        {
            return this.service.AddProduct(product);
        }

        public Product UpdateProduct(Product product)
        {
            return null;
        }

        public void DeleteProduct(int id)
        {

        }

    }
}
