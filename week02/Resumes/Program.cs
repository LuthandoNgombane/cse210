using System;

//LN - Import the namespace where Job and Resume exist
using Resumes; 

class Program
{
    static void Main(string[] args)
    {
        //LN - Instantiate two job objects
        Job job1 = new Job { _jobTitle = "Software Engineer", _company = "Microsoft", _startYear = 2019, _endYear = 2022 };
        Job job2 = new Job { _jobTitle = "Manager", _company = "Apple", _startYear = 2022, _endYear = 2023 };

        //LN - Instantiate a resume object
        Resume myResume = new Resume { _name = "Allison Rose" };
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //LN - Display the resume
        myResume.Display();
    }
}