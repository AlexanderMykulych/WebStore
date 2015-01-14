using Store.Domain.Entities;
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
        public HomeController(IProductRepository repoParam)
        {
            repository = repoParam;
        }
        //
        // GET: /Home/        
        public ActionResult Index()
        {
            
            return View();
        }

    }
}
