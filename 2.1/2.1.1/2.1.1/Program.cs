namespace _2._1._1;

class Program
{
    static void Main()
    {
        Console.Write("Введите число J: ");
        string J = Console.ReadLine();
        Console.Write("Введите число S: ");
        string S = Console.ReadLine();

        int count = 0;

        foreach (char sumb in S)
        {
            if (J.Contains(sumb))
            {
                count++;
            }
        }
        
        Console.WriteLine($"Вывод: {count}");
    }
}
