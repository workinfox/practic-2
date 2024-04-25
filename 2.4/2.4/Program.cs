namespace _2._4;

class Program
{
    static void Main()
    {
        //выводим таблицу соответствия римских цифр и их значений
        Console.WriteLine("Символ       Значение");
        Console.WriteLine(" I               1");
        Console.WriteLine(" V               5");
        Console.WriteLine(" X               10");
        Console.WriteLine(" L               50");
        Console.WriteLine(" C               100");
        Console.WriteLine(" D               500");
        Console.WriteLine(" M               1000");
        
        Console.Write("Введите римское число: ");
        string input = Console.ReadLine(); //просим пользователя ввести число
        
        //преобразуем римское число в целочисленное значение с помощью метода NumToInt и выводим результат
        
        int result = NumToInt(input);
        Console.WriteLine($"Результат: {result}");
    }

    // метод для преобразования римского числа в целое число
    public static int NumToInt(string s)
    {
        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i < s.Length - 1 && CharToValue(s[i]) < CharToValue(s[i + 1]))
            {
                result -= CharToValue(s[i]);
            }
            else
            {
                result += CharToValue(s[i]);
            }
        }

        return result;
    }

    // метод для получения значения римской цифры
    public static int CharToValue(char c)
    {
        switch (c)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
}