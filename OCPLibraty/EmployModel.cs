using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibraty
{
    public class EmployModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsManager { get; set; } = false;
        public bool IsExacitive { get; internal set; }
    }
}
