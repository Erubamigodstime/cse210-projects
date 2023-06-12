using System;

public class Resume
{
    public string _name;
    public List<Jobs> _job = new List<Jobs>();

    public  Resume(){

    }
    public void displayResume(){
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");        
        foreach (Jobs job  in _job )
        {
            
            job.displayJob();
        }

    }
} 