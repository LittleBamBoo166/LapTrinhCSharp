using System;

namespace _1
{
    class Worker : Officer
    {
        private int level;

        public Worker(string name, int age, string gender, string address, int level) : base(name, age, gender, address)
        {
            this.level = level;
        }

        public int getLevel()
        {
            return level;
        }

        public void setLevel(int level)
        {
            this.level = level;
        }

        public override string ToString()
        {
            return "Worker{" +
                "level=" + level +
                ", name='" + name + '\'' +
                ", age=" + age +
                ", gender='" + gender + '\'' +
                ", address='" + address + '\'' +
                '}';
        }
    }
}