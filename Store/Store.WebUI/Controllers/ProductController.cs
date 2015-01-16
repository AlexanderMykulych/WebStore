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
        //IProductRepository repository;
        ////
        //// GET: /Product/
        //public ProductController(IProductRepository repoParam)
        //{
        //    repository = repoParam;
        //}

        public PartialViewResult Items()
        {
            return PartialView();
        }

    }
}
