using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.WebUI.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository repository;
        //
        // GET: /Product/
        public ProductController(IProductRepository repoParam)
        {
            repository = repoParam;
        }

        public PartialViewResult Items(string category = "All", int start = 0, int count = -1)
        {

            return PartialView(repository.Products
                .Where(x => category == "All" ? x.Category != null : x.Category == category)
                .OrderBy(x => x.Id)
                .Skip(start)
                .Take( count == -1 ? repository.Products.Count() : count));
        }

    }
}
