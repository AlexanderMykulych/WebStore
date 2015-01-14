using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
