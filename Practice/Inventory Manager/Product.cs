using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Product
    {

        private float price;
        public float Price {
            get
            {
                return price;
            }
            set
            {
                //Can't have a negative price, defaults to 0
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    price = 0f;
                }
            }
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public int Quantity { get; set; }

        public Product(string name, float price, int id, int quantity)
        {
            this.Price = price;
            this.Name = name;
            this.Id = id;
            this.Quantity = quantity;
        }

        public void RemoveQuantity(int quantityToRemove)
        {
            if (quantityToRemove < this.Quantity)
            {
                this.Quantity -= quantityToRemove;
            } else
            {
                this.Quantity = 0;
            }
        }

        public void AddQuantity(int quantityToAdd)
        {
                this.Quantity += quantityToAdd;
        }

        public void ChangePrice(float price)
        {
            this.Price = price;
        }

        public void ChangeName(string name)
        {
            this.Name = name;
        }

    }
}
