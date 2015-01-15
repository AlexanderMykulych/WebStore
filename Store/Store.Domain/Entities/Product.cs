﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsPresence { get; set; }
        public int Count { get; set; }
        public byte[] ImageData { get; set; }

        public string ImageMimeType { get; set; }
        public string Category { get; set; }
    }
}
