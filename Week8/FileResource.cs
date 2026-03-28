namespace Variant1;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {}
    public override void Open()
    {
        if (!IsOpen)
        {
            IsOpen = true;
            Console.WriteLine($"File {Name} opened.");
        }
    }
    public override void Close()
    {
        if (IsOpen)
        {
            IsOpen = false;
            Console.WriteLine($"File {Name} closed.");
        }
    }
    public void Dispose()
    {
        Close();
        Console.WriteLine($"File {Name} disposed.");
    }
}