using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.WebUI.Models
{
    public class ProductPageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsInPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPage
        {
            get
            {
                return (int)Math.Ceiling((decimal)TotalItems / ItemsInPage);
            }
        }

        public string CurrentCategory;
    }
}