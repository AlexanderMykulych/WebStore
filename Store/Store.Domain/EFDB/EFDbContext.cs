﻿using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.EFDB
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Table;
    }
}
