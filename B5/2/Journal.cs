using System;

namespace _2
{
    class Journal : Document
    {
        private int issueNumber;
        private int monthIssue;

        public Journal(string id, string publisher, int number, int issueNumber, int monthIssue) : base(id, publisher, number)
        {
            this.issueNumber = issueNumber;
            this.monthIssue = monthIssue;
        }

        public int getIssueNumber()
        {
            return issueNumber;
        }

        public void setIssueNumber(int issueNumber)
        {
            this.issueNumber = issueNumber;
        }

        public int getMonthIssue()
        {
            return monthIssue;
        }

        public void setMonthIssue(int monthIssue)
        {
            this.monthIssue = monthIssue;
        }

        public override string ToString()
        {
            return "Journal{" +
                "issueNumber=" + issueNumber +
                ", monthIssue=" + monthIssue +
                ", id='" + id + '\'' +
                ", nxb='" + publisher + '\'' +
                ", number='" + number + '\'' +
                '}';
        }
    }
}