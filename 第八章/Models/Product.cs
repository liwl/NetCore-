using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace 第八章.Models
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public string No { get; set; }

        public string Name { get; set; }
    }
}
