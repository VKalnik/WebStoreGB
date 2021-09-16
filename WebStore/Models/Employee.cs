using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public int Age { get; set; }
    }

    //public record Employee2(int Id, string LastName, string FirstName, string Patronymic, int Age);

    //public class Employee2
    //{
    //    public int Id { get; init; }

    //    public string FirstName { get; init; }

    //    public string LastName { get; init; }

    //    public string Patronymic { get; init; }

    //    public int Age { get; init; }

    //}
}
