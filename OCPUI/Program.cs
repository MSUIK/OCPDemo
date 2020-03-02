using OCPLibraty;
using System;
using System.Collections.Generic;

namespace OCPUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicentModel> applicants = new List< IApplicentModel>
            {
                new PersonModel{FirstName="Tim", LastName= "Coery"},
                new ManagerModel{ FirstName="Sufyan", LastName="Iqbal"},
                new ExavitiveModel { FirstName="Arslan", LastName ="Ali"}
            };

            List<EmployModel> employees = new List<EmployModel>();
            foreach(var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }
            foreach(var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName}  {emp.LastName} : {emp.EmailAddress} IsManager :{emp.IsManager} IsExacitive :{emp.IsExacitive } ");
            }
            Console.ReadLine();

        }
    }
}
