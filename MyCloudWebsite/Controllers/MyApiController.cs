using MyCloudWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyCloudWebsite.Controllers
{
    [RoutePrefix("api/orders")]
    public class MyApiController : ApiController
    {
        [Route("")]
        [HttpGet]
        public List<ProcessOrder> GetOrders()
        {
            //var data=Order
            var data = ProcessOrder.GetOrders();
            return data;
        }
    }
}