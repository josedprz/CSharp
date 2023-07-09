using System;

class cadena{
  public string strg;
  public cadena(){
    strg = "";
  }
  public cadena(string cad){
    strg = cad;
  }
  
  public static cadena operator+(cadena cad1, cadena cad2){   
    cadena resu = new cadena();
    resu.strg = cad1.strg + cad2.strg;
    return resu;
  }
  public static cadena operator-(cadena cad1, int n){   
    cadena resu2 = new cadena();
    string aux = "";
    int i;
    for(i=0; i<(cad1.strg.Length - (n)); i++){
      aux = aux + Convert.ToString(cad1.strg[i]);
    }
    resu2.strg = aux;
    return resu2;
  }
  public static cadena operator*(cadena cad, int n){   
    cadena resu4 = new cadena();
    string aux = "";
    int i;
    for(i=0; i<n; i++){
      aux = aux + cad.strg;
    }
    resu4.strg = aux;
    return resu4;
  }
  public void show(){
    Console.WriteLine(strg);
  }
}
class Program {
  public static void Main (string[] args) {
    cadena pr = new cadena("Instituto");
    cadena sgn = new cadena("Politecnico");
    cadena conc = new cadena();
    cadena remov = new cadena();
    cadena ultimo = new cadena();
    cadena repet = new cadena();
    Console.WriteLine("Primera Cadena: \n");
    pr.show();
    Console.WriteLine("\nSegunda Cadena: \n");
    sgn.show();
    Console.WriteLine("\nCadenas Concatenadas: \n");
    conc = pr + sgn;
    conc.show();
    Console.WriteLine("\nEliminar n caracteres a cadena 1: \n");
    remov = pr - 2;
    remov.show();
    ultimo.strg = pr.strg;
    Console.WriteLine("\nQuitar el ultimo caracter a cadena 1: \n");
    string auxu="";
    int k;
    for(k=0; k<(pr.strg.Length - 1); k++){
      auxu = auxu + Convert.ToString(pr.strg[k]);
    }
    Console.WriteLine(auxu);
    Console.WriteLine("\nRepetir la cadena n veces: \n");
    repet = pr * 4;
    repet.show();
  }
}