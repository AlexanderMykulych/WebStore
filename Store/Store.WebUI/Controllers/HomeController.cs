using Store.Domain.Entities;
using Store.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IProductRepository repository;
        int ItemsInPage = 4;
        public HomeController(IProductRepository repoParam)
        {
            repository = repoParam;
        }
        //
        // GET: /Home/        
        public ActionResult Index(string categories, int pageId)
        {
            var Product = repository.Products
                                    .Where(x => x.Category == categories);
            var PageInfo = new ProductPageInfo() 
                                {
                                    TotalItems = Product.Count(),
                                    ItemsInPage = this.ItemsInPage,
                                    CurrentPage = pageId
                                };

            return View(new ViewModelIndex() 
                            {   
                                product = Product,
                                pageInfo = PageInfo
                            });
        }

        public PartialViewResult Menu(string categories = null)
        {
            ViewBag.SelectedCategory = categories;

            return PartialView(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
