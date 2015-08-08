using HumanStudentWorker.Calculations;

namespace HumanStudentWorker.People
{
    public class Worker : Human, IMoneyPerHour
    {
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; set; }
        public decimal WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            var moneyPerHour = 
                (this.WeekSalary/7)*
                this.WorkHoursPerDay;
            return moneyPerHour;
        }
    }
}
