using System;

namespace SushiLushi {
    class LoginPage {
        public static UISystem.Page page = new UISystem.Page("Login pagina");
        public static void Display () {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Inloggen", Inloggen)
                .Add("Terug naar startpagina", () => StartPage.Display());

            menu.Display();
        }

        private static void TryAgain(string Keuze) {
            // Als ingevoerde gebruikers naam niet bestaat
            page.Update();

            if (Keuze == "Name") {
                Console.WriteLine("\nHet ingevoerde gebruikersnaam bestaat niet");
            }

            if (Keuze == "Password") {
                Console.WriteLine("\nU heeft het wachtwoord te vaak onjuist!");
            }

            // **verbeteren** Ik krijg een error bij TryAgain
            // Als try again wordt gecalled blijf hij lopen, zelf op andere paginas
            if (Keuze == "error") {
                Console.WriteLine("WTF?");
            }

            var trymenu = new UISystem.Menu()
                .Add("Registreren", RegisterPage.Display)
                .Add("Opnieuw inloggen", LoginPage.Display);
            trymenu.Display();
        }


        private static void Inloggen() {
            
            // Inloggen gebruiker
            Console.WriteLine("Voer uw gebruikersnaam in:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("LET OP: hoofdletter gevoelig");
            Console.ResetColor();
          
            var username = Console.ReadLine();
            bool NCheck = NameCheck(username);
            if (!NCheck) {
                TryAgain("Name");
            }

            Console.WriteLine("Voer uw wachtwoord in:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("LET OP: hoofdletter gevoelig");
            Console.ResetColor();
            
            var password = Console.ReadLine();
            bool PCheck = PassCheck(password);
            while (!PCheck) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nUw wachtwoord is incorrect, probeer het opnieuw\n");
                Console.ResetColor();
                Console.WriteLine("Voer uw wachtwoord in:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("LET OP: hoofdletter gevoelig");
                Console.ResetColor();
                password = Console.ReadLine();
                PCheck = PassCheck(password);
            }

            if (NCheck == PCheck) {
                // Login successvol! Zet de state
                Storage.SushiLushiState.loggedUser = getUser(username, password);
                Storage.SushiLushiState.isLoggedIn = true;

                if (Storage.SushiLushiState.loggedUser.role == "admin") {
                    Storage.SushiLushiState.isAdmin = true;
                }
                
                StartPage.Display();
            }
        }


        private static bool NameCheck(string username) {
            bool UserCheck = false;
            
            foreach(Storage.User user in Storage.System.data.users) {

                if (username == user.username) {
                    UserCheck = true;
                }   
            }
          
            return UserCheck;
        }

        private static bool PassCheck(string password) {
            bool PassCheck = false;

            foreach(Storage.User user in Storage.System.data.users) {
                if (password == user.password) {
                    PassCheck = true;
                }
            }
            return PassCheck;
        }

        private static Storage.User getUser(string username, string password) {
            foreach(Storage.User user in Storage.System.data.users) {
                if (username == user.username && password == user.password) {
                    return user;
                }   
            }

            return null;
        }

    }
}