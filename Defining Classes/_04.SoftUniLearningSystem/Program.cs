namespace _04.SoftUniLearningSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SuslTest
    {
        static void Main()
        {
            var pesho = new Person("Petar", "Petrov", 30);
            var masha = new Person("Maria", "Marieva", 44);
            var gosho = new Person("Georgi", "Georgiev", 17);
            var ivanov = new Trainer("Ivan", "Ivanov", 35);
            var petrov = new JuniorTrainer("Pencho", "Petrov", 35);
            var ivanova = new SeniorTrainer("Iva", "Ivanova", 22);
            var petrova = new Student("Petia", "Petrova", 17, 423434, 5.05);
            var zavurshnikova = new Graduate("Gotovka", "Zavurshnikova", 18, 622286, 6.00);
            var segashnikova = new Current("Momentka", "Segashnikova", 55, 555654, 3.00, "OOP");
            var onlainyrkova = new Online("Netka", "Onlainyrkova", 21, 444444, 3.55, "PHP Basics");
            var onsaitova = new Onsite("Sedianka", "Onsaitova", 21, 191919, 5.90, "Java Basics", 2);
            var murzelivkov = new DropoutStudent("Syncho", "Murzelivkov", 23, 666654, 2.50, "Bad grades");

            ivanov.CreateCourse("KPK");
            Console.WriteLine();
            ivanova.DeleteCourse("C#");
            Console.WriteLine();
            murzelivkov.Reapply();
            Console.WriteLine();

            var persons = new List<Person>
            {
                pesho, masha, gosho, ivanov, petrov, ivanova, petrova, zavurshnikova, segashnikova, murzelivkov, onlainyrkova, onsaitova
            };

            var currentStudents =
                from person in persons
                where person is Current
                select (Current)person;

            currentStudents = currentStudents.OrderByDescending(c => c.AverageGrade);

            foreach (var currentStudent in currentStudents)
            {
                Console.WriteLine(currentStudent);
            }
        }
    }
}
