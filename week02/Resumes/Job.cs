//LN : Job Class
using System;

//LN - create a namespace so program.cs can access the classes
namespace Resumes
{
    public class Job
    {
        // LN - Declare job title variable
        public string _jobTitle;
        
        // LN - Declare company name variable
        public string _company;
        
        // LN - Declare start year variable
        public int _startYear;
        
        // LN - Declare end year variable
        public int _endYear;

        // LN - Method to display job details
        public void Display()
        {
            // LN - Print job details in required format
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }
}

