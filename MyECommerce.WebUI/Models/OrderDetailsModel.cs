using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Models
{
    public class OrderDetailsModel
    {
        [Required(ErrorMessage ="Please type a address header")]
        public string AddressHeader { get; set; }
        [Required(ErrorMessage = "Please type a address")]
        public string AddressRow { get; set; }
        [Required(ErrorMessage = "Please type a city")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please type a neighborhood")]
        public string Neighborhood { get; set; }
        [Required(ErrorMessage = "Please type a contact telephone number")]
        public string Telephone { get; set; }
    }
}
