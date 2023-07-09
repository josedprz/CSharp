using System;

class Program {
  public static void Main (string[] args) {
    string n, a;
    Console.WriteLine("Ingresa tus nombres: ");
    n = Console.ReadLine();
    Console.WriteLine("\nIngresa tus apellidos: ");
    a = Console.ReadLine();
    Func<string, string, string> comp = (nombre , nombre2) => nombre + " " + nombre2;
    Console.WriteLine("\n\nNombre completo: " + comp(n, a));

    Func<int, int> square = x => x * x;
    Console.WriteLine("Cuadrado de 5: \n" + square(5));
  }
}