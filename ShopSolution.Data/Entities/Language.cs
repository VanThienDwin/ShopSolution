using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entities
{
    public class Language
    {
        public int Id { set; get; }
        public int ProductTranslationId { set; get; }
        public int CategoryTranslationId { set; get; }
        public string Name { set; get; }
        public bool IsDefault { set; get; }

        public ProductTranslation ProductTranslation { get; set; }
        public CategoryTranslation CategoryTranslation { get; set; }
    }
}
