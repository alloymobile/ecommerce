using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    internal class Program
    {
        private static ProductResource resource =  new ProductResource();
        
        static void Main(string[] args)
        {
            Console.WriteLine("!My Shop!");
            resource.GetProducts().ForEach(x => Console.WriteLine(x.Id + " "+x.Name));
        }
    }
}
