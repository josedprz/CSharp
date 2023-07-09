using System; 
 
class Figura2D {  
  double pri_width;  
  double pri_height;  
   
  public Figura2D() {  
    Width = Height = 0.0;  
    name = "null";  
  }  
   
  public Figura2D(double w, double h, string n) {  
    Width = w;  
    Height = h;  
    name = n;  
  }  
  
  public Figura2D(double x, string n) {  
    Width = Height = x;  
    name = n;  
  }  
  
  public Figura2D(Figura2D ob) {  
    Width = ob.Width;  
    Height = ob.Height;  
    name = ob.name;  
  }  
  
  public double Width { 
     get { return pri_width; } 
     set { pri_width = value < 0 ? -value : value; } 
  } 
 
  public double Height { 
     get { return pri_height; } 
     set { pri_height = value < 0 ? -value : value; } 
  } 
 
  public string name { get; set; } 
  
  public void ShowDim() {  
    Console.WriteLine("La anchura y la altura son " +  
                       Width + " y " + Height);  
  }  
  
  public virtual double Area() {   
    Console.WriteLine("Se debe hacer override al método Area()");  
    return 0.0;  
  }   
}  
  
class Triangle : Figura2D {  
  string Style; 
  
  public Triangle() {  
    Style = "null";  
  }  
   
  public Triangle(string s, double w, double h) : 
    base(w, h, "triángulo") {  
      Style = s;   
  } 
  public Triangle(double w, double h, string s) : 
    base(w, h, "triángulo equilatero") {  
      Style = s;   
  }  
  public Triangle(double w, string s, double h) : 
    base(w, h, "triángulo rectangulo") {  
      Style = s;   
  }  
  
  public Triangle(double x) : base(x, "triángulo isosceles") {  
    Style = "isosceles";   
  }  
  
  public Triangle(Triangle ob) : base(ob) {  
    Style = ob.Style;  
  }  
  
  public override double Area() {  
    return Width * Height / 2;  
  }  
  
  public void ShowStyle() {  
    Console.WriteLine("Triángulo es " + Style);  
  }  
}  

class Circulo : Figura2D {  
  string Style; 
  
  public Circulo() {  
    Style = "null";  
  }  
  
  public Circulo(string s, double w, double h) : 
    base(w, h, "circulo") {  
      Style = s;   
  }  
  
  public Circulo(Circulo ob) : base(ob) {  
    Style = ob.Style;  
  }  
   
  public override double Area() {  
    return Width * (Height*Height);  
  }  
  
  public void ShowStyle() {  
    Console.WriteLine("Circulo es " + Style);  
  }  
}  

class Rectangle : Figura2D {   
  public Rectangle(double w, double h) :  
    base(w, h, "rectángulo"){ }  
  
  public Rectangle(double x) :  
    base(x, "cuadrado") { }  
  
  public Rectangle(Rectangle ob) : base(ob) { }  
  
  public bool IsSquare() {   
    if(Width == Height) return true;   
    return false;   
  }
  
  public override double Area() {   
    return Width * Height;   
  }   
}  
class Cuadrado : Rectangle {
  public Cuadrado(double x) :
    base(x) { }
}
  
class Program {  
  static void Main() {  
    Figura2D[] shapes = new Figura2D[8];  
  
    shapes[0] = new Triangle("derecho", 7.0, 12.0);
    shapes[1] = new Triangle(7.0, 12.0,"buenas");  
    shapes[2] = new Triangle(7.0, "hmm", 12.0);  
    shapes[3] = new Triangle(7.0);   
    shapes[4] = new Cuadrado(10);  
    shapes[5] = new Rectangle(10, 4); 
    shapes[6] = new Circulo("hola",3.1416, 4);  
    shapes[7] = new Figura2D(10, 20, "genérica");
  
    for(int i=0; i < shapes.Length; i++) {  
      Console.WriteLine("El objeto es " + shapes[i].name);  
      Console.WriteLine("El área es " + shapes[i].Area());  
      Console.WriteLine();
    }  
  }  
}

