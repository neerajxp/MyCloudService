using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyCloudWebsite.Models
{
    public class ProcessOrder
    {
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public int Qty { get; set; }
        public double Rate { get; set; }
        public double Total { get; set; }

        public static List<ProcessOrder> GetOrders()
        {
            List<ProcessOrder> Orders = new List<ProcessOrder>();

            MyCloudServiceReference.OrderServiceClient proxy = new MyCloudWebsite.MyCloudServiceReference.OrderServiceClient();
            var data = proxy.GetOrders().ToList();
            //Need to rework to see correct approach
            foreach (var a in data)
            {
                Orders.Add(new ProcessOrder() { OrderId = a.OrderId, ItemName = a.ItemName, Qty = a.Qty, Rate = a.Rate, Total = a.Total });
            }

            return Orders;
        }
    }
}