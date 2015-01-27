using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Order
{
    public class Order
    {
        public List<Product> Products; 
 
        public Order(Product product = null)
        {
            Products = new List<Product>();
            if (product != null)
                Products.Add(product);
        }

        public Order(IEnumerable<Product> products)
        {
            Products = new List<Product>();
            Products.AddRange(products);
        }

        public decimal Sum
        {
            get
            {
                return Products.Sum(x => x.Price);
            }
        }

        public void DeleteProduct(int id)
        {
            DeleteProduct(Products.Where(x => x.Id == id).First());
        }
        public void DeleteProduct(Product product)
        {
            Products.Remove(product);
        }

        public void AddProduct(Product product)
        {
            var curProduct = Products.Where(x => x == product).FirstOrDefault();
            if(curProduct != null)
            {
                curProduct.Count++;
            }
            else
            {
                Products.Add(product);
            }
        }

    }
}
