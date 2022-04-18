using System;

namespace _2
{
    public class Document
    {
        protected string id;
        protected string publisher;
        protected int number;

        public Document(string id, string publisher, int number)
        {
            this.id = id;
            this.publisher = publisher;
            this.number = number;
        }

        public string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string getPublisher()
        {
            return publisher;
        }

        public void setPublisher(string publisher)
        {
            this.publisher = publisher;
        }

        public int getNumber()
        {
            return number;
        }

        public void setNumber()
        {
            this.number = number;
        }
    }
}