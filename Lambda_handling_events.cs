using System;

delegate void MyEventHandler(string str);

class MyEvent{

    public event MyEventHandler SomeEvent;
    
    public void OnSomeEvent(string str){
        if (SomeEvent != null){
            SomeEvent(str);
        }
    }
}

class Program {
  public static void Main (string[] args) {
    MyEvent evento = new MyEvent();
        
    evento.SomeEvent += (str) => Console.WriteLine("Ocurrio un " + str);
        
    evento.OnSomeEvent("Evento!");
  }
}