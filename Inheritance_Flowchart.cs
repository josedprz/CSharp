using System;   

  public class figura2D { 
    protected double posX; 
    protected double posY; 
    protected string texto;
    public double showx() { 
      return posX;
    }
    public double showy() { 
      return posY;
    }
    public string showtx(){
      return texto;
    }
   public figura2D(){ 
      posX=posY=0;
    } 
  } 

  public class rombo:figura2D{
    protected double diagonalv;
    protected double diagonalh;
    public rombo(double dv, double dh, string txt, double x, double y){
      diagonalv = dv;
      diagonalh = dh;
      texto = txt;
      posX = x;
      posY = y;
    }
    public double showdv(){
      return diagonalv;
    }
    public double showdh(){
      return diagonalh;
    }
  }

  public class rectangulo:figura2D{ 
    protected double ancho; 
    protected double altura;
    public double showa(){
      return ancho;
    }
    public double showal(){
      return altura;
    }
    public rectangulo(double an, double al, string txt, double x, double y){
      ancho=an; 
      altura=al;
      texto=txt;
      posX = x;
      posY = y;
    } 
    public rectangulo(){ 
      posX = 0; 
      posY = 0; 
      ancho=0; 
      altura=0;
    } 
  } 

 

  public class cuadrado:rectangulo{ 
    public cuadrado(double lado, string txt, double x, double y){
      ancho=altura=lado;
      texto = txt;
      posX = x;
      posY = y;
    } 
  } 

  public class Diagrama2D{
    figura2D[] cuads = new cuadrado[1];
    figura2D[] rombos = new rombo[2];
    figura2D[] rects = new rectangulo[3];
    public Diagrama2D(cuadrado c1, rombo ro1, rombo ro2, rectangulo r1, rectangulo r2, rectangulo r3){
      cuads[0] = c1;
      rombos[0] = ro1;
      rombos[1] = ro2;
      rects[0] = r1;
      rects[1] = r2;
      rects[2] = r3;
    }
  }

  class Program{ 
    static int Main(){ 
      
      cuadrado c1 = new cuadrado(5, "La lampara no funciona", 0, 0);
      rombo ro1 = new rombo (7, 8, "¿Esta enchufada la lampara?", 0, 1);
      rombo ro2 = new rombo (8, 9, "¿Esta quemada la ampolleta?", 0, 2);
      rectangulo r1 = new rectangulo(4, 4, "Enchufar la lampara", 1, 1);
      rectangulo r2 = new rectangulo(5, 5, "Cambiar la ampolleta", 1, 2);
      rectangulo r3 = new rectangulo(3, 3, "Comprar nueva lampara", 0, 3);
      
      Diagrama2D d1 = new Diagrama2D(c1, ro1, ro2, r1, r2, r3);
  
      Console.WriteLine("El diagrama se compone por: \n");
      Console.WriteLine("1er cuadrado: (Lado: "+c1.showa()+")"+" (Texto: "+c1.showtx()+")"+"(PosX: "+c1.showx()+" , PosY: "+c1.showy()+")");
      Console.WriteLine("\n-->");
      Console.WriteLine("1er rombo: (Diagonales: "+ro1.showdv()+", "+ro1.showdh()+")"+" (Texto: "+ro1.showtx()+")"+"(PosX: "+ro1.showx()+" , PosY: "+ro1.showy()+")");
      Console.WriteLine("\nNo -->");
      Console.WriteLine("1er rectangulo: (Ancho: "+r1.showa()+")"+" (Altura: "+r1.showal()+")"+" (Texto: "+r1.showtx()+")"+"(PosX: "+r1.showx()+" , PosY: "+r1.showy()+")");
      Console.WriteLine("\nSi -->");
      Console.WriteLine("2do rombo: (Diagonales: "+ro2.showdv()+", "+ro2.showdh()+")"+" (Texto: "+ro2.showtx()+")"+"(PosX: "+ro2.showx()+" , PosY: "+ro2.showy()+")");
      Console.WriteLine("\nSi -->");
      Console.WriteLine("2do rectangulo: (Ancho: "+r2.showa()+")"+" (Altura: "+r2.showal()+")"+" (Texto: "+r2.showtx()+")"+"(PosX: "+r2.showx()+" , PosY: "+r2.showy()+")");
      Console.WriteLine("\nNo -->");
      Console.WriteLine("3er rectangulo: (Ancho: "+r3.showa()+")"+" (Altura: "+r3.showal()+")"+" (Texto: "+r3.showtx()+")"+"(PosX: "+r3.showx()+" , PosY: "+r3.showy()+")");
    
      return 0; 
    } 
  } 