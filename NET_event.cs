using System;
using System.Timers;

public class Program{
    public static void Main(string[] args){

        var tempo = new Timer();
        tempo.Interval = 2000;

        tempo.Elapsed += SomeEvent;

        tempo.Start();
        
        Console.ReadLine();
    }

    public static void SomeEvent(object sender, ElapsedEventArgs e)
    {
        Console.WriteLine("Prueba Temporizador");
    }
}
