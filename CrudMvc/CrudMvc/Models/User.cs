using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMVC.Models
{
    [Table("User")]
    public class User
    {
        [Display(Name = "ID")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Column("Name")]
        public string Name { get; set; }

    }
}
