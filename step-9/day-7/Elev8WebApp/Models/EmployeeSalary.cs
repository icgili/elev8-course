using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Elev8WebApp.Models
{
    [Table("employee_salaries")]
    public class EmployeeSalaryInfo : Employee
    {
        [Required]
        [Column("salary")]
        public decimal Salary { get; set; }
        [Column("deductions")]
        public decimal Deductions { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
