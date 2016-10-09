using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagementData.Models
{
   public class Customer
    {
        [Key]
        public string StrPhoneNumber { get; set; }
        public string strCustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerDecribe { get; set; }
    }
}
