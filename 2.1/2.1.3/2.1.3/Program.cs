using System;
using System.Collections.Generic; //доступ к ХашСет


class Program
{
    static bool Check(int[] nums)
    {
        //храним уникальные значения
        HashSet<int> set = new HashSet<int>();


        foreach (int num in nums)
        {
            //
            if (set.Contains(num))
            {
                return true; //одержи, то возвращает тру
            }

            set.Add(num); //если не элемент то отправляется в ХашСет
        }

        return false; //если нет повтора, то Фалс
    }

    static void Main()
    {
        int[] nums1 = { 1, 2, 3, 4 };

        int[] nums2 = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};

        int[] nums3 = {1, 2, 3, 1};
        
        Console.WriteLine(Check(nums1));
        
        Console.WriteLine(Check(nums2));
        
        Console.WriteLine(Check(nums3));
    }
}
