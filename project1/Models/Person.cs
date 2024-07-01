using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project1.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public int PersonID{ get; set; }
        public string FullName{ get; set; }
        public string Address{ get; set; }
    }
}