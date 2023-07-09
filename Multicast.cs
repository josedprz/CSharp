using System;
using System.Linq;

delegate void IntMod2(ref int[] str);

class Program2 {
  static void Square(ref int[] a) {  
    int i;
    for(i=0; i < a.Length; i++){
      a[i]= a[i]*a[i];
    }
  }  
  static void Par(ref int[] a) {  
    int i;
    for(i=0; i < a.Length; i++){
      if(a[i] % 2 == 0){
        a[i] = 0;
      }
    }
    int item = 0;
    int index = Array.IndexOf(a, item);
    a = a.Where(e => e != item).ToArray();  
  }   
  static void Facto(ref int[] a) {  
    int i, res=1;
    for(i=0; i < a.Length; i++){
      res = res * a[i];
      a[i] = 0;
    }
    a[0] = res;
    int item = 0;
    int index = Array.IndexOf(a, item);
    a = a.Where(e => e != item).ToArray();
  }   
  public static void Main (string[] args) {
    IntMod2 num;
    IntMod2 nsq = Square;
    IntMod2 npar = Par;
    IntMod2 nfacto = Facto;
    num = nsq;
    
    int[] arre = {1, 2, 3, 4, 5};
    int[] resp = {1, 2, 3, 4, 5};
    int[] resp2 = {1, 2, 3, 4, 5};

    Console.WriteLine ("Arreglo de numeros: \n");
    for(int i=0; i < arre.Length; i++){
      Console.WriteLine (arre[i] + "\t");
    }
    
    num(ref arre);
    Console.WriteLine ("\nNumeros elevados al cuadrado: \n");
    for(int i=0; i < arre.Length; i++){
      Console.WriteLine (arre[i] + "\t");
    }

    num += npar;
    arre = resp;
    num(ref arre);
    Console.WriteLine ("\nRemoviendo elementos pares: \n");
    for(int i=0; i < arre.Length; i++){
      Console.WriteLine (arre[i] + "\t");
    }
    
    arre = resp2;
    num += nfacto;
    num(ref arre);
    Console.WriteLine ("\nFactorial del arreglo: \n");
    for(int i=0; i < arre.Length; i++){
      Console.WriteLine (arre[i] + "\t");
    }
  }
}