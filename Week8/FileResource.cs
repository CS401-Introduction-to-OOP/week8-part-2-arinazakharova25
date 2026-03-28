namespace Variant1;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
    }

    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine($"File {Name} opened.");
    }

    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine($"File {Name} closed.");
    }

    public void Dispose()
    {
        Close();
        Console.WriteLine($"File {Name} disposed.");
    }
}