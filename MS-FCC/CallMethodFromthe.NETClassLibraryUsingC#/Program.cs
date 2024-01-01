using System;


 public class Program
  {
 
    public static void Main(string[] args)
    {
   
    PrintHello helloInstance = new PrintHello();
        helloInstance.myMethod();    
    }
  }

  public class PrintHello{
     public static void myMethod(){
        Console.WriteLine("Hello sWorlds");
    }
  }
 
