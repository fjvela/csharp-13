// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class ClassLockOne
{
    private object myLock = new object();

    public void MyMethod()
    {
        lock (myLock)
        {
            // Your code
        }
    }
}

public class ClassLockTwo
{
    // The following line is the only change
    private System.Threading.Lock myLock = new System.Threading.Lock();

    public void MyMethod()
    {
        lock (myLock)
        {
            // Your code
        }
    }
}