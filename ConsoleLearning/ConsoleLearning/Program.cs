
using System.Security.Cryptography.X509Certificates;




public class TuplesPatten
{
    int AverageCelsiumTemperature(Season season, bool daytime) =>
        (season, daytime) switch
        {
            (Season.Spring, true) => 20,
            (Season.Summer, true) => 25,
            (Season.Fall, true) => 25,
            (Season.Winter, true) => 20,
            (Season.Spring, false) => 10,
            (Season.Summer, false) => 15,
            (Season.Fall, false) => 15,
            (Season.Winter, false) => 10,
        };


    enum Season
    {
        Spring,
        Summer,
        Fall,
        Winter
    }
    
    string Print (object obj) => obj switch
    {
        Point (0,0) => "Empty Point",
        Point (var x, var y) when x == y => "Diagonal"
    };
    record Point(int X, int Y);
}

