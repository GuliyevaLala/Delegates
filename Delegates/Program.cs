using Delegates_Homework.Models;
using System;
using System.Collections.Generic;

namespace Delegates {
    class Program {
        static void Main(string[] args)
        {
            #region ShowingSalary
            //Person person1 = new Person();
            //person1.Name = "Rena";
            //person1.Surname = "ABBASOVA";
            //person1.Address = "NIZAMI avenue 80a";
            //person1.Salary = 400;

            //Person person2 = new Person();
            //person2.Name = "Shahla";
            //person2.Surname = "Qedirova";
            //person2.Address = "Yasamal district";
            //person2.Salary = 8000;

            //Person person3 = new Person();
            //person3.Name = "Sema";
            //person3.Surname = "Sahibova";
            //person3.Address = "Binagay district";
            //person3.Salary = 1500;

            //List<Person> people = new List<Person>();

            //people.Add(person1);
            //people.Add(person2);
            //people.Add(person3);

            //foreach (Person person in people)
            //{
            //    Console.WriteLine(ShowPerson(GetPerson, person));
            //}
            #endregion



            #region ArithmeticMeanofSalary
            Employee emp1 = new Employee();
            emp1.Age = 37;
            emp1.Salary = 2900;

            Employee emp2 = new Employee();
            emp2.Age = 25;
            emp2.Salary = 4000;

            Employee emp3 = new Employee();
            emp3.Age = 15;
            emp3.Salary = 1600;


            List<Employee> employees = new List<Employee>();

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            Console.WriteLine(ShowSalary(GetArithmeticMeanSalary, employees));
            #endregion

        }

        #region SalaryGreaterThan1000
        public static bool GetPerson(Person person)
        {
            return person.Salary > 1000;
        }

        public static string ShowPerson(Predicate<Person> func, Person person)
        {
            if (func(person))
            {
                return $"{person.Name} {person.Surname} {person.Address}";
            }

            return null;
        }
        #endregion



        #region GetArithmeticMeanSalary
        public static double GetArithmeticMeanSalary(List<Employee> employees)
        {
            double salary = 0;
            double arithmeticMeanSalary = 0;
            int count = 0;

            foreach (var item in employees)
            {
                if (item.Age > 20 && item.Age < 40)
                {
                    count++;
                    salary += item.Salary;
                    arithmeticMeanSalary = salary / count;
                }
            }

            return arithmeticMeanSalary;
        }

        public static double ShowSalary(Func<List<Employee>, double> func, List<Employee> employees)
        {
            return func(employees);
        }
        #endregion


        #region Nizami
        //Book book1 = new Book();
        //book1.Author = "Nizami Ganjavi";

        //Book book2 = new Book();
        //book2.Author = "Lala";

        //Book book3 = new Book();
        //book3.Author = "Ehmed";

        //List<Book> books = new List<Book>();

        //books.Add(book1);
        //books.Add(book2);
        //books.Add(book3);

        //Console.WriteLine(ShowBookCount(CheckBookAuthor, books));
        #endregion
        #region NizamiBooks
        public static bool CheckBookAuthor(Book book)
        {
            return book.Author == "Nizami";
        }

        public static int ShowBookCount(Predicate<Book> func, List<Book> book)
        {
            int count = 0;

            foreach (var item in book)
            {
                if (item.Author == "Nizami")
                {
                    count++;
                }
            }

            return count;
        }
        #endregion
    }
}