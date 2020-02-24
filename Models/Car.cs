using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MIS4200.Models
{
    public class Car
    {
        
        public int carID { get; set; }

        [Display(Name = "Car Name")]
        [Required(ErrorMessage = "Car Name is required!")]
        [StringLength(40)]
        public string description { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required!")]
        [DataType(DataType.Currency)]
        public decimal carCost { get; set; }

        public ICollection<OrderDetail> OrderDetail { get; set; }
    }
}