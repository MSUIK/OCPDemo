using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibraty
{
    public class Accounts
    {
        public EmployModel Create(PersonModel person)
        {
            EmployModel output = new EmployModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(1, 0)}{person.LastName}@acme.com";

            return output;
        }
    }
}
