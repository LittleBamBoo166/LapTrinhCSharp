using System;

namespace _1
{
    public class Officer
    {
        protected string name;
        protected int age;
        protected string gender;
        protected string address;

        public Officer(string name, int age, string gender, string address)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public string getGender()
        {
            return gender;
        }

        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public string getAddress()
        {
            return address;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }
    }
}