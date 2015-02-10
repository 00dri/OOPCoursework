namespace _04.CompanyHierarchy
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var salesPenka = new SalesEmployee("3edcde", "Penka", "Penkova", 900m, Department.Sales, new List<Sale> { new Sale("testProduct1", new DateTime(2015, 02, 01), 10m), new Sale("testProduct2", new DateTime(2015, 02, 01), 20m) });
            var salesGenka = new SalesEmployee("4rfvfr", "Genka", "Genkova", 800m, Department.Sales);

            var devCenka = new Developer("5tgbgt", "Cenka", "Cenkova", 900m, Department.Accounting, new List<Project>{new Project("testProject", new DateTime(2015, 02, 01), "testDetails",State.Open)});
            var devTosho = new Developer("6yhnhy", "Tosho", "Toshev", 800m, Department.Marketing);

            var managerPesho = new Manager("1qazaq", "Pesho", "Peshev", 900m, Department.Accounting, new List<Employee> { salesPenka, salesGenka });
            var managerGosho = new Manager("2wsxsw", "Gosho", "Goshev", 800m, Department.Marketing);

            var holder = new List<Object> {managerPesho, managerGosho, salesPenka, salesGenka, devCenka, devTosho};

            foreach (var member in holder)
            {
                Console.WriteLine(member);
            }
        }
    }
}
