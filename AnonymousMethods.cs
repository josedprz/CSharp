using System;
using System.Linq;

delegate int[] IntMod3(int[] str);

class Program3 {
  public static void Main (string[] args) {
    int[] arre = {1, 2, 3, 4, 5};
    int[] resp = {1, 2, 3, 4, 5};
    int[] resp2 = {1, 2, 3, 4, 5};
    Console.WriteLine ("Arreglo de numeros: \n");
    for(int i=0; i < arre.Length; i++){
      Console.WriteLine (arre[i] + "\t");
    }
    IntMod3 sq = delegate (int[] squa) {  
      int i;
      for(i=0; i < squa.Length; i++){
        squa[i]= squa[i]*squa[i];
      }  
      return squa; // Devolvemos un valor de un método anónimo 
    };
    IntMod3 par = delegate (int[] parr) {  
      int i;
      for(i=0; i < parr.Length; i++){
        if(parr[i] % 2 == 0){
          parr[i] = 0;
        }
      }
      int item = 0;
      int index = Array.IndexOf(parr, item);
      parr = parr.Where(e => e != item).ToArray();
      return parr; // Devolvemos un valor de un método anónimo 
    };
    IntMod3 facto = delegate (int[] factt) {  
      int i, res=1;
      for(i=0; i < factt.Length; i++){
        res = res * factt[i];
        factt[i] = 0;
      }
      factt[0] = res;
      int item = 0;
      int index = Array.IndexOf(factt, item);
      factt = factt.Where(e => e != item).ToArray();
      return factt; // Devolvemos un valor de un método anónimo 
    };  
    arre = sq(arre);
    Console.WriteLine ("\nNumeros elevados al cuadrado: \n");
    for(int i=0; i < arre.Length; i++){
      Console.WriteLine (arre[i] + "\t");
    }
    arre = resp;
    arre = par(arre);
    Console.WriteLine ("\nRemoviendo elementos pares: \n");
    for(int i=0; i < arre.Length; i++){
      Console.WriteLine (arre[i] + "\t");
    }
    arre = resp2;
    arre = facto(arre);
    Console.WriteLine ("\nFactorial del arreglo: \n");
    for(int i=0; i < arre.Length; i++){
      Console.WriteLine (arre[i] + "\t");
    }
  }
}