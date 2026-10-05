public class Task6
{
    public static void Main()
    {
        List<string> fruits = new List<string>();
        
        fruits.Add("Apple");
        fruits.Add("Mango");
        fruits.Add("Banana");
        fruits.Add("Orange");
        
        fruits.Remove("Banana");
        
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>();

        fruitDictionary.Add(1, "Apple");
        fruitDictionary.Add(2, "Mango");
        fruitDictionary.Add(3, "Banana");
        fruitDictionary.Add(4, "Orange");
        
        foreach (var fruit in fruitDictionary)
        {
            Console.WriteLine($"ID: {fruit.Key}, Name: {fruit.Value}");
        }
    }
}