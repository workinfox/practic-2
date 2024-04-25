using Npgsql;
using System;

namespace laba25;

public static class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Программы:");
            Console.WriteLine("[1] - Редактировать данные");
            Console.WriteLine("[2] - Посмотреть данные");
            Console.WriteLine("[0] - Завершить работу");
            string? command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "1":
                    Console.Clear();
                    Edit();
                    continue;
                case "2":
                    Console.Clear();
                    Get();
                    continue;
                case "0":
                    Console.Clear();
                    Console.WriteLine("Завершить работу");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    continue;
            }

            break;
        }
    }

    private static void Get()
    {
        while (true)
        {
            Console.WriteLine("Просмотреть:");
            Console.WriteLine("[1] - Типы автомобилей");
            Console.WriteLine("[2] - Автомобили");
            Console.WriteLine("[3] - Водители");
            Console.WriteLine("[4] - Категории прав");
            Console.WriteLine("[5] - Права у водителя");
            Console.WriteLine("[6] - Маршруты");
            Console.WriteLine("[7] - Рейсы");
            Console.WriteLine("[0] - Выход");
            string? command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "1":
                    Console.Clear();
                    DatabaseRequests.GetTypeCarQuery();
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "2":
                    Console.Clear();
                    DatabaseRequests.GetTypeCarQuery();
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "3":
                    Console.Clear();
                    DatabaseRequests.GetDriverQuery();
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "4":
                    Console.Clear();
                    DatabaseRequests.GetRightsCategoryQuery();
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "5":
                    Console.Clear();
                    GetRights();
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "6":
                    Console.Clear();
                    DatabaseRequests.GetItineraryQuery();
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "7":
                    Console.Clear();
                    DatabaseRequests.GetRouteQuery();
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "0":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("ОШИБКА!");
                    continue;
            }

            break;
        }
    }

    private static void GetRights()
    {
        Console.Write("Введите Id водителя: ");
        int id = int.Parse(Console.ReadLine() ?? string.Empty);
        DatabaseRequests.GetDriverRightsCategoryQuery(id);
    }

    private static void Edit()
    {
        while (true)
        {
            Console.WriteLine("Добавить:");
            Console.WriteLine("[1] - Типы автомобилей");
            Console.WriteLine("[2] - Автомобили");
            Console.WriteLine("[3] - Водители");
            Console.WriteLine("[4] - Категории прав");
            Console.WriteLine("[5] - Права у водителя");
            Console.WriteLine("[6] - Маршруты");
            Console.WriteLine("[7] - Рейсы");
            Console.WriteLine("[0] - Выход");
            string? command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "1":
                    Console.Clear();
                    AddCarType();
                    Console.Clear();
                    continue;
                case "2":
                    Console.Clear();
                    AddCar();
                    Console.Clear();
                    continue;
                case "3":
                    Console.Clear();
                    AddDriver();
                    Console.Clear();
                    continue;
                case "4":
                    Console.Clear();
                    AddRights();
                    Console.Clear();
                    continue;
                case "5":
                    Console.Clear();
                    AddDriverRights();
                    Console.Clear();
                    continue;
                case "6":
                    Console.Clear();
                    AddItinerary();
                    Console.Clear();
                    continue;
                case "7":
                    Console.Clear();
                    AddRoute();
                    Console.Clear();
                    continue;
                case "0":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("ОШИБКА!");
                    continue;
            }

            break;
        }
    }

    private static void AddCarType()
    {
        Console.Write("Введите новый тип автомобиля: ");
        DatabaseRequests.AddTypeCarQuery(Console.ReadLine() ?? string.Empty);
    }
    
    private static void AddCar()
    {
        try
        {
            Console.Write("Введите Id типа автомобиля: ");
            int id = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.Write("Введите название автомобиля: ");
            string name = Console.ReadLine() ?? string.Empty;
            Console.Write("Введите номера автомобиля: ");
            string number = Console.ReadLine() ?? string.Empty;
            Console.Write("Введите число пассажиров: ");
            int capacity = int.Parse(Console.ReadLine() ?? string.Empty);
            
            DatabaseRequests.AddCarsQuery(id, name, number, capacity);
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
    }
    
    private static void AddDriver()
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine() ?? string.Empty;
        Console.Write("Введите фамилию: ");
        string surname = Console.ReadLine() ?? string.Empty;
        Console.Write("Введите дату рождения (yyyy.mm.dd): ");
        string birthday = Console.ReadLine() ?? string.Empty;
        try
        {
            DatabaseRequests.AddDriverQuery(name, surname, DateTime.Parse(birthday));
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
    }
    
    private static void AddDriverRights()
    {
        try
        {
            Console.Write("Введите Id водителя: ");
            int driver = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Введите Id категории: ");
            int rights = int.Parse(Console.ReadLine() ?? "0");
            DatabaseRequests.AddDriverRightsCategoryQuery(driver, rights);
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
    }
    
    private static void AddRights()
    {
        Console.Write("Введите категорию: ");
        string name = Console.ReadLine() ?? string.Empty;
        DatabaseRequests.AddRightsCategoryQuery(name);
    }
    
    private static void AddItinerary()
    {
        Console.Write("Введите маршрут: ");
        string name = Console.ReadLine() ?? string.Empty;
        DatabaseRequests.AddItineraryQuery(name);
    }

    private static void AddRoute()
    {
        try
        {
            Console.Write("Введите Id водителя: ");
            int driver = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Введите Id автомобиля: ");
            int car = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Введите Id маршрута: ");
            int itinerary = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Введите число пассажиров: ");
            int number = int.Parse(Console.ReadLine() ?? "0");
            
            DatabaseRequests.AddRouteQuery(driver, car, itinerary, number);    
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
    }
}