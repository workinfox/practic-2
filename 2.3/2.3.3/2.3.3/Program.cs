namespace _2._3._3;

class Calculation
{
    public string calculationLine { get; private set; }

    public void SetCalculationLine(string line)
    {
        calculationLine = line;
    }

    public void SetLastSymbolCalculationLine(char symbol)
    {
        calculationLine += symbol;
    }

    public string GetCalculationLine()
    {
        return calculationLine;
    }

    public char GetLastSymbol()
    {
        if (string.IsNullOrEmpty(calculationLine))
        {
            return '\0';
        }
        return calculationLine[calculationLine.Length - 1];
    }

    public void DeleteLastSymbol()
    {
        if (string.IsNullOrEmpty(calculationLine))
        {
            return;
        }
        calculationLine = calculationLine.Remove(calculationLine.Length - 1);
    }
}

class Program
{
    static void Main()
    {
        Calculation calc = new Calculation();
        Console.Write("Введите строку и символ: ");
        calc.SetCalculationLine(Console.ReadLine());

        Console.WriteLine($"Строка: {calc.GetCalculationLine()}");
        Console.WriteLine($"Последний символ: {calc.GetLastSymbol()}");

        calc.SetLastSymbolCalculationLine('3');

        Console.WriteLine($"Обновленная строка: {calc.GetCalculationLine()}");
        Console.WriteLine($"Последний символ: {calc.GetLastSymbol()}");

        calc.DeleteLastSymbol();

        Console.WriteLine($"Строка после удаления последнего символа: {calc.GetCalculationLine()}");
    }
}
