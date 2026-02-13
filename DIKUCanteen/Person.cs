namespace DIKUCanteen;
using System.Runtime.CompilerServices;

public class Person {
    private uint Age;
    private string Occupation;
    private string Name;

    public Person(string inName, string inOccupation, uint inAge) {
        Name = inName;
        Age = inAge;
        Occupation = inOccupation;
    }
}
