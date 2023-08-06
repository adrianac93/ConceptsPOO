namespace ConceptsPOO
{
    public abstract class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Date Birthdate { get; set; }

        public Date Hiringdate { get; set; }

        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName}," +
                $" Birth: {Birthdate}, " +
                $"Hiring: {Hiringdate}, " +
                $"Is active: {IsActive}";
        }
    }
}