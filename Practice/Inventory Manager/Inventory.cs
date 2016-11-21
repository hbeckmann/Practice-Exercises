using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    class Inventory
    {
        public List<Product> Products{get; set;}
        public float TotalValue { get; set; }

        public Inventory(List<Product> products)
        {
            this.Products = products;
        }

        public void ListInventory()
        {
            foreach(Product product in this.Products)
            {
                Console.Write(" Name: " + product.Name);
                Console.Write(" Price: " + product.Price);
                Console.Write(" Id: " + product.Id);
                Console.Write(" Quantity: " + product.Quantity + "\n");
            }
        }

        public float CalculateTotalValue()
        {
            foreach(Product product in this.Products)
            {
                TotalValue += product.Price;
            }
            return TotalValue;
        }
    }
}
