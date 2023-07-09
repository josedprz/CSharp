using System;

class fecha {
  int dia;
  int mes;
  int anio;
  int hora;
  int minutos;
  public void set_dia(int dd){
    dia = dd;
  }
  public void set_mes(int mm){
    mes = mm;
  }
  public void set_anio(int aa){
    anio = aa;
  }
  public void set_hora(int hh){
    hora = hh;
  }
  public void set_min(int mm){
    minutos = mm;
  }
  public int get_dia(){
    return dia;
  }
  public int get_mes(){
    return mes;
  }
  public int get_anio(){
    return anio;
  }
  public int get_hora(){
    return hora;
  }
  public int get_minutos(){
    return minutos;
  }
  public fecha (int dd, int mm, int aa, int hh, int min){
    dia = dd;
    mes = mm;
    anio = aa;
    hora = hh;
    minutos = min;
  }
  public fecha (){
    dia = 00;
    mes = 00;
    anio = 00;
    hora = 00;
    minutos= 00;
  }
}

class Program {
  public static void Main (string[] args) {
    fecha f1 = new fecha(07, 08, 23, 11, 42);
    Console.WriteLine (f1.get_dia());
  }
}