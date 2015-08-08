using System.Collections.Generic;
using CompanyHierarchy.Utilities;

namespace CompanyHierarchy.Interfaces
{
    interface ISalesEmployee :IRegularEmployee
    {
        List<Sale> Sales { get; set; }
    }
}
