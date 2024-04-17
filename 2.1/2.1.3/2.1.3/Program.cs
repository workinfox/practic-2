namespace _2._1._3;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целые числа через пробел:");
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        Console.WriteLine(Check(nums) ? "true" : "false");
    }
    
    static bool Check(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        
        foreach(int num in nums)
        {
            if(set.Contains(num))
            {
                return true;
            }
            set.Add(num);
        }
        return false;
    }
}
