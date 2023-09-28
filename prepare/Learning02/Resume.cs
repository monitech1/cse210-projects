using System;
using System.Collections.Generic;

public class Resume
{
    public string PersonName { get; set; }
    public List<Job> Jobs { get; set; }

    public Resume(string personName)
    {
        PersonName = personName;
        Jobs = new List<Job>();
    }

    public void Display()
    {
        Console.WriteLine($"Name: {PersonName}");
        Console.WriteLine("Jobs:");
        
        foreach (Job job in Jobs)
        {
            job.DisplayJobDetails();
        }
    }
}
