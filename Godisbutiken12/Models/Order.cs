using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Godisbutiken12.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        [Required(ErrorMessage ="Skriv in ditt förnamn")]
        [Display(Name = "Förnamn")]
        [StringLength(25)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Skriv in ditt efternamn")]
        [Display(Name = "Efternamn")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Skriv in din adress")]
        [Display(Name = "Adress")]
        [StringLength(100)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Skriv in din stad")]
        public string City { get; set; }
        [Required(ErrorMessage = "Skriv in din postnummer")]
        [StringLength(5,MinimumLength = 5)]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Skriv in din mobil nummer")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; }
        [BindNever]
        public DateTime OrderPlaced { get; set; }

    }
}
