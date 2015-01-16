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
        int ItemsInPage = 3;
        public HomeController(IProductRepository repoParam)
        {
            repository = repoParam;
        }
        //
        // GET: /Home/        
        public ActionResult Index(string categories = null, int pageId = 1)
        {
            var Product = categories == "All" ? repository.Products : repository.Products
                                                                                .Where(x => x.Category == categories);

            int CountItemInPage = Product.Count();
            Product = Product
                            .OrderBy(x => x.Id)
                            .Skip((pageId - 1) * ItemsInPage)
                            .Take(ItemsInPage);
                                                                                
            var PageInfo = new ProductPageInfo() 
                                {
                                    TotalItems = CountItemInPage,
                                    ItemsInPage = this.ItemsInPage,
                                    CurrentPage = pageId,
                                    CurrentCategory = categories
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
