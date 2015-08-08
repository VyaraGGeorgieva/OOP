using System;
using CompanyHierarchy.Utilities;

namespace CompanyHierarchy.Interfaces
{
    interface IProject
    {
        string ProjectName { get; set; }
        DateTime StartDate { get; set; }
        string Details { get; set; }
        State State { get; set; }

        void CloseProject();
    }
}
