using System;  

public interface ISeries {  
  int GetFibo();
  int GetCuad();
} 

class PorDos : ISeries { 
  int val; 
  int ant;
  int nuev;
  int auxc, cuad;
  
  public PorDos() {  
    val = 0;  
    ant = 1;
    nuev =0;
  }   

  public int GetFibo() {
    nuev = val + ant;
    val = ant;
    ant = nuev;
    return nuev;  
  }  
  public int GetCuad() {
    auxc = auxc + 1;
    cuad = auxc * auxc;
    return cuad;  
  }
} 

class Program {  
  static void Main() {  
    PorDos ob = new PorDos();  
    Console.Write("Serie de Fibonacci: \n");
    for(int i=0; i < 10; i++)  
      Console.WriteLine("El sig. valor es " + ob.GetFibo());
    Console.Write("\nCuadrado de numeros: \n");
    for(int i=0; i < 10; i++)  
       Console.WriteLine("El sig. valor es " + ob.GetCuad());  
  }  
} 