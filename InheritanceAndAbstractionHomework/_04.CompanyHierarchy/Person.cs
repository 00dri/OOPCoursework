namespace _04.CompanyHierarchy
{
    using System;

    public abstract class Person : IPerson
    {
        private const string NullIdError = "ID number not entered!";
        private const string NullFirstNameError = "First name not given!";
        private const string NullLastNameError = "Last name not given!";

        private string id;
        private string firstName;
        private string lastName;

        public Person(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Id
        {
            get {
                if (String.IsNullOrEmpty(this.id))
                {
                    throw new ArgumentException(NullIdError);
                }
                return id; 
            }
            set { id = value; }
        }

        public string FirstName
        {
            get {
                if (String.IsNullOrEmpty(this.firstName))
                {
                    throw new ArgumentException(NullFirstNameError);
                }
                return firstName;
            }
            set { firstName = value; }
        }

        public string LastName
        {
            get
            {
                if (String.IsNullOrEmpty(this.lastName))
                {
                    throw new ArgumentException(NullLastNameError);
                } 
                return lastName;
            }
            set { lastName = value; }
        }

        public override string ToString()
        {
            return string.Format("ID: {0}\nName: {1} {2}", this.Id, this.FirstName, this.LastName);
        }
    }
}
