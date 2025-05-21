

using System.Diagnostics;

Loops loops = new Loops();

var max = 1000000000;

Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();
loops.ForLoop(max);
stopwatch.Stop();
Console.WriteLine($"ForLoop executed in: {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Reset();

stopwatch.Start();
loops.WhileLoop(max);
stopwatch.Stop();
Console.WriteLine($"WhileLoop executed in: {stopwatch.ElapsedMilliseconds} ms");

public class Loops
{
    public void ForLoop(long max)
    {
        for (int i = 0; i < max; i++)
        {
            var j = Calculate(i * 2 * Math.PI);
        }
    }

    public void WhileLoop(long max)
    {
        int i = 0;

        while (i < max)
        {
            var j = Calculate(i * 2 * Math.PI);
            i += 1;
        }
    }

    public double Calculate(double x)
    {
        return Math.Sin(x);
    }
}

