using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exerciseList = new List<Exercise>();
        
        Running running = new Running("December 8, 2023", 30, 4.8);
        exerciseList.Add(running);

        StationaryBicycles stationaryBicycles = new StationaryBicycles("December 10, 2023", 60, 15);
        exerciseList.Add(stationaryBicycles);

        Swimming swimming = new Swimming("December 28, 2023", 20, 20);
        exerciseList.Add(swimming);

        Console.WriteLine("Exercises:");
        Console.WriteLine();

        foreach (Exercise exercise in exerciseList) 
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}