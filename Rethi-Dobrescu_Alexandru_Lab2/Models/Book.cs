using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rethi_Dobrescu_Alexandru_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Titlul cărții este obligatoriu.")]
        [StringLength(150, MinimumLength = 3,
    ErrorMessage = "Titlul trebuie să aibă între 3 și 150 de caractere.")]
        [Display(Name = "Titlu Carte")]
        public string Title { get; set; }
        [Display(Name = "Autor")]
        public int? AuthorID { get; set; }

        public Author? Author { get; set; }
        [Display(Name = "Pret")]
        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data Publicarii")]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        public ICollection<Borrowing>? Borrowings { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
