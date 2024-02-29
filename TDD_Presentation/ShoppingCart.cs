using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_Presentation_domain;

namespace TDD_Presentation_domain
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        private List<Product> _items = new List<Product>();
        public IReadOnlyList<Product> Items => _items;


        public ShoppingCart()
        {
            _items = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            _items.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            _items.Remove(product);
        }
        public decimal Total()
        {
            return _items.Sum(x => x.Price);
        }
        public int ProductCountAll()
        {
            return _items.Count();
        }
        public int ProductCountUnique()
        {
            return _items.Select(x => x.Name).Distinct().Count();
        }

        public void AddManyProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                if (!_items.Any(p => p.Name == product.Name))
                {
                    _items.Add(product);
                }
            }
        }

    }
}
