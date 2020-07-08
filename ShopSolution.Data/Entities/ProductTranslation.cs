﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entities
{
    public class ProductTranslation
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }

        public string Detail{ set; get; }

        public string SeoDescription { set; get; }
        public string SeoTitle{set; get; }
        public string LangueID { set; get; }

        public Product Product { get; set; }
        public List<Language> Languages { get; set; }
    }
}
