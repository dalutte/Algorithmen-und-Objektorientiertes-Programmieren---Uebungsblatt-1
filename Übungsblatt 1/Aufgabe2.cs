using System.Security.Cryptography;
using System; 

internal class Program
{
    //private static int[] Agen(int n, int Og)
    //{
    //    int[] num1 = new int[n];
    //    Random r = new Random();

    //    for (int i = 1; i <= Og; i++)
    //    {
    //        for (int j = 0; j < n; j++)
    //        {
    //            num1[j] = r.Next(1,n);
    //        }
    //    }
    //    return num1;
    //}

    private static bool Check(int[] list)
    {
            int[] found = new int[10];

            int i = 0;
            foreach (int item in list)
            {
                if (item >= 1 && item <= 10)
                {
                    found[i] = item;
                    i++;
                    Console.WriteLine(item);
                }
            }

            if (found.Length < 10)
            {
                return false;
            }
            return true;
    }


    private static void Main(string[] args)
    {
            //int Arraylänge = 16;
            //int Obergrenze = 20;
            //int[] Liste = Agen(Arraylänge, Obergrenze);
            //Console.WriteLine(Agen(Arraylänge,Obergrenze

            Console.WriteLine(Check(Liste));
    }
    
}