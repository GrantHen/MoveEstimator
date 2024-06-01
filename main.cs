using System;

class Program {
    public static void Main (string[] args) {
        Console.WriteLine("How many miles is the property?");
        string milesInput = Console.ReadLine();
        double miles;
        if (!double.TryParse(milesInput, out miles)) {
            Console.WriteLine("Please enter a valid number for miles:");
            milesInput = Console.ReadLine();
        }

        Console.WriteLine("How many hours did the job take?");
        string hoursInput = Console.ReadLine();
        double hours;
        if (!double.TryParse(hoursInput, out hours)) {
            Console.WriteLine("Please enter a valid number for hours:");
            hoursInput = Console.ReadLine();
        }

        double cost = (miles * 2) + 200 + (hours * 150);
        Console.WriteLine("$" + cost);
    }
}
