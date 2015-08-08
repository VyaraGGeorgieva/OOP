namespace CompanyHierarchy.People
{
    using System;
    using Interfaces;

    class Customer :Person, ICustomer
    {
        private decimal netPurchaseAmount;
        public Customer(int id, string firstName, string lastName, decimal netPurchaseAmount) 
            : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }
            set {
                if (value >= 0)
                {
                    this.netPurchaseAmount = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "The amount should be a positive number!");
                }
               
        }
        }

        public override string ToString()
        {
            return string.Format("Customer: {0} {1} ID: {2}, spent: {3} ", 
                this.FirstName, this.LastName, this.Id, this.netPurchaseAmount);
        }
    }
}
