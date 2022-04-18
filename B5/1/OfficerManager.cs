using System;
using System.Collections.Generic;

namespace _1
{
    class OfficerManager
    {
        private List<Officer> officers;

        public OfficerManager()
        {
            this.officers = new List<Officer>();
        }

        public void addOfficer(Officer officer)
        {
            this.officers.Add(officer);
        }

        public List<Officer> searchOfficerByName(string name)
        {
            List<Officer> resultList = officers.FindAll(officer => officer.getName() == name);
            return resultList;
        }

        public void showListInforOfficer()
        {
            foreach (Officer officer in officers)
            {
                Console.WriteLine(officer.ToString());
            }
        }
    }
}