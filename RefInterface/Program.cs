// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MyStructDisposable val = new();
IDisposable d = val;

struct MyStructDisposable: IDisposable
{
    public void Dispose() { }
}