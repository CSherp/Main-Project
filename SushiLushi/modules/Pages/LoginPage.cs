using System;

namespace SushiLushi {
    class LoginPage {
        public static UISystem.Page page = new UISystem.Page("Login pagina");
        public static void Display () {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Inloggen", Inloggen)
                .Add("Terug naar startpagina", GoToStart);
                // .Add("Inloggen als personeel", InloggenPersoneel);

            menu.Display();
        }

        private static void GoToStart() {
            StartPage.Display();
        }

        private static void Inloggen() {
            Console.WriteLine("Gebruikersnaam:");
            var username = Console.ReadLine();
            Console.WriteLine("Wachtwoord:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("LET OP: hoofdletter gevoelig");
            Console.ResetColor();
            var password = Console.ReadLine();
        }

        private static bool AccountCheck(string username, string password) {
            foreach(Storage.User user in Storage.System.data.users) {
                
            }
            return false;
        }
    }
}