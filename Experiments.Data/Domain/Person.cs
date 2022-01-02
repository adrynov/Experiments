using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Experiments.Data
{
    [Table("Persons", Schema = "dbo")]
    public class Person
    {
        [Column("PersonId")]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        [Required]
        [Column("Email", TypeName = "varchar(50)")]
        public string EmailAddress { get; set; }


        public DateTime CreatedOn { get; set; }

        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}