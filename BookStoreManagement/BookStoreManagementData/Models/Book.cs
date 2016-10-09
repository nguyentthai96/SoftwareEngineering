using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagementData.Models
{
    public class Book
    {
        [Key]
        public string StrBookId { get; set; }
        public string StrBookName { get; set; }
        public Windows.UI.Xaml.Controls.Image ImgBookCover { get; set; }
        public long LBookPage { get; set; }
        
        [ForeignKey("Publisher")]
        public string StrPublisherId { get; set; }
        [ForeignKey("BookType")]
        public string StrBookTypeId { get; set; }
    }
}
