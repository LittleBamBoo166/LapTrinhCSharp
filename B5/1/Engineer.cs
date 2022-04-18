using System;

namespace _1
{
    public class Engineer : Officer
    {
        private string branch;

        public Engineer(string name, int age, string gender, string address, string branch) : base(name, age, gender, address)
        {
            this.branch = branch;
        }

        public string getBranch()
        {
            return branch;
        }

        public void setBranch(string branch)
        {
            this.branch = branch;
        }

        public override string ToString()
        {
            return "Engineer{" +
                "branch='" + branch + '\'' +
                ", name='" + name + '\'' +
                ", age=" + age +
                ", gender='" + gender + '\'' +
                ", address='" + address + '\'' +
                '}';
        }
    }
}