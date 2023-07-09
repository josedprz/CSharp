class Program {
  static void Main () {
    // StackOverflow
    try{
      funcion();
    }
    catch (StackOverflowException){
      Console.WriteLine("Pila excedida");
    }
    // OutOfMemory
    try{
      while(true){
       byte[] arreglo = new byte[1000000];
      } 
    }
    catch(OutOfMemoryException){
      Console.WriteLine("Memoria dinamica agotada");
    }
    // Array Type Mismatch
    int[] arr = new int[10];
    double flot = 2.3;
    Console.WriteLine(arr[2]);
    try{
      arr[2] = flot;
    }
    catch(ArrayTypeMismatchException){
      Console.WriteLine("Tipo de dato invalido.");
    }
  }

  static void funcion(){
    funcion();
  }
}