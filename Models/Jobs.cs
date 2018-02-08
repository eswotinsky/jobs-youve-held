using System.Collections.Generic;
using System;

namespace JobHistory.Models
{
    public class Job
    {
        private string _title;
        private string _company;
        private string _dates;
        private string _description;
        private int _id;
        private static List<Job> _myJobs = new List<Job> {};

        public Job (string title, string company, string dates, string description)
        {
            _title = title;
            _company = company;
            _dates = dates;
            _description = description;
            _myJobs.Add(this);
            _id = _myJobs.Count;
        }

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string newTitle)
        {
            _title = newTitle;
        }

        public string GetCompany()
        {
            return _company;
        }

        public void SetCompany(string newCompany)
        {
            _title = newCompany;
        }

        public string GetDates()
        {
            return _dates;
        }

        public void SetDates(string newDates)
        {
            _dates = newDates;
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string newDescription)
        {
            _description = newDescription;
        }

        public static List<Job> GetAll()
        {
            return _myJobs;
        }

        public static Job Find(int searchId)
        {
            return _myJobs[searchId-1];
        }

        public int GetId()
        {
            return _id;
        }
    }
}
