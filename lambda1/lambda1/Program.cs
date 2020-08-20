using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> employee = new List<Person>();
                employee.Add(new Person() { Id = 1, FirstName = "Joe", LastName = "Smith" });
                employee.Add(new Person() { Id = 2, FirstName = "Jill", LastName = "Smith" });
                employee.Add(new Person() { Id = 3, FirstName = "Jane", LastName = "Smith" });
                employee.Add(new Person() { Id = 4, FirstName = "Josephine", LastName = "Smith" });
                employee.Add(new Person() { Id = 5, FirstName = "Joe", LastName = "Johnson" });
                employee.Add(new Person() { Id = 6, FirstName = "Jen", LastName = "Smith" });
                employee.Add(new Person() { Id = 7, FirstName = "Jessie", LastName = "Smith" });
                employee.Add(new Person() { Id = 8, FirstName = "Jim", LastName = "Smith" });
                employee.Add(new Person() { Id = 9, FirstName = "John", LastName = "Smith" });
                employee.Add(new Person() { Id = 10, FirstName = "Jorge", LastName = "Smith" });


            List<Person> joes = new List<Person>();
            foreach (Person f in employee)
            {
                if (f.FirstName == "Joe")
                {
                    joes.Add(f);
                }
            }
            foreach (Person f in joes)
            {
                Console.WriteLine(f);
            }
            Console.ReadLine();


            List<Person> newList = employee.Where(x => x.FirstName == "Joe").ToList();
            foreach (Person g in newList)
            {
                Console.WriteLine(g);
            }
            Console.ReadLine();



        }
    }
}

