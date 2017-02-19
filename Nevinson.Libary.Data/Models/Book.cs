using System.ComponentModel.DataAnnotations;

namespace Nevinson.Libary.Data.Models
{
    public class Book : LibraryAsset
    {
        [Required]
        [Display(Name = "ISBN #")]
        public string ISBN { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [Display(Name = "DDC")]
        public string DeweyIndex { get; set; }
    }
}
