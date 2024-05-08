public class Car
{
  private string make;
  private string model;
  private string registration;
  private int year;
  private decimal currentValue;

  // Constructor for car
  public Car(string make, string model, string registration, int year, decimal currentValue)
  {
    this.make = make;
    this.model = model;
    this.registration = registration;
    this.year = year;
    this.currentValue = currentValue;
  }

  // Get the current value of the car
  public decimal GetCurrentValue()
  {
    return currentValue;
  }

  // Get the year of the car
  public int GetYear()
  {
    return year;
  }

  // Override ToString
  public override string ToString()
  {
    return $"Make: {make},\n Model: {model},\n Registration: {registration},\n Year: {year},\n Current Value: £{currentValue}.";
  }
}