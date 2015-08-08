using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;
using CompanyHierarchy.Utilities;

namespace CompanyHierarchy.People
{
    class RegularEmployee:Employee, IRegularEmployee
    {
        public RegularEmployee(int id, string firstName, string lastName, decimal salary, Department department) : base(id, firstName, lastName, salary, department)
        {
        }
    }
}
