namespace GenericsPractice.Entities
{
    /// <summary>
    /// More specific class than employee
    /// </summary>
    public class Manager : Employee
    {
        public override string ToString()
        {
            return base.ToString() + " (Manager)";
        }
    }
}
