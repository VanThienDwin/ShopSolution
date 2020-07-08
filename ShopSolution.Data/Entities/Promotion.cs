using ShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entities
{
    public class Promotion
    {
        public int Id { set; get; }
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
        public int ApplyForAll { set; get; }
        public int DiscountPercent { set; get; }
        public int DiscountAmount { set; get; }
        public int ProductId { set; get; }
        public int CategoryId { set; get; }
        public Status Status { set; get; }
        public string Name { set; get; }

        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
