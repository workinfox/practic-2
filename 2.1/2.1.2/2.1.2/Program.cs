using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] candidates1 = {2, 5, 2, 1, 2 };
        int[] candidates2 = { 10, 1, 2, 7, 6, 1, 5 };

        int target1 = 5;
        int target2 = 8;

        Console.WriteLine("Результат 1 ввода: ");
        PrintComb(CombSum2(candidates1, target1));

        Console.WriteLine(" ");
            
        Console.WriteLine("Результат 2 ввода: ");
        PrintComb(CombSum2(candidates2, target2));
    }

    public static IList<List<int>> CombSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);

        IList<List<int>> result = new List<List<int>>();

        FindComb(candidates, target, 0, new List<int>(), result);
        return result;
    }

    public static void FindComb(int[] candidates, int target, int beginofarray, List<int> current, IList<List<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = beginofarray; i < candidates.Length; i++)
        {
            // Пропускаем дубликаты
            if (i > beginofarray && candidates[i] == candidates[i - 1])
            {
                continue;
            }

            if (candidates[i] > target)
            {
                break;
            }

            current.Add(candidates[i]);

            // Рекурсивно ищем комбинации с новым target и начальным индексом i + 1
            FindComb(candidates, target - candidates[i], i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }


    public static void PrintComb(IList<List<int>> combinations)
    {
        Console.WriteLine("[");

        foreach (var comb in combinations)
        {
            Console.Write("[");
            Console.Write(String.Join(",", comb));
            Console.WriteLine("]");
        }
        Console.WriteLine("]");
    }
}
