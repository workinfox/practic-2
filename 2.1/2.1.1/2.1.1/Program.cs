using System;

class Program
{
    static void Main()
    {
        string J = "ab"; //драгоценности
        string S = "aabbccd"; //камни

        int count = 0; //сколько камней являются драгоценностями

        foreach (char c in S) //все камни
        {
            if (J.Contains(c.ToString())) //драгоценность ли
            {
                count++;
            }
        }
        
        Console.WriteLine(count);
    }
}