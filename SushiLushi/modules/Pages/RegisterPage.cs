using System;

namespace SushiLushi {
    class RegisterPage {
        public static UISystem.Page page = new UISystem.Page("Registratie pagina");
        public static void Display () {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Registreren", Register)
                .Add("Terug naar startpagina", GoToStart);

            menu.Display();

        }

        private static void GoToStart() {
            StartPage.Display();
        }
        private static void Register() {
            // Wordt gevraagd om invoeren van email
            Console.WriteLine("Voer uw mail in:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("LET OP: hoofdletter gevoelig");
            Console.ResetColor();
            var email = Console.ReadLine();
            
            // Als er geen geldige mail wordt ingevoerd komt er een foutmelding
            while(!(email.Contains('@') && email.Contains('.'))){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Voer een geldig mailadres in:");
                Console.ResetColor();
                email = Console.ReadLine();
            }

            // Wordt gevraagd om nogmaals invoeren van email
            Console.WriteLine("Voer uw mail nogmaals in");
            string repeatEmail = Console.ReadLine();

            // Als de 2e mail niet overeen komt geeft deze foutmelding
            while(email != repeatEmail){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("De mailadressen komen niet overeen. Probeer nogmaals:");
                Console.ResetColor();
                repeatEmail = Console.ReadLine();
            }

            // Wordt gevraagd om invoeren van gebruikersnaam
            Console.WriteLine("Voer uw gebruikersnaam in:");
            var username = Console.ReadLine();

            // Wordt gevraagd om invoeren van wachtwoord
            Console.WriteLine("Voer uw wachtwoord in:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("LET OP: hoofdletter gevoelig");
            Console.ResetColor();
            var password = Console.ReadLine();
            
            // Wordt gevraagd om nogmaals invoeren van wachtwoord
            Console.WriteLine("Voer uw wachtwoord nogmaals in:");
            string repeatPassword = Console.ReadLine();

            // Als de 2e wachtwoord niet overeen komt geeft deze foutmelding
            while(password != repeatPassword){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("De wachtwoorden komen niet overeen. Probeer nogmaals:");
                Console.ResetColor();
                repeatPassword = Console.ReadLine();
            }
            
            // Maak nieuw user object aan
            // Stel de gegevens in (properties)
            Storage.User newUser = new Storage.User() {
                username = username,
                email = email,
                password = password,
                role = "user"
            };

            // Voeg toe aan storge user list
            Storage.System.data.users.Add(newUser);

            // Sla de huidige gegevens op
            Storage.System.SaveStorage();
            LoginPage.page.Update();
            LoginPage.Inloggen();
        }
        public static bool Check(string user){
            foreach(Storage.User gebruiker in Storage.System.data.users) {
                if(gebruiker.email == user || gebruiker.username == user)
                    return false;
            }
            return true;
        }
            
    }
}