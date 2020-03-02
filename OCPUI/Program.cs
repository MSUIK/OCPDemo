using OCPLibraty;
using System;
using System.Collections.Generic;

namespace OCPUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel{FirstName="Tim", LastName= "Coery"},
                new PersonModel{ FirstName="Sufyan", LastName="Iqbal"},
                new PersonModel { FirstName="Arslan", LastName ="Ali"}
            };

            List<EmployModel> employees = new List<EmployModel>();
            Accounts accountProcessor = new Accounts();
            foreach(var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }
            foreach(var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName}  {emp.LastName} : {emp.EmailAddress}");
            }
            Console.ReadLine();

        }
    }
}
