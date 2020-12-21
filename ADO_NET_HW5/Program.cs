using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET_HW5
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string City { get; set; }

            public override string ToString()
            {
                return $"Name : {Name}, Age : {Age}, City : {City}";
            }
        }
       


        static void Main(string[] args)
        {
            List<Person> person = new List<Person>()
        {
            new Person(){ Name = "Andrey", Age = 24, City = "Kyiv" },
            new Person(){ Name = "Liza", Age = 18, City = "Moscow" },
            new Person(){ Name = "Oleg", Age = 15, City = "London" },
            new Person(){ Name = "Sergey", Age = 55, City = "Kyiv" },
            new Person(){ Name = "Sergey", Age = 32, City = "Kyiv" }
        };

            //==============================================================================================================

            //Выбрать людей, старших 25 лет.
            //var result = from c in person
            //             where c.Age > 25
            //             select new { c.Name, c.Age};

            //var result = person.Where(x => x.Age > 25).OrderBy(x => x.Age).Select(x => new { x.Name, x.Age });

            //==============================================================================================================

            //Выбрать людей, проживающих не в Киеве.

            //var result = from c in person
            //             where c.City != "Kyiv"
            //             select new { c.Name, c.City};

            //var result = person.Where(x => !x.City.StartsWith("K") && !x.City.EndsWith("v")).Select(x => new { x.Name, x.City });

            //==============================================================================================================

            //Выбрать имена людей, проживающих в Киеве.

            //var result = from c in person
            //             where c.City.Equals("Kyiv")
            //             orderby c.Name descending
            //             select new { c.Name, c.City };

            //var result = person.Where(x => x.City.Contains("Kyiv")).Select(x => new { x.Name, x.City });

            //==============================================================================================================

            //Выбрать людей старших 35 лет с именем Sergey.

            //var result = from c in person
            //             where c.Name.Equals("Sergey") && c.Age > 35
            //             select new { c.Name, c.Age };

            //var result = person.Where(x => x.Name.Equals("Sergey") && x.Age > 35);

            //==============================================================================================================

            //Выбрать людей, проживающих в Москве.

            //var result = from c in person
            //             where c.City.Equals("Moscow")
            //             select new { c.Name, c.City};

            //var result = person.Where(x => x.City == "Moscow");

            //==============================================================================================================
            //==============================================================================================================

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
