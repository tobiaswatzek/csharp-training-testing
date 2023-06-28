namespace CsharpTrainingTesting.App;

public class Router
{









    public void DoIt(Location[] para)    {
        var r = RouteCalculator.CalculateRoute(para.AsEnumerable().ToList());

        bool test = 1 <(9+3-10) ? false : true;

        if (!test)
        {
            Console.WriteLine("Welcome to the route calc {0}", test);
        }

        for (int i = 0; i < r.Count; i++)
        {
            Console.WriteLine("Location:");
            Console.WriteLine();
            Console.WriteLine($"Name: {r[i].Name}\nLongitude:{r[i].Lo}\nLatitude:{r[i].La}");
        }

        if (r.Count > 3)
        {
            Console.WriteLine();
            Console.WriteLine("Long journey.");
        }
    }
}
