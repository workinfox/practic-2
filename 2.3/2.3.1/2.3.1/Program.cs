namespace _2._3._1;

class Worker
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public double Rate { get; set; }
    public int Days { get; set; }

    public double Salary()
    {
        return Rate * Days;
    }
}

class Program
{
    static void Main()
    {
        Worker worker1 = new Worker();
        worker1.Name = "Арина";
        worker1.Surname = "Кротова";
        worker1.Rate = 12;
        worker1.Days = 30;

        Console.WriteLine($"Работник {worker1.Surname} {worker1.Name}  ${Math.Round(worker1.Salary())}");

        Worker worker2 = new Worker();
        worker2.Surname = "Джарышбекова";
        worker2.Name = "Дилнур";
        worker2.Rate = 12.75;
        worker2.Days = 20;

        Console.WriteLine($"Работник {worker2.Surname} {worker2.Name}  заработал ${Math.Round(worker2.Salary())}");
        
        Worker worker3 = new Worker();
        worker3.Name = "Денис";
        worker3.Surname = "Кочергин";
        worker3.Rate = 12.85;
        worker3.Days = 30;

        Console.WriteLine($"Работник {worker3.Surname} {worker3.Name} заработал ${Math.Round(worker3.Salary())}");
        
        Worker worker4 = new Worker();
        worker4.Name = "Дарья";
        worker4.Surname = "Бикшанова";
        worker4.Rate = 9.3;
        worker4.Days = 28;

        Console.WriteLine($"Работник {worker4.Surname} {worker4.Name} заработал ${Math.Round(worker4.Salary())}");
        
        Worker worker5 = new Worker();
        worker5.Name = "Ксения";
        worker5.Surname = "Никонова";
        worker5.Rate = 14;
        worker5.Days = 29;

        Console.WriteLine($"Работник {worker5.Surname} {worker5.Name} заработал ${Math.Round(worker5.Salary())}");

    }
}