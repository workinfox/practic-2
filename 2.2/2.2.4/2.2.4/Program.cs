namespace _2._2._4;

class Counter
{
    private int value;

    public Counter()
    {
        value = 0;
    }

    public Counter(int startValue)
    {
        value = startValue;
    }

    public void Increment()
    {
        value++;
    }

    public void Decrement()
    {
        value--;
    }

    public int Value
    {
        get { return value; }
    }
}

class Program
{
    static void Main()
    {
        Counter counter1 = new Counter(); // создание счетчика со значением по умолчанию
        Counter counter2 = new Counter(64); // создание счетчика с произвольным значением

        Console.WriteLine("Значение счётчика 1: " + counter1.Value); // выводим текущее значение счетчика 1
        Console.WriteLine("Значение счётчика 2: " + counter2.Value); // выводим текущее значение счетчика 2

        counter1.Increment(); // увеличиваем значение счетчика 1 на 1
        counter2.Decrement(); // уменьшаем значение счетчика 2 на 1

        Console.WriteLine("Значение счётчика 1 после увеличения: " + counter1.Value); // выводим текущее значение счетчика 1
        Console.WriteLine("Значение счётчика 2 после увеличения: " + counter2.Value); // выводим текущее значение счетчика 2
    }
}
