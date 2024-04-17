namespace _2._2._5;

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
        Counter counter1 = new Counter(); 
        Counter counter2 = new Counter(64); 

        Console.WriteLine("Значение счётчика 1: " + counter1.Value); 
        Console.WriteLine("Значение счётчика 2: " + counter2.Value); 
        counter1.Increment(); 
        counter2.Decrement(); 

        Console.WriteLine("Значение счётчика 1 после увеличения: " + counter1.Value); 
        Console.WriteLine("Значение счётчика 2 после увеличения: " + counter2.Value); 
    }
}
