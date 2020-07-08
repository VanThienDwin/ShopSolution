using ShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entities
{
    public class Order
    {
        public int Id { set; get; }
        public DateTime Orderdate { set; get; }
        public int UserId { set; get; }
        public string ShipName { set; get; }
        public string ShipAddress { set; get; }
        public string ShipEmail{ set; get; }
        public string ShipPhoneNumber { set; get; }
        public Status Status { set; get; }


        public List<OrderDetail> OrderDetails { get; set; }
    }
}
