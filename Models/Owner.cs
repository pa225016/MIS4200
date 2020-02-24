using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public class Owner
    {
        public int OwnerId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required!")]
        [StringLength(20)]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required!")]
        [StringLength(25)]
        public string lastName { get; set; }

        [Display(Name = "Email Address")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter your most frequently used email address")]
        public string email { get; set; }

        [Display(Name = "Phone Number")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage = "Format: (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }

        [Display(Name = "Date Joined")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime customerSince { get; set; }

        // add any other fields as appropriate
        // a customer can have any number of orders, a 1:M relationship,
        // We represent this in the model with an ICollection
        // The syntax says we are creating an ICollection of Order objects,
        // (the name inside the <> is the object name),
        // and the local name of the collection will be Order
        // (the object name and the local name do not have to be the same)
        public ICollection<Order> Order { get; set; }
    }
}