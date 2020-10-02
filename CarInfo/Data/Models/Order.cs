using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Enter name :")]
        [StringLength(25)]
        [Required(ErrorMessage = "Length of the name is not less than 25sumb")]
        public string name { get; set; }
        [Display(Name = "Enter surname :")]
        [StringLength(25)]
        [Required(ErrorMessage = "Length of the surname is not less than2 5sumb")]
        public string surname { get; set; }
        [Display(Name = "Enter adress :")]
        [StringLength(25)]
        [Required(ErrorMessage = "Length of the adress is not less than 25sumb")]
        public string adress { get; set; }
        [Display(Name = "Enter phone :")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Length of the phone is not less than 10sumb")]
        public string phone { get; set; }
        [Display(Name = "Enter email :")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Length of the email is not less than 25sumb")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDet> orderDetails { get; set; }
    }
}
