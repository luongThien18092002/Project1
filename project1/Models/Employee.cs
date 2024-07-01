using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project1.Models
{
    [Table("Employee")]
    public class Employee : Person
    {
        [Key]
        public int PersonID{ get; set; }
        public string EmployeeID{ get; set; }
        public int Age{ get; set; }
    }
}