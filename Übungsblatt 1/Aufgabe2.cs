using System.Security.Cryptography;
using System; 

internal class Program
{
    private static int[] Agen(int n, int max)
    {
        int[] arr = new int[n];
        Random rnd = new Random();

        //füllt ein Array mit der Länge "n" mit zufälligen Zahlen bis zur Obergenze "max" 
        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(1, max + 1);
        }
        return arr; 
    }

    private static bool Check(int[] list)
    {
        bool[] found = new bool[11];

        //Wenn Zahl kleiner 10,wird sie ins Array gespeichert 
        foreach (int num in list)
        {
            if (num >= 0 && num <= 10)
            {
                found[num] = true;
            }
        }

        // Überprüft ob alle Zahlen von 1 - 10 im Array vorkommen
        for (int i = 0; i <= 10; i++)
        {
            if (!found[i])
            {
                return false;
            }
        }
        return true;
    }


    private static void Main(string[] args)
    {
        int Arraylänge = 10;
        int Obergrenze = 20;
        int[] Liste = Agen(Arraylänge, Obergrenze);
        
        foreach(int i in Liste)
        {
            Console.Write(i + "," );
        }
        Console.Write("\n");
        Console.WriteLine(Check(Agen(Arraylänge,Obergrenze)));
    }
    
}