

namespace CompanyHierarchy.Interfaces
{
    using CompanyHierarchy.Utilities;

    interface IEmployee :IPerson
    {
        decimal Salary { get; set; }
        Department Department { get; set; }
    }
}
