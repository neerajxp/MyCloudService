using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyCloudService2
{
    public class OrderService : IOrderService
    {
        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from ordermaster", con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Order ord = new Order();
                        ord.OrderId = dr.GetInt32(0);
                        ord.ItemName = dr.GetString(1);
                        ord.Qty = dr.GetInt32(2);
                        ord.Rate = dr.GetDouble(3);
                        ord.Total = dr.GetDouble(4);

                        orders.Add(ord);
                    }
                }
            }

            return orders;
        }
    }
}