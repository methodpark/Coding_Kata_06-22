namespace CSharpKata;

public class Example
{
    private readonly IRandomize _randomizer;

    public Example(IRandomize? randomizer = null)
    {
        _randomizer = randomizer ?? new Randomizer();
    }

    public string GetRandomString() =>
        $"Your random number is {_randomizer.GetRandomNumber()}.";

    public static int Double(int x = 0) => x * 2;

    public static double Distance(Coordinate c1, Coordinate c2)
    {
        var (x1, y1) = c1;
        var (x2, y2) = c2;
        var deltaX = x2 - x1;
        var deltaY = y2 - y1;
        return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
    }
}

public interface IRandomize
{
    public int GetRandomNumber();
}

public class Randomizer : IRandomize
{
    private readonly Random _randomizer = new();

    public int GetRandomNumber()
    {
        return _randomizer.Next(1, 100);
    }
}

public record struct Coordinate(double X, double Y);
