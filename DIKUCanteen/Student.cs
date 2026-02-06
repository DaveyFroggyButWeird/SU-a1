namespace DIKUCanteen;

public class Student : Person{
    public bool HasCup = false;

    public Student(string inName, string inOccupation, uint inAge) : base(inName, inOccupation, inAge)
    {
        // Wouldn't a student theoretically always have the same occupation? I.e... a student? lol.
    }

    public void TakeCup(Canteen canteenInstance)
    {
        if(canteenInstance.Cups > 0 && !HasCup)
        {
            canteenInstance.Cups = canteenInstance.Cups - 1;
            HasCup = true;
        }
    }
    public void ReturnCup(Canteen canteenInstance)
    {
        if(HasCup)
        {
            canteenInstance.Cups = canteenInstance.Cups + 1;
            HasCup = false;
        }
    }
}
