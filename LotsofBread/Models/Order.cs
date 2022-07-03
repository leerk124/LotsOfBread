using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LotsofBread.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }

        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [BindNever]
        public bool Shipped { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the first address line")]
        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string Line3 { get; set; }

        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter a country name")]
        public string Country { get; set; }



        //CREDITCARD
        [Required(ErrorMessage = "Please enter your name on card")]
        public string NameOnCard { get; set; }

        [Required(ErrorMessage = "Please enter your card number")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Please enter your CVV")]
        public string CVV { get; set; }

        public string ExpMonth { get; set; }

        public string ExpYear { get; set; }






        public bool GiftWrap { get; set; }

    }
}
