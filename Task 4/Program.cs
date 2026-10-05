public class Task4
{
    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Array.Sort(numbers);
        Array.Reverse(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        
        int position = Array.IndexOf(numbers, 5);
        Console.WriteLine(position);
    }
}