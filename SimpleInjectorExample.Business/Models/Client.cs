using System;

namespace SimpleInjectorExample.Business.Models
{
    public class Client
    {
        public Client(int id, string firstName, string lastName, int age, DateTime birthDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            BirthDate = birthDate;
        }
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public DateTime BirthDate { get; private set; }
    }
}
