namespace _2._2._3;

class Numbers
{
    public int Num1 { get; set; }
    public int Num2 { get; set; }

    public void DisplayNum()
    {
        Console.WriteLine($"Первое число: {Num1}");
        Console.WriteLine($"Второе число: {Num2}");
    }
    
    public void ChangeNum(int newNum1, int newNum2)
    {
        Num1 = newNum1;
        Num2 = newNum2;
    }

    public int SumNum()
    {
        return Num1 + Num2;
    }

    public int MaxNum()
    {
        return Math.Max(Num1, Num2);
    }
}


class Program
{
    static void Main()
    {
        Numbers num = new Numbers();
        
        num.ChangeNum(17, 45);
        
        Console.WriteLine("Исходные числа: ");
        num.DisplayNum();
        
        Console.WriteLine($"Сумма чисел: {num.SumNum()}");
        Console.WriteLine($"Наибольшее число: {num.MaxNum()}");

        num.ChangeNum(60, 150);

        Console.WriteLine("Измененные числа:");
        num.DisplayNum();

        Console.WriteLine($"Сумма чисел: {num.SumNum()}");
        Console.WriteLine("Наибольшее число: " + num.MaxNum());
        
    }
}
