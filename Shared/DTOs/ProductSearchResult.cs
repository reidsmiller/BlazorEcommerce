﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorEcommerce.Shared.Models;

namespace BlazorEcommerce.Shared.DTOs
{
    public class ProductSearchResult
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}
