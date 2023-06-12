using System;

class Program
{
    static void Main(string[] args)
    {
        Jobs job1 = new Jobs();
        job1._jobTitle  = "Software Engineering";
        job1._company = "Apple";
        job1._startYear =  2023;
        job1._endYear = 2024;

        job1.displayJob();
        Console.WriteLine("");
        Console.WriteLine("----------------");

        Jobs job2 = new Jobs();
        job2._jobTitle  = "project manager";
        job2._company = "Nasa";
        job2._startYear =  2024;
        job2._endYear = 2025;
        // job2.displayJob();


        Resume resume = new Resume();
        resume._name  = "Erubami Okeoghene Godstime";
        resume._job.Add(job1);
        resume._job.Add(job2);
        // Console.WriteLine(resume._job[0]._jobTitle);
        
        resume.displayResume();


    }

}