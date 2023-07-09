using System;

public class Gen2<N>{
  N ob;

  public Gen2(N o){
    ob = o;
  }
  public N GetOb(){
    return ob;
  }
  public void ShowType(){
    Console.WriteLine("El tipo de T es: " + typeof(N));
  }
}

public class ClaseA{
  public int numa;

  public ClaseA(){
    
  }
  
}
public class ClaseB:ClaseA{
  string numb;
  
  public ClaseB(string b){
    numb = "cadena";
   }
 }

class Program2 {
  public static void Main (string[] args) {
    ClaseA num = new ClaseA();
    ClaseB str = new ClaseB("Esto es una cadena");
    Gen2<ClaseA> genobj = new Gen2<ClaseA> (num);
    genobj.GetOb().numa = 4;

    genobj.ShowType();
    
    
    Console.WriteLine("Valor del entero de clase A: ");

    Console.WriteLine();
  }
}