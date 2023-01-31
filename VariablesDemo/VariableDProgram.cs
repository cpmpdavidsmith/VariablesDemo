namespace VariablesDemo;
class Program
{
    static void Main(string[] args)
    {
        String carName = "Dodge Challenger T/A";
        double year = 18;
        char drive = 'M';
        bool isunder60000 = true;
        int enginesCubicInches = 392;
        decimal cylinderSize = 5.7m;
        string bodyType = "wide body";
        int cylinder = 8;
        int speed = 6;

      Console.WriteLine($"my favorite car is a 20{year} {bodyType} {carName}.");
      Console.WriteLine($"It has a {speed} speed {drive} drive transmission with a \n" +
          $"big {cylinder} under the hood.");
      Console.WriteLine($"With the {enginesCubicInches}'s {cylinderSize}L engine \n " +
          $"I feel like I am in complete control and able to handle anything \n " +
          $"Florida drivers through my way.");
        Console.WriteLine($"and priced at $59,970 you may find yourself asking \n " +
          $"'ALL THIS FOR UNDER' 60,000...\n " +
          $"{isunder60000}");

    }
}

