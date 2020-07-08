using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entities
{
    public class Cart
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        //Khai báo liên kết 1 nhiều
        public List<Product> Products { get; set; }
    }
}
