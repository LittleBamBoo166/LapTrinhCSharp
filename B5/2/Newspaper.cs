using System;

namespace _2
{
    class Newspaper:Document
    {
        private int dayIssue;

        public Newspaper(string id, string publisher, int number, int dayIssue):base(id, publisher, number)
        {
            this.dayIssue = dayIssue;
        }
    }
}