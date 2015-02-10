namespace _02.Bank
{
    public class IndividualCustomer :Customer
    {
        private string firstName;
        private string lastName;

        public IndividualCustomer(string id, string firstName, string lastName) 
            : base(id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} ID:{2}", this.FirstName, this.LastName, this.Id);
        }
    }
}
