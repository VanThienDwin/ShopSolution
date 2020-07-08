using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entities
{
    public class OrderDetail
    {
        public int OrderId { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        //OrderDetail trỏ tới Order
        public Order Order { get; set; }

        //OrderDetail trỏ tới Product
        public Product Product { get; set; }
 

    }
}
