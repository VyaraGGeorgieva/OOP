using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.People;

namespace CompanyHierarchy.Interfaces
{
    interface IManager :IEmployee
    {
        List<Employee> Employees { get; set; }
    }
}
