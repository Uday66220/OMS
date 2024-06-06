using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int DId { get; set; }

        public string DName { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Employee> Employees { get; set; }
    }
}
