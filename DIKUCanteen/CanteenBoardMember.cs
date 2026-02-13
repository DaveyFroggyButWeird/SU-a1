namespace DIKUCanteen;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class CanteenBoardMember : Student {
    public CanteenBoardMember(string inName, string inOccupation, uint inAge) : base(inName, inOccupation, inAge) {
    }
    public static uint CupBudget = 50;
    // Since we're reusing cups, they must be seramic or smthn and not plastic/paper,
    // so 50 should do fine. Since each canteen already has 100.
    public void BuyCup(Canteen canteenInstance) {
        if (CupBudget > 0) {
            canteenInstance.AddCup();
            CupBudget--;
        }
    }
}
