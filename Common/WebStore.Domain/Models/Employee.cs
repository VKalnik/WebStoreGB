namespace WebStore.Domain.Models
{
    /// <summary>Информация о сотруднике</summary>
    public class Employee
    {
        /// <summary>Идентификатор сотрудника</summary>
        public int Id { get; set; }

        /// <summary>Имя сотрудника</summary>
        public string FirstName { get; set; }

        /// <summary>Фамилия сотрудника</summary>
        public string LastName { get; set; }

        /// <summary>Отчество сотрудника</summary>
        public string Patronymic { get; set; }

        /// <summary>Возраст сотрудника</summary>
        public int Age { get; set; }

        public override string ToString() => $"[{Id}] {LastName} {FirstName} {Patronymic} ({Age})";
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
