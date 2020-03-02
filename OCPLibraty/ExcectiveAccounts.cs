using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibraty
{
    public class ExcectiveAccounts : IAccounts
    {
        public EmployModel Create(IApplicentModel person)
        {
            EmployModel output = new EmployModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acmeCorp.com";

            output.IsManager = true;
            output.IsExacitive = true;

            return output;
        }
    }
}
