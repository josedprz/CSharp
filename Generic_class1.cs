using System;

class Gen<T, S>{
  T ob;
  S sob;

  public Gen(T o, S s){
    ob = o;
    sob = s;
  }
  public T GetObT(){
    return ob;
  }
  public S GetObS(){
    return sob;
  }
  public void ShowTypeofT(){
    Console.WriteLine("El tipo de T es: " + typeof(T));
  }
  public void ShowTypeofS(){
    Console.WriteLine("El tipo de S es: " + typeof(S));
  }
}

class Program {
  public static void Main (string[] args) {
    Gen<int, string> objeto1;
    objeto1 = new Gen<int, string>(102, "Esta es una cadena");

    objeto1.ShowTypeofT();
    objeto1.ShowTypeofS();
    
    int v = objeto1.GetObT();
    string w = objeto1.GetObS();
    
    Console.WriteLine("Valor del entero: " + v);
    Console.WriteLine("Valor de la cadena: " + w);

    Console.WriteLine();
  }
}