using System;
using System.Collections.Generic;

namespace Customer
{
    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string id;
        private string permanentAdress;
        private string mobilePhone;
        private string email;
        private List<Payment> paymentsList;
        private CustomerType customerType;

        public Customer(string firstName, 
            string middleName, 
            string lastName, 
            string id, 
            string permanentAdress, 
            string mobilePhone,
            string email,
            List<Payment> paymentsList,
            CustomerType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.PermenantAdress = permanentAdress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.PaymentsList = paymentsList;
            this.CustomerType = customerType;
        }

        private Customer()
        {
        }

        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            if (customer == null)
            {
                return false;
            }
            if (!object.Equals(this.FirstName, customer.FirstName))
            {
                return false;
            }
            if (!object.Equals(this.MiddleName, customer.MiddleName))
            {
                return false;
            }
            if (!object.Equals(this.LastName, customer.LastName))
            {
                return false;
            }
            if (!object.Equals(this.Id, customer.Id))
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^
                   MiddleName.GetHashCode() ^
                   LastName.GetHashCode() ^
                   Id.GetHashCode();
        }

        public int CompareTo(Customer other)
        {
            var fullName = this.FirstName + this.MiddleName + this.LastName;
            var otherFullName = other.FirstName + other.MiddleName + other.LastName;
            return fullName.CompareTo(otherFullName) == 0 ? this.Id.CompareTo(other.Id) : fullName.CompareTo(otherFullName);
        }

        public override string ToString()
        {
            return String.Format("Customer(Name: {0} {1}, ID: {2})", this.FirstName ?? "<unnamed>", this.LastName ?? "<unnamed>", this.Id);
        }

        public static bool operator ==(Customer c1, Customer c2)
        {
            return Customer.Equals(c1, c2);
        }

        public static bool operator !=(Customer c1, Customer c2)
        {
            return !(Customer.Equals(c1, c2));
        }

        public Object Clone()
        {
            var customer = new Customer
            {
                FirstName = this.FirstName,
                MiddleName = this.MiddleName,
                LastName = this.LastName,
                Id = this.Id,
                PermenantAdress = this.PermenantAdress,
                MobilePhone = this.MobilePhone,
                Email = this.Email,
                PaymentsList = new List<Payment>()
            };

            foreach (var payment in this.PaymentsList)
            {
                customer.PaymentsList.Add((Payment)payment.Clone());
            }
            customer.CustomerType = this.CustomerType;

            return customer;
        }

        public CustomerType CustomerType
        {
            get { return customerType; }
            set { customerType = value; }
        }

        public List<Payment> PaymentsList
        {
            get { return paymentsList; }
            set { paymentsList = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string MobilePhone
        {
            get { return mobilePhone; }
            set { mobilePhone = value; }
        }

        public string PermenantAdress
        {
            get { return permanentAdress; }
            set { permanentAdress = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
    }
}
