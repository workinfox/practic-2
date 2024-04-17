namespace _2._2._2;

class Train
{
    public string DestinationName { get; set; }
    public string TrainNumber { get; set; }
    public DateTime TimeOfDeparture { get; set; }
    public DateTime ArrivaTime { get; set;  }

    public bool DisplayTrainInfo(string trainNumber)
    {
        if (trainNumber == TrainNumber)
        {
            Console.WriteLine($"Номер поезда: {TrainNumber}");
            Console.WriteLine($"Название пункта назначения: {DestinationName}");
            Console.WriteLine($"Время отправления: {TimeOfDeparture}");
            Console.WriteLine($"Время прибытия: {ArrivaTime}");
            return true; // Возвращаем true, если поезд найден
        }
        return false; // Возвращаем false, если поезд не найден
    }
}

class Program
{
    static void Main( )
    {
        Console.WriteLine("Пункт отправления: Томск");
        
        Train train1 = new Train()
        {
            DestinationName = "Новосибирск",
            TrainNumber = "869H",
            TimeOfDeparture = new DateTime(2024, 04, 15, 6, 55, 0),
            ArrivaTime = new DateTime(2024, 04, 15, 11, 27, 0)
        };

        Train train2 = new Train()
        {
            DestinationName = "Новосибирск",
            TrainNumber = "637H",
            TimeOfDeparture = new DateTime(2024, 04, 15, 12, 55, 0),
            ArrivaTime = new DateTime(2024, 04, 15, 19, 10, 0)
        };
        
        Train train3 = new Train()
        {
            DestinationName = "Анапа",
            TrainNumber = "693H",
            TimeOfDeparture = new DateTime(2024, 04, 15, 13, 34, 0),
            ArrivaTime = new DateTime(2024, 04, 15, 23, 05, 0)
        };
        
        Train train4 = new Train()
        {
            DestinationName = "Анапа",
            TrainNumber = "203H",
            TimeOfDeparture = new DateTime(2024, 04, 15, 13, 34, 0),
            ArrivaTime = new DateTime(2024, 04, 15, 20, 15, 0)
        };
        
        Train train5 = new Train()
        {
            DestinationName = "Бийск",
            TrainNumber = "401H",
            TimeOfDeparture = new DateTime(2024, 04, 15, 16, 02, 0),
            ArrivaTime = new DateTime(2024, 04, 15, 20, 42, 0)
        };

        Train train6 = new Train()
        {
            DestinationName = "Адлер",
            TrainNumber = "115H",
            TimeOfDeparture = new DateTime(2024, 04, 15, 16, 02, 0),
            ArrivaTime = new DateTime(2024, 04, 15, 20, 42, 0)
        };

        Console.Write("Введите номер поезда для отображения его информации: ");
        string userInput = (Console.ReadLine());

        train1.DisplayTrainInfo(userInput);
        train2.DisplayTrainInfo(userInput);
        train3.DisplayTrainInfo(userInput);
        train4.DisplayTrainInfo(userInput);
        train5.DisplayTrainInfo(userInput);
        train6.DisplayTrainInfo(userInput);
    }
}
