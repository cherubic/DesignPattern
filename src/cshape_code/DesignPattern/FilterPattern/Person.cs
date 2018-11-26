using System;
namespace DesignPattern.FilterPattern
{
    public class Person
    {
        private string name;
        private string gender;
        private string maritalStatus;

        public Person(string name, string gender, string maritalStatus)
        {
            this.name = name;
            this.gender = gender;
            this.maritalStatus = maritalStatus;
        }

        public string GetName()
        {
            return name;
        }

        public string GetGender()
        {
            return gender;
        }

        public string GetMaritalStatus()
        {
            return maritalStatus;
        }
    }
}
