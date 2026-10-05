public class Circle
{
    const double PI = 3.14;

    public class program
    {
        public static void Main()
        {
            Console.WriteLine(Circle.PI);
            Circle.PI = 4;
        }
    }
}