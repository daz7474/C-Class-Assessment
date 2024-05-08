using System;

public class Program
{
  public static void Main(string[] args)
  {
    // Create an instance of Car
    Car car = new Car("Lexus", "IS200", "GL02ULE", 2002, 2000m);

    // Console the ToString method on car
    Console.WriteLine(car.ToString());
  }
}