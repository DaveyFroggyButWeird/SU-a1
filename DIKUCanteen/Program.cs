namespace DIKUCanteen;
using System;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

class Program {
    static void Main(string[] args) {
        // ToString
        Canteen CanteenInstance = new Canteen("Cool");

        Console.WriteLine(CanteenInstance);

        // Example

        Student student = new Student("John", "Student", 77);
        Console.WriteLine("Canteen prior to take cup:");
        Console.WriteLine(CanteenInstance);
        Console.WriteLine("Canteen after take cup:");
        student.TakeCup(CanteenInstance);
        Console.WriteLine(CanteenInstance);
        Console.WriteLine($"Student has cup: {student.HasCup}");
        Console.WriteLine("Canteen after putting cup back");
        student.ReturnCup(CanteenInstance);
        Console.WriteLine(CanteenInstance);
        Console.WriteLine($"Student has cup: {student.HasCup}");
        CanteenBoardMember boardMember = new CanteenBoardMember("Greg", "Student", 27);
        Console.WriteLine($"buying a new cup, with a budget of {CanteenBoardMember.CupBudget}");
        boardMember.BuyCup(CanteenInstance);
        Console.WriteLine(CanteenInstance);
        Console.WriteLine($"budget was changed to {CanteenBoardMember.CupBudget}.");
        Console.WriteLine("Setting to 0 budgets, 0 cups");
        CanteenInstance = new Canteen("Cool", 0);
        CanteenBoardMember.CupBudget = 0;
        Console.WriteLine(CanteenInstance);
        Console.WriteLine($"buying a new cup, with a budget of {CanteenBoardMember.CupBudget}");
        boardMember.BuyCup(CanteenInstance);
        Console.WriteLine(CanteenInstance);
        Console.WriteLine($"budget was changed to {CanteenBoardMember.CupBudget}.");
        Console.WriteLine($"Student has cup: {student.HasCup}... and will now try to take one from canteen with 0 cups");
        student.TakeCup(CanteenInstance);
        Console.WriteLine($"Student has cup: {student.HasCup}");
        Console.WriteLine(CanteenInstance);
        Console.WriteLine("This concludes the program that exhibits requirements have been met.");
    }
}

