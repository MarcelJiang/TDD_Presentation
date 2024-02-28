using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Presentation_domain
{
    public class ShoppingCart
    {
        public List<Product> Items { get; set; } = new();
        private IReadOnlyList<Product> _items = new List<Product>();
       

        public ShoppingCart()
        {
            Items = new List<Product>();
        }
        public void AddItem(Product item)
        {
            Items.Add(item);
        }
        public void RemoveItem(Product item)
        {
            Items.Remove(item);
        }
        public decimal Total()
        {
            return Items.Sum(x => x.Price);
        }
    }
}
