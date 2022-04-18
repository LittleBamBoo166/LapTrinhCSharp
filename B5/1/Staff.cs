using System;

namespace _1
{
    class Staff : Officer
    {
        private string task;

        public Staff(string name, int age, string gender, string address, string task) : base(name, age, gender, address)
        {
            this.task = task;
        }

        public string getTask()
        {
            return task;
        }

        public void setTask(string task)
        {
            this.task = task;
        }

        public override string ToString()
        {
            return "Staff{" +
                "task='" + task + '\'' +
                ", name='" + name + '\'' +
                ", age=" + age +
                ", gender='" + gender + '\'' +
                ", address='" + address + '\'' +
                '}';
        }
    }
}