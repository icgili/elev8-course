using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkApp
{
    [Table("employees")]
    public class Employee
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("date_of_employment")]
        public string DateOfEmployment { get; set; }
        [Column("department")]
        public string Department { get; set; }
        [Column("role")]
        public string Role { get; set; }
    }
}
