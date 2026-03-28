namespace Variant2;
public static class BoxingTester
{
    public static void Test()
    {
        int a = 10; // value type stored in stack
        
        // 1. box a into object
        object b = a; //new object created in heap, a and b are independent
        
        // 2. unbox back into int
        int c = (int)b; // take value from heap, now it is in stack again
        
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}