using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAL.Models
{
    public class Employee
    {
        public string name { get; set; }

        public string role { get; set; }

        public string birthyear { get; set; }
    }
    public class Root
    {
        public List<Employee> employee { get; set; }
    }
}
