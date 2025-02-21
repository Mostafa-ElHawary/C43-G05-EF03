using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample.Entities
{
    public class PartTimeEmployees : Employee
    {

        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }
    }
}
