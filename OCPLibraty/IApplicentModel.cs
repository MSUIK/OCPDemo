namespace OCPLibraty
{
    public interface IApplicentModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
         IAccounts AccountProcessor { get; set; } 
    }         
}