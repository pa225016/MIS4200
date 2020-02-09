using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200.Models
{
    public class Car
    {
        public int carID { get; set; }
        public string description { get; set; }
        public decimal carCost { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public int supplierID { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
    }
}