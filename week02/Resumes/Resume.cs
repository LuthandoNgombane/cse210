//LN : Resume Class
using System;
using System.Collections.Generic;

//LN - create a namespace so program.cs can access the classes
namespace Resumes
{
    public class Resume
    {
        // LN - Declare person's name variable
        public string _name;
        
        // LN - Declare list to store jobs
        public List<Job> _jobs = new List<Job>();

        // LN - Method to display resume details
        public void Display()
        {
            // LN - Print the name of the person
            Console.WriteLine($"Name: {_name}");
            
            // LN - Print the Jobs section
            Console.WriteLine("Jobs:");
            
            // LN - Loop through each job in the list and display it
            foreach (Job job in _jobs)
            {
                job.Display();
            }
        }
    }
}