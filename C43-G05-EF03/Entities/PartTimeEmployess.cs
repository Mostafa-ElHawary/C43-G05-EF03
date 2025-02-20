using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_EF03.Entities
{
    public class PartTimeEmployees  : Employee
    {

        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }
    }
}
