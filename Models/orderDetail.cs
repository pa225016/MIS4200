using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MIS4200.Models
{
    public class OrderDetail
    {
        public int orderdetailID { get; set; }

        [Display(Name = "How many cars?")]
        [Required(ErrorMessage = "Quantity is required!")]
        public int qtyOrdered { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required!")]
        [DataType(DataType.Currency)]
        public decimal price { get; set; }
        // the next two properties link the orderDetail to the Order
        public int orderID { get; set; }
        public virtual Order Order { get; set; }
        // the next two properties link the orderDetail to the Car
        public int carID { get; set; }
        public virtual Car Car { get; set; }
    }
}