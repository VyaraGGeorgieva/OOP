namespace CompanyHierarchy.People
{
    using System.Collections.Generic;
    using Interfaces;
    using Utilities;

    class SalesEmployee:RegularEmployee,ISalesEmployee
    {
        private List<Sale> sales; 
        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department department, List<Sale> sales ) 
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales
        {
            get { return this.sales; }
            set { this.sales = value; }
        }
    }
}
