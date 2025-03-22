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
        PhysicalTherapy._showJob();

        Resume resume = new Resume();
        resume._name = "Joseph Garlick";

        resume._Jobs.Add("Physical Therapy technition");
        resume._Jobs.Add("Physical Therapy Assistant");
        resume._Jobs.Add("Physical Therapist");
        resume._Jobs.Add("Shop Fabricator");
        resume._Jobs.Add("Missionary");
        resume._resumeDesplay();
    }
}