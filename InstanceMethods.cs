using System;
using System.Linq;

delegate int[] IntMod(int[] str);

class ops{
  public int[] Square(int[] a) {  
    int i;
    for(i=0; i < a.Length; i++){
      a[i]= a[i]*a[i];
    }  
    return a;  
  }  
  public int[] Par(int[] a) {  
    int i;
    for(i=0; i < a.Length; i++){
      if(a[i] % 2 == 0){
        a[i] = 0;
      }
    }
    int item = 0;
    int index = Array.IndexOf(a, item);
    a = a.Where(e => e != item).ToArray();
    return a;  
  }   
  public int[] Facto(int[] a) {  
    int i, res=1;
    for(i=0; i < a.Length; i++){
      res = res * a[i];
      a[i] = 0;
    }
    a[0] = res;
    int item = 0;
    int index = Array.IndexOf(a, item);
    a = a.Where(e => e != item).ToArray();
    return a;  
  }
}

class Program {
  public static void Main (string[] args) {
    ops m = new ops();
    IntMod num = m.Square;
    int[] arre = {1, 2, 3, 4, 5};
    int[] resp = {1, 2, 3, 4, 5};
    int[] resp2 = {1, 2, 3, 4, 5};
    Console.WriteLine ("Arreglo de numeros: \n");
    for(int i=0; i < arre.Length; i++){
      Console.WriteLine (arre[i] + "\t");
    }
    arre = num(arre);
    Console.WriteLine ("\nNumeros elevados al cuadrado: \n");
    for(int i=0; i < arre.Length; i++){
      Console.WriteLine (arre[i] + "\t");
    }
    arre = resp;
    num = m.Par;
    arre = num(arre);
    Console.WriteLine ("\nRemoviendo elementos pares: \n");
    for(int i=0; i < arre.Length; i++){
      Console.WriteLine (arre[i] + "\t");
    }
    arre = resp2;
    num = m.Facto;
    arre = num(arre);
    Console.WriteLine ("\nFactorial del arreglo: \n");
    for(int i=0; i < arre.Length; i++){
      Console.WriteLine (arre[i] + "\t");
    }
  }
}