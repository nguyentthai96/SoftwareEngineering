using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagementData.Models
{
    public class Staff
    {
        [Key]
        public string StrStaffId { get; set; }
        public string StrStaffName { get; set; }
        public bool BStatus { get; set; }
        public string StrPhoneNumber { get; set; }
        public string StrDescribe { get; set; }
        public DateTime DtmBirthday { get; set; }
    }
}
