namespace GenericsPractice.Entities
{
    public class Employee : EntityBase
    {
        public Employee()
        {

        }
        public Employee(string firstName)
        {

        }
        public string? FirstName { get; set; }

        public override string ToString() => $"Id: {Id}, FirstName: {FirstName}";
    }
}
