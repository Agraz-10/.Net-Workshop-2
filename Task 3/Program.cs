public class Task3
{
    public static void Main()
    {
        byte a = 10;
        short b = 20;
        int c = 42;
        long d = 1000;
        float e = 3.14f;
        double f = 3.14;
        decimal g = 10.50m;
        char h = 'A';
        Boolean i = true;
        
        string number = c.ToString();
        double numberConvert = double.Parse("3.14");
        
        Console.WriteLine($"byte: {a}");
        Console.WriteLine($"short: {b}");
        Console.WriteLine($"int: {c}");
        Console.WriteLine($"long: {d}");
        Console.WriteLine($"float: {e}");
        Console.WriteLine($"double: {f}");
        Console.WriteLine($"decimal: {g}");
        Console.WriteLine($"char: {h}");
        Console.WriteLine($"bool: {i}");
        Console.WriteLine($"Integer to string: {number}");
        Console.WriteLine($"String to double: {numberConvert}");
    }
}