// See https://aka.ms/new-console-template for more information


var countdown = new TimerRemaining(10)
{
    Buffer =
    {
        [^1] = 0,
        [^10] = 9
    }
};

Console.WriteLine($"First: {countdown.Buffer.First()} Last: {countdown.Buffer.Last()}");
Console.ReadLine();


class TimerRemaining(int bufferSize)
{
    public int[] Buffer  { get; set; } = new int[bufferSize];
}