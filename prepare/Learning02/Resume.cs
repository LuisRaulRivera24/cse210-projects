using System.Security.Cryptography.X509Certificates;

public class Resume
{
    public string _name = "Allison Rose";
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.Write("Name: ");
        Console.WriteLine($"{_name}");
        Console.WriteLine("Jobs:");
        foreach (Job j in _jobs)
        {
            j.DisplayJobs();
        }
    }
}