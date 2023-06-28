using System.Collections;

namespace CsharpTrainingTesting.App;

public class Location
{
    public double La { get; set; }
    public double Lo { get; set; }
}

public class RouteCalculator
{
    public static List<Location> CalculateRoute(List<Location> ls)
    {
        List<Location> r = new List<Location>();
        var o = ls.OrderBy(l => l.Lo).ToArray();

        for (int i = 0; i < ls.Count; i++)
        {
            r.Add(o[i]);
        }

        return o.ToList();
    }
}
