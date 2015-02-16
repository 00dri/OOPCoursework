using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsByGroup
{
    class SampleStudents
    {
        static void Main(string[] args)
        {
            //Problem 3
            var students = new Student[]
            {
                new Student("Pesho", "Zeshev", 32, "54854378", "+3592888745888", "pesho@gmail.com",
                    new List<int>(new int[] {4, 2, 3, 4, 5, 2}), 2),
                new Student("Misho", "Mishev", 23, "54851444", "028283859", "misho@gmail.com",
                    new List<int>(new int[] {3, 2, 3, 4, 5, 5}), 12),
                new Student("Gosho", "Goshev", 43, "54854314", "+3592888772987", "gosho@abv.bg",
                    new List<int>(new int[] {5, 3, 3, 6, 5, 6}), 2),
                new Student("Peshka", "Zesheva", 34, "56431455", "0888563886", "peshka@gmail.com",
                    new List<int>(new int[] {6, 6, 3, 4, 5, 6}), 12),
                new Student("Mishka", "Misheva", 54, "54851414", "0883 688 885", "mishka@abv.bg",
                    new List<int>(new int[] {5, 2, 3, 4, 5, 6}), 2),
                new Student("Goshka", "Zoshkova", 18, "54855555", "+359 2 888 888 884", "goshka@gmail.com",
                    new List<int>(new int[] {4, 2, 3, 4, 5, 4}), 12)
            };

            //Problem 4
            //Print all students from group number 2. Use a LINQ query. Order the students by FirstName.
            var groupTwo = from student in students
                where student.GroupNumber == 2
                orderby student.FirstName ascending 
                select student;

            Console.WriteLine("Problem 4: ");
            groupTwo.PrintEach();

            //Problem 5
            //Print all students whose first name is before their last name alphabetically. Use a LINQ query.
            var names = from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            Console.WriteLine();
            Console.WriteLine("Problem 5: ");
            names.PrintEach();

            //Problem 6
            //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. 
            //The query should return only the first name, last name and age.
            var adults = from student in students
                           where student.Age >= 18 && student.Age <= 24
                           select string.Format("{0} {1}, {2}", student.FirstName, student.LastName, student.Age);

            Console.WriteLine();
            Console.WriteLine("Problem 6: ");
            adults.PrintEach();

            //Problem 7
            //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name 
            //and last name in descending order. 
            //Rewrite the same with LINQ query syntax.

            var peopleInOrder = students.OrderByDescending(student => student.FirstName).ThenBy(student => student.LastName);

            var peopleInOrderLinq = from student in students
                orderby student.FirstName descending ,
                    student.LastName descending 
                select student;

            Console.WriteLine();
            Console.WriteLine("Problem 7: ");
            peopleInOrder.PrintEach();

            //Console.WriteLine();
            //Console.WriteLine("Problem 7 with LINQ: ");
            //peopleInOrderLinq.PrintEach();

            //Problem 8
            //Print all students that have email @abv.bg. Use LINQ.
            var abvEmails = from student in students
                where student.Email.EndsWith("@abv.bg")
                select student;

            Console.WriteLine();
            Console.WriteLine("Problem 8: ");
            abvEmails.PrintEach();

            //Problem 9
            //Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). Use LINQ.
            var sofiaPhones = from student in students
                where student.Phone.StartsWith("02") ||
                      student.Phone.StartsWith("+3592") ||
                      student.Phone.StartsWith("+359 2")
                select student;

            Console.WriteLine();
            Console.WriteLine("Problem 9: ");
            sofiaPhones.PrintEach();

            //Problem 10
            //Print all students that have at least one mark Excellent (6). 
            //Using LINQ first select them into a new anonymous class that holds { FullName + Marks}.
            var topStudents = from student in students
                where student.Marks.Contains(6)
                select new
                {
                    Name = string.Format("{0} {1}", student.FirstName, student.LastName),
                    Marks = student.Marks.ListToString()
                };

            Console.WriteLine();
            Console.WriteLine("Problem 10: ");
            topStudents.PrintEach();

            //Problem 11
            //Write a similar program to the previous one to extract the students with exactly two marks "2". 
            //Use extension methods.
            var weakStudents = from student in students
                              where student.Marks.Any(i => i.Equals(2))
                              select new
                              {
                                  Name = string.Format("{0} {1}", student.FirstName, student.LastName),
                                  Marks = student.Marks.ListToString()
                              };

            Console.WriteLine();
            Console.WriteLine("Problem 11: ");
            weakStudents.PrintEach();

            //Problem 12
            //Extract and print the Marks of the students that enrolled in 2014 
            //(the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).
            var students2014 = from student in students
                where student.FacultyNumber.ElementAt(4).Equals('1') &&
                      student.FacultyNumber.ElementAt(5).Equals('4')
                select student;

            Console.WriteLine();
            Console.WriteLine("Problem 12: ");
            students2014.PrintEach();
        }
    }
}
