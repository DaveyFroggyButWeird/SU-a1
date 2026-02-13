namespace DIKUCanteen;
using System.Reflection.Metadata.Ecma335;

public class Canteen : Room {
    public Canteen(string name) : base(name) {

    }
    private int cups = 100;

    public Canteen(string name, int inCups) : base(name) {
        cups = inCups;
    }

    public int Cups {
        get {
            return cups;
        }
        set {
            cups = value;
        }
    }


    public override string ToString() {
        return $"{Name} has {cups} cups.";
    }
}

