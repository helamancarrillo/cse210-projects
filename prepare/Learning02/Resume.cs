


public class Resume
{
    // member variables or attributes

    public string _name = "";

    public List<Job> _jobs = new List<Job>(); 

    // a special method, called contructor 
    public Resume()
    {

    }

    // methods or functions 

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");


        foreach (Job job in _jobs)
        {
            job.Display();
        }

    }

}