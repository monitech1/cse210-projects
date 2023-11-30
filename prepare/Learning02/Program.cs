using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Job job1 = new Job
        {
            Company = "Microsoft",
            JobTitle = "Software Engineer",
            StartYear = 2019,
            EndYear = 2022
        };

        Job job2 = new Job
        {
            Company = "Apple",
            JobTitle = "Manager",
            StartYear = 2022,
            EndYear = 2023
        };

        Resume resume = new Resume("Monigan Daniel");

        resume.Jobs.Add(job1);
        resume.Jobs.Add(job2);

        string firstJobTitle = resume.Jobs[0].JobTitle;
        Console.WriteLine($"First Job Title: {firstJobTitle}");

        resume.Display();
    }
}
