using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Eid { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
        [ForeignKey("Department")]
        public int Did { get; set; }
        public virtual Department Department { get; set; }
    }

}
