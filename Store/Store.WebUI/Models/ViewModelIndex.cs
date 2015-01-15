using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.WebUI.Models
{
    public class ViewModelIndex
    {
        public ProductPageInfo pageInfo { get; set; }
        public IEnumerable<Product> product { get; set; }
    }
}