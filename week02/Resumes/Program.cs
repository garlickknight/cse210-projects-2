using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job PhysicalTherapy = new Job();
        PhysicalTherapy._company = "Saratoga Physical Therapy and Sports Medicine";
        PhysicalTherapy._jobTitle = "Physical Therapist";
        PhysicalTherapy._startYear = 2023;
        PhysicalTherapy._endYear = 2026;
        // PhysicalTherapy._showJob();
        Job crumblBaker = new Job();
        crumblBaker._company = "Crumbl";
        crumblBaker._jobTitle = "Baker";
        crumblBaker._startYear = 2023;
        crumblBaker._endYear = 2025;
        // crumblBaker._showJob();
        

        Resume resume = new Resume();
        resume._name = "Joseph Garlick";
        resume._Jobs.Add(PhysicalTherapy);
        resume._Jobs.Add(crumblBaker);
        resume._resumeDisplay();

        // resume._Jobs.Add("Physical Therapy technition");
        // resume._Jobs.Add("Physical Therapy Assistant");
        // resume._Jobs.Add("Physical Therapist");
        // resume._Jobs.Add("Shop Fabricator");
        // resume._Jobs.Add("Missionary");
    }
}