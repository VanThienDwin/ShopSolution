using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreate { set; get; }
        public string SeoAlias { set; get; }
        public string Image { set; get; }

        public int PromotionId { set; get; }

        //Khai báo liên kết khóa ngoại
        public List<ProductInCategory> ProductInCategories { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        //1 cart có nhiều product
        public Cart Cart { get; set; }

        public ProductTranslation ProductTranslation { get; set; }
        public Promotion Promotion { get; set; }
    }
}
