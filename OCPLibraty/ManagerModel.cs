using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibraty
{
    public class ManagerModel : IApplicentModel
    {
        public string FirstName { get ; set; }
        public string LastName { get ; set ; }
        public IAccounts AccountProcessor { get; set; } = new MangerAccounts();
    }
}
