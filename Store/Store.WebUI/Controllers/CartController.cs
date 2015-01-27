using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Domain.Order;
using Store.Domain.Entities;

namespace Store.WebUI.Controllers
{
    public class CartController : Controller
    {
        //
        // GET: /Cart/
        Order order;
        IProductRepository repository;

        public CartController(IProductRepository repoParam)
        {          
            order = new Order();
            repository = repoParam;
        }
        public ActionResult Cart(int id = -1)
        {
            
            if(id > 0)
            {
                order.AddProduct(repository.Products.Where(x => x.Id == id).First());
            }

            return View(order.Products);
        }


    }
}
