using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Proyectionist";
        job1._company = "Cinepolis";
        job1._startYear = 2018;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Customer services representative";
        job2._company = "IHG";
        job2._startYear = 2020;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Manfredy Escobar";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}