using System;

class Student
{
    public string Surname { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string NumberGroup { get; set; }
    public int[] Grades { get; set; }

    public void ChangeSurname(string newSurname)
    {
        Surname = newSurname;
    }

    public void ChangeDateOfBirth(DateTime newDateOfBirth)
    {
        DateOfBirth = newDateOfBirth;
    }

    public void ChangeNumberGroup(string newNumberGroup)
    {
        NumberGroup = newNumberGroup;
    }

    public void ChangeGrades(int[] newGrades)
    {
        Grades = newGrades;
    }

    public void StudentInfo()
    {
        Console.WriteLine("Информация о студенте:");
        Console.WriteLine("Фамилия: " + Surname);
        Console.WriteLine("Дата рождения: " + DateOfBirth.ToString("dd-MM-yyyy"));
        Console.WriteLine("Номер группы: " + NumberGroup);
        Console.Write("Оценки: ");
        foreach (int grade in Grades)
        {
            Console.Write(grade + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        Console.WriteLine("Введите информацию о студенте:");

        Console.Write("Фамилия: ");
        student.Surname = Console.ReadLine();

        Console.Write("Дата рождения в формате dd-MM-yyyy: ");
        student.DateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

        Console.Write("Номер группы: ");
        student.NumberGroup = Console.ReadLine();

        student.Grades = new int[5]; // Массив оценок из 5 элементов

        bool editInfo = true;

        while (editInfo)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("0 - все готово");
            Console.WriteLine("1 - изменить информацию");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    editInfo = false;
                    break;

                case 1:
                    Console.WriteLine("Выберите, что хотите изменить:");
                    Console.WriteLine("1 - Фамилия");
                    Console.WriteLine("2 - Дата рождения");
                    Console.WriteLine("3 - Номер группы");
                    Console.WriteLine("4 - Оценки");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.Write("Введите новую фамилию: ");
                            student.ChangeSurname(Console.ReadLine());
                            break;

                        case 2:
                            Console.Write("Введите новую дату рождения в формате dd-MM-yyyy: ");
                            student.ChangeDateOfBirth(DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null));
                            break;

                        case 3:
                            Console.Write("Введите новый номер группы: ");
                            student.ChangeNumberGroup(Console.ReadLine());
                            break;

                        case 4:
                            Console.WriteLine("Введите новые оценки (разделите пробелами):");
                            int[] newGrades = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                            student.ChangeGrades(newGrades);
                            break;

                        default:
                            Console.WriteLine("Некорректный выбор.");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Некорректный выбор.");
                    break;
            }
        }

        Console.WriteLine("\nИнформация о студенте после внесенных изменений:");
        student.StudentInfo();
    }
}
