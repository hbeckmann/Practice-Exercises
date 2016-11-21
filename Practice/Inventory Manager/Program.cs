using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            Product carrot = new Product("Carrot", -3.33f, 01, 10);
            Product bagel = new Product("Bagel", 4.00f, 12, 3);
            Product chips = new Product("Chips", 8.22f, 98, 200);

            List<Product> products = new List<Product>();
            products.Add(carrot);
            products.Add(bagel);
            products.Add(chips);

            Inventory homeInventory = new Inventory(products);
            homeInventory.ListInventory();
            Console.WriteLine(homeInventory.CalculateTotalValue());
            Console.ReadKey();
        }
    }
}
