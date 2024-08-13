Console.WriteLine("Hello, World!");

ref struct ClassOne
{
    public int Current => 0;
    public bool MoveNext() => false;
    public void Dispose() { }
}
class ClassTwo
{
    public ClassOne GetEnumerator() => new ClassOne();
    async void M()
    {
        await Task.Yield();
        using (new ClassOne()) { }
        lock (new System.Threading.Lock()) { }
        await Task.Yield();
    }
}