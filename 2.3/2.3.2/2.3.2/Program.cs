namespace _2._3._2;

class Worker
{
    private string name;
    private string surname;
    private double rate;
    private int days;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetSurname(string surname)
    {
        this.surname = surname;
    }

    public string GetSurname()
    {
        return surname;
    }

    public void SetRate(double rate)
    {
        this.rate = rate;
    }

    public double GetRate()
    {
        return rate;
    }

    public void SetDays(int days)
    {
        this.days = days;
    }

    public int GetDays()
    {
        return days;
    }

    public double Salary()
    {
        return rate * days;
    }
}

class Program
{
    static void Main()
    {
        Worker worker1 = new Worker();
        worker1.SetName("Арина");
        worker1.SetSurname("Кротова");
        worker1.SetRate(12);
        worker1.SetDays(30);
        
        Console.WriteLine($"Работник {worker1.GetSurname()} {worker1.GetName()} заработал ${worker1.Salary()}");

        Worker worker2 = new Worker();
        worker2.SetName("Дилнур");
        worker2.SetSurname("Джарышбекова");
        worker2.SetRate(12.75);
        worker2.SetDays(20);

        Console.WriteLine($"Работник {worker2.GetSurname()} {worker2.GetName()} заработал ${worker2.Salary()}");
        
        Worker worker3 = new Worker();
        worker3.SetName("Денис");
        worker3.SetSurname("Кочергин");
        worker3.SetRate(12.85);
        worker3.SetDays(30);

        Console.WriteLine($"Работник {worker3.GetSurname()} {worker3.GetName()} заработал ${Math.Round(worker3.Salary())}");
        
        Worker worker4 = new Worker();
        worker4.SetName("Дарья");
        worker4.SetSurname("Бикшанова");
        worker4.SetRate(9.3);
        worker4.SetDays(28);

        Console.WriteLine($"Работник {worker4.GetSurname()} {worker4.GetName()} заработал ${Math.Round(worker4.Salary())}");
        
        Worker worker5 = new Worker();
        worker5.SetName("Ксения");
        worker5.SetSurname("Никонова");
        worker5.SetRate(14);
        worker5.SetDays(29);

        Console.WriteLine($"Работник {worker5.GetSurname()} {worker5.GetName()} заработал ${Math.Round(worker5.Salary())}");
    }
}