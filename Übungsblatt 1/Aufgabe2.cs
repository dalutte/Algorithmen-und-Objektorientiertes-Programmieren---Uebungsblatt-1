using System.Security.Cryptography;
using System;
using System.Diagnostics;
using System.IO.Pipes;

internal class Program
{
    private static int[] Agen(int n, int max)
    {
        int[] arr = new int[n];
        Random rnd = new Random();

        //füllt ein Array mit der Länge "n" mit zufälligen Zahlen bis zur Obergenze "max" 
        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(0, max + 1);
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
        int Arraylänge = 30;
        int Obergrenze = 15;
        Console.WriteLine("Wie viele Durchführungen?");
        int Durchführungen = int.Parse(Console.ReadLine());
        int gefunden = 0, nichtgefunden = 0;
        double Prozent;

        Stopwatch watch = new Stopwatch();
        watch.Start();

        //generiert zufällige Arrays und gibt die Anzahl der Arrays aus in der die Zahlen 1-10 vorkommen aus
        for (int x = 0; x < Durchführungen; x++)
        {
            int[] Liste = Agen(Arraylänge, Obergrenze);

            foreach (int i in Liste)
            {
                Console.Write(i + ",");
            }
            Console.Write("\n\n");

            if (Check(Agen(Arraylänge, Obergrenze)) == false)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                //Console.WriteLine("In dem Array befinden sich nicht alle Zahlen von 1-10");
                nichtgefunden++;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                //Console.WriteLine("Die Zahlen 1-10 befinden sich im Array");
                gefunden++;
            }
        }

        watch.Stop();

        Console.BackgroundColor = ConsoleColor.Black;
        Prozent = (double)gefunden / Durchführungen;
        Console.Write("Durchführungen: {2}gefunden: {0}nicht gefunden: {1}", gefunden + ("\n"), nichtgefunden + ("\n"), Durchführungen + ("\n"));
        Console.WriteLine("Prozent: " + String.Format("{0:#.0%}", Prozent));
        Console.WriteLine("Verbrauchte Zeit [m/ss/msmsms]: " + watch.Elapsed.ToString(@"m\:ss\.fff"));

    }
}