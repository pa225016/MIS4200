using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MIS4200.Models
{
    public class Order
    {
        public int orderID { get; set; }

        [Display(Name = "Desciption")]
        [Required(ErrorMessage = "Description is required!")]
        [StringLength(40)]
        public string description { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime orderDate { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        public ICollection<OrderDetail> OrderDetail { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        [Display(Name = "Customer ID")]
        [Required]
        public int customerID { get; set; }
        public virtual Owner Owner { get; set; }
    }

}