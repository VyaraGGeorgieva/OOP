using System;
using System.Collections.Generic;
using System.Linq;
using HumanStudentWorker.People;

namespace HumanStudentWorker
{
    class Tests
    {
        static void Main()
        {
            Console.WriteLine("Students: ");
            var students = new List<Student>()
            {
                new Student("Peter", "Petrov", "tyytty6"),
                new Student("Maria", "Atanasova", "567876"),
                new Student("Stoyan", "Markov", "765894"),
                new Student("Vanessa", "Vasileva", "5765490"),
                new Student("Monika", "Georgieva", "a765490"),
                new Student("Blagovest", "Petrov", "9765490"),
                new Student("Mario", "Dimitrov", "ab65490"),
                new Student("Nikola", "Ivanov", "baa5490"),
                new Student("Peter", "Mishev", "3165490"),
                new Student("Vyara", "Vasileva", "w365490")
            };

            var sortedStudents = students.OrderBy(x => x.FacultyNumber);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0}, {1}", student, student.FacultyNumber);
            }

            var workers = new List<Worker>()
            {
                new Worker("Peter", "Aaaa", 100.7m, 20),
                new Worker("Gaaaa", "Bbbb", 1200.13m, 20),
                new Worker("Hbbb", "Ccccc", 134.74m, 20),
                new Worker("Nccc", "Ddddd", 1234, 20),
                new Worker("Bddd", "Eeee", 345.7m, 20),
                new Worker("Eeee", "Ffff", 8269.7m, 20),
                new Worker("Vvff", "Gggg", 347, 20),
                new Worker("Kgggg", "Hhhhh", 965, 20),
                new Worker("Mhhhh", "Iiii", 555, 20),
                new Worker("Ziii", "Jjjjj", 555, 20),
            };
            Console.WriteLine();
            Console.WriteLine("Workers: ");
            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine("{0}, {1:F2}", worker, worker.MoneyPerHour());
            }

            Console.WriteLine();
            Console.WriteLine("Everyone:");
            var allHumans = new List<Human>();
            students.ForEach(x => allHumans.Add(x));
            workers.ForEach(x => allHumans.Add(x));

            var sortedHumans = allHumans.OrderBy(x => x.FirstName + ' ' + x.LastName);
            foreach (var sortedHuman in sortedHumans)
            {
                Console.WriteLine("{0}", sortedHuman);
            }
        }
    }
}
