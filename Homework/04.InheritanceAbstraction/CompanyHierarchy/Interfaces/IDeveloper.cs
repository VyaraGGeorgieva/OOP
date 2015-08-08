using System.Collections.Generic;
using CompanyHierarchy.Utilities;

namespace CompanyHierarchy.Interfaces
{
    interface IDeveloper
    {
        List<Project> Projects { get; set; }
    }
}
