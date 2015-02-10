namespace _02.HumanStudentWorker
{
    class Worker : Human
    {
        private const int WorkDaysPerWeek = 5;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            var moneyPerHour = WeekSalary/WorkDaysPerWeek/WorkHoursPerDay;
            return moneyPerHour;
        }

        public override string ToString()
        {
            return base.ToString() + 
                "\nSalary per week: " +
                WeekSalary.ToString("C0") + 
                "\nWork hours per day: " +
                WorkHoursPerDay + 
                "\nMoney per hour: " 
                + MoneyPerHour().ToString("C");
        }
    }
}
