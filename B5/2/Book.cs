using System;

namespace _2
{
    class Book : Document
    {
        private string author;
        private int pageNumber;

        public Book(string id, string publisher, int number, string author, int pageNumber) : base(id, publisher, number)
        {
            this.author = author;
            this.pageNumber = pageNumber;
        }

        public string getAuthor()
        {
            return author;
        }

        public void setAuthor(string author)
        {
            this.author = author;
        }

        public int getNumerPage()
        {
            return pageNumber;
        }

        public void setNumerPage(int pageNumber)
        {
            this.pageNumber = pageNumber;
        }

        public override string ToString()
        {
            return "Book{" +
                "author='" + author + '\'' +
                ", numerPage=" + pageNumber +
                ", id='" + id + '\'' +
                ", nxb='" + publisher + '\'' +
                ", number='" + number + '\'' +
                '}';
        }
    }
}