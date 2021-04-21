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

        private static void GoToLoading() {
            
        }
        private static void Inloggen() {
            Console.WriteLine("Gebruikersnaam:");
            var username = Console.ReadLine();
            Console.WriteLine("Wachtwoord:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("LET OP: hoofdletter gevoelig");
            Console.ResetColor();
            var password = Console.ReadLine();
            bool Check = AccountCheck(username, password);
            if (Check) {
                StartPage.Display();
            } else {
                LoginPage.Display();
            }
        }

        private static bool AccountCheck(string username, string password) {
            bool Usercheck = false;
            bool Passcheck = false;
            foreach(Storage.User user in Storage.System.data.users) {
                if (username == user.username) {
                    Usercheck = true;
                }   
                if (password == user.password) {
                    Passcheck = true;
                }
            }
            if (Usercheck && Passcheck) {
                return true;
            }
            return false;
        }

    }
}