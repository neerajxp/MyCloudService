using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyCloudService2
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int OrderId { get; set; }

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public int Qty { get; set; }

        [DataMember]
        public double Rate { get; set; }

        [DataMember]
        public double Total { get; set; }
    }
}