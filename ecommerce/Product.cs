using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    //MVC
    public class Product
    {
        private int id;
        private string name;
        private double price;
        private int quantity;

        public Product(int id, string name, double price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
