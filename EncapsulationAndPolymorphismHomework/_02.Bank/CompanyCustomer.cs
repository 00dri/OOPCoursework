namespace _02.Bank
{
    public class CompanyCustomer :Customer
    {
        private string companyName;

        public CompanyCustomer(string id, string companyName) 
            : base(id)
        {
            this.CompanyName = companyName;
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} ID:{1}", this.CompanyName, this.Id);
        }
    }
}
