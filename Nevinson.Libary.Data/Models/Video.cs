using System.ComponentModel.DataAnnotations;

namespace Nevinson.Libary.Data.Models
{
    public class Video : LibraryAsset
    {
        [Required]
        public string Director { get; set; }
    }
}
