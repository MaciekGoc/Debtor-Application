using Debtor.Core;
using System;

namespace Debtor
{
    public class DebtorApp
    {
        public BorrowerManager BorrowerManager { get; set; } = new BorrowerManager();

        public void IntroduceDebtorApp()
        {
            Console.WriteLine("Witam w aplikacji Dłużnik. Zapisujemy tutaj listę dłużników.");
        }

        public void AddBorrower()
        {
            Console.WriteLine("Podaj nazwę dłużnika, którego chcesz dodać do listy");

            var userName = Console.ReadLine();

            Console.WriteLine("Podaj kwotę długu");

            var userAmount = Console.ReadLine();

            var amountInDecimal = default(decimal);

            while (!decimal.TryParse(userAmount, out amountInDecimal))
            {
                Console.WriteLine("Podano niepoprawną kwotę");

                Console.WriteLine("Podaj kwotę długu");

                userAmount = Console.ReadLine();
            }
            
            BorrowerManager.AddBorrower(userName, amountInDecimal);
        }

        public void DeleteBorrower()
        {

            Console.WriteLine("Podaj nazwę dłużnika, którego chcesz usunąć z listy");

            var userName = Console.ReadLine();

            BorrowerManager.DeleteBorrower(userName);

            Console.WriteLine("Udało się usunąć dłużnika");
        }

        public void ListAllBorrowers()
        {
            Console.WriteLine("Oto lista Twoich dłużników:");

            foreach (var borrower in BorrowerManager.ListBorrowers())
            {
                Console.WriteLine(borrower);
            }
            
        }
        public void AskForAction()
        {
            Console.WriteLine("Podaj czynność, którą chcesz wykonać:");

            var userInput = default(string);

            while (userInput != "exit")
            {

                Console.WriteLine("add - Dodawanie dłużnika");
                Console.WriteLine("del - Usuwanie dłużnika");
                Console.WriteLine("list - Wypisywanie listy dłużników");
                Console.WriteLine("exit - Wyjście z programu");

                userInput = Console.ReadLine();
                userInput = userInput.ToLower();

                switch (userInput)
                {
                    case "add":
                        AddBorrower();
                        break;
                    case "del":
                        DeleteBorrower();
                        break;
                    case "list":
                        ListAllBorrowers();
                        break;
                    case "exit":
                        Console.WriteLine("Zapraszam ponownie");
                        break;

                    default:
                        Console.WriteLine("Podano złą wartość");
                        break;
                }
            }
        }
    }
}
