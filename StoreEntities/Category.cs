﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Entities
{
   public class Category:BaseEntites
    {
        public string ImageUrl { get; set; }
        public List<Product> Products { get; set; }

    }
}
