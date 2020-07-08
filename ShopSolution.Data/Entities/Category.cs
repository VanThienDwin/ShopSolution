﻿using ShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome  { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }

        public int PromotionId { set; get; }

        //Khai báo liên kết khóa ngoại 
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }

        public CategoryTranslation CategoryTranslation { get; set; }
        public Promotion Promotion { get; set; }
    }


}
