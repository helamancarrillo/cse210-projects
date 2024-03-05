using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        // Job class


        //Job 1 

        Job job1 = new Job(); //always start using this
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2021; 
        //job1.Display();  

        
        // job 2 
        Job job2 = new Job();  //always start using this
        job2 = new Job(); 
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2021;
        job2._endYear = 2023;
        //job2.Display();

        // Resume class

        //initializers

        Resume resume = new Resume(); 

        resume._name = "Allison Rose";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display(); 


    }
}