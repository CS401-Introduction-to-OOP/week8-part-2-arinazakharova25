namespace Variant1;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }

    public override void Open()
    {
        if (IsOpen)
        {
            IsOpen = true;
            Console.WriteLine($"Network {Name} opened.");
        }
        else
        {
            Console.WriteLine($"Network {Name} already open.");
        }
    }

    public override void Close()
    {
        if (IsOpen)
        {
            IsOpen = false;
            Console.WriteLine($"Network {Name} closed.");
        }
        else
        {
            Console.WriteLine($"Network {Name} already closed.");
        }
    }

    public void Dispose()
    {
        Close();
        Console.WriteLine($"Network {Name} disposed.");
    }
}