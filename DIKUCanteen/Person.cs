using System.Runtime.CompilerServices;

namespace DIKUCanteen;

public class Person{
  private uint Age;
  private string Occupation;
  private string Name;

  public Person(string inName, string inOccupation, uint inAge)
  {
    Name = inName;
    Age = inAge;
    Occupation = inOccupation;
  }
}
