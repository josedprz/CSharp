using System;

class complejo {
  public int real;
  public int imaginario;
  public complejo(int r, int i){
    real = r;
    imaginario = i;
  }
  public static complejo operator +(complejo c1, complejo c2){
    return new complejo(c1.real + c2.real, c1.imaginario + c2.imaginario);
  }
  public static complejo operator -(complejo c1, complejo c2){
    return new complejo(c1.real - c2.real, c1.imaginario - c2.imaginario);
  }
  public static complejo operator *(complejo c1, complejo c2){
    return new complejo(c1.real * c2.real, c1.imaginario * c2.imaginario);
    }
  public static complejo operator /(complejo c1, complejo c2){
    return new complejo(c1.real / c2.real, c1.imaginario / c2.imaginario);
    }
  public int get_real(){
    return (real);
    }
  public int conju(){
    return ((-1) * imaginario);
    }
  public override string ToString(){
    return "(" + real + ")" + " + " + "(" + imaginario + ")" + "i";
  }
}

class Program {
  public static void Main (string[] args) {
    complejo num1 = new complejo(9,12);
    complejo num2 = new complejo(3,4);
    complejo suma = num1 + num2;
    complejo resta = num1 - num2;
    complejo mult = num1 * num2;
    complejo div = num1 / num2;
    Console.WriteLine ("El primer numero: " + num1);
    Console.WriteLine ("El segundo numero: " + num2);
    Console.WriteLine ("La suma es: " + suma);
    Console.WriteLine ("La resta es: " + resta);
    Console.WriteLine ("La multiplicacion es: " + mult);
    Console.WriteLine ("La division es: " + div);
    Console.WriteLine ("El conjugado del primer num es: (" + num1.get_real() + ") + (" + num1.conju() + ")i");
    Console.WriteLine ("El conjugado del segundo num es: (" + num2.get_real() + ") + (" + num2.conju() + ")i");
  }
}