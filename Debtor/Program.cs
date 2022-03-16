using System;

namespace Debtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var debtorApp = new DebtorApp();
            debtorApp.IntroduceDebtorApp();
            debtorApp.AskForAction();
        }
    }
}
