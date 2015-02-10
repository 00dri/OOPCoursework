namespace _01.Persons
{
    using System;

    public class Person
    {
        private const string InvalidInput = "Input is not valid!";

        private string name = string.Empty;
        private int age;
        private string email = string.Empty;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (Validation.IsName(value) && !string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException(InvalidInput);
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (Validation.IsAge(value))
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException(InvalidInput);
                }
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.email = null;
                }
                else if (Validation.IsEmail(value))
                {
                    this.email = value;
                }
                else 
                {
                    throw new ArgumentException(InvalidInput);
                }
            }
        }

        public override string ToString()
        {
            return "Name: " + this.Name + " " + "Age: " + this.Age + " " + "E-mail: " +
                   (string.IsNullOrEmpty(this.Email) ? "N/A" : this.Email);
        }
    }
}
