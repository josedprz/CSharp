using System;
using System.IO;

class Program{
    static void Main(string[] args){
      Console.WriteLine("Introduce una cadena de al menos 3 lineas: ");
      string cadena = Console.ReadLine();

      using (Stream strea = new MemoryStream()){
        foreach (char caracter in cadena){
          byte[] bytes = BitConverter.GetBytes(caracter);
          strea.WriteByte(bytes[0]);
          strea.WriteByte(bytes[1]);
        }

        using (FileStream archivo = new FileStream("archivo.txt", FileMode.Create)){
          strea.Position = 0;
          strea.CopyTo(archivo);
        }
      }

      using (FileStream archivo = new FileStream("archivo.txt", FileMode.Open)){
        Console.WriteLine("\nContenido del archivo:");

        while (archivo.Position < archivo.Length){
          byte[] tama = new byte[2];
          int bytesRead = archivo.Read(tama, 0, tama.Length);

          if (bytesRead == 2){
            char caracter = BitConverter.ToChar(tama, 0);
            Console.Write(caracter);
          }
        }
        Console.WriteLine("\n");
      }
    }
}