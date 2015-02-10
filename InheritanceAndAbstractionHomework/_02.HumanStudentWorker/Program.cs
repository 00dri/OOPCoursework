namespace _02.HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student("Pesho", "Peshov", "1gt5tg5"),
                new Student("Qesho", "Peshov", "9gt5tg5"),
                new Student("Aesho", "Peshov", "2gt5tg5"),
                new Student("4esho", "Peshov", "8gt5tg5"),
                new Student("Mesho", "Peshov", "3gt5tg5"),
                new Student("Jesho", "Peshov", "7gt5tg5"),
                new Student("Lesho", "Peshov", "4gt5tg5"),
                new Student("Kesho", "Peshov", "6gt5tg5"),
                new Student("Tesho", "Peshov", "5gt5tg5"),
                new Student("Fesho", "Peshov", "0gt5tg5")
            };

            var workers = new List<Worker>()
            {
                new Worker("Gosho", "Goshev", 300, 27),
                new Worker("Mosho", "Goshev", 200, 27),
                new Worker("Kosho", "Goshev", 100, 27),
                new Worker("Fosho", "Goshev", 400, 27),
                new Worker("Rosho", "Goshev", 500, 27),
                new Worker("Tosho", "Goshev", 600, 27),
                new Worker("Wosho", "Goshev", 330, 27),
                new Worker("Hosho", "Goshev", 700, 27),
                new Worker("Nosho", "Goshev", 800, 27),
                new Worker("Posho", "Goshev", 900, 27)
            };

            Console.WriteLine("Students:");

            foreach (var source in students.OrderBy(student => student.FacultyNumber))
            {
                Console.WriteLine(source);
            }

            Console.WriteLine("Workers:");

            foreach (var source in workers.OrderByDescending(worker => worker.MoneyPerHour()))
            {
                Console.WriteLine(source);
            }
        }
    }
}
