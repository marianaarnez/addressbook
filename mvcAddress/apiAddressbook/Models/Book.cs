namespace apiAddressbook.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum TypeContact
    {
        telephone,
        email,
        facebook,
        twitter,
        instagram,
        dblink,
    }

    public class Book
    {
        [Key]
        public int bookID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public TypeContact type { get; set; }
        [Required]
        public string contact { get; set; }

    }
}