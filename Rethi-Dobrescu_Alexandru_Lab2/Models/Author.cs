using System.ComponentModel.DataAnnotations;

namespace Rethi_Dobrescu_Alexandru_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "Nume")]
        public string LastName { get; set; }

        [Display(Name = "Prenume")]
        public string FirstName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }


        public ICollection<Book>? Books { get; set; }
    }
}
