namespace _03.Animals
{
    using System;
    using System.Collections.Generic;

    public abstract class Animal : ISound
    {
        protected Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        protected Animal()
        {
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public abstract void ProduceSound();

        public override string ToString()
        {
            var info = new List<string>
            {
                "Animal: " + this.GetType(),
                "Name: " + this.Name,
                "Age: " + this.Age,
                "Sex: " + this.Gender
            };

            return String.Join("; ", info);
        }
    }
}
