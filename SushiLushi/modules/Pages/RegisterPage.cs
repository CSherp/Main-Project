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
            Console.WriteLine("Voer uw mail in:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("LET OP: hoofdletter gevoelig");
            Console.ResetColor();
            var email = Console.ReadLine();

            Console.WriteLine("Voer uw mail nogmaals in");
            string repeatEmail = Console.ReadLine();

            while(email != repeatEmail){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("De mailadressen komen niet overeen. Probeer nogmaals:");
            Console.ResetColor();
            repeatEmail = Console.ReadLine();
            }

            Console.WriteLine("Voer uw gebruikersnaam in:");
            var username = Console.ReadLine();

            Console.WriteLine("Voer uw wachtwoord in:");
            var password = Console.ReadLine();
            
            Console.WriteLine("Voer uw wachtwoord nogmaals in:");
            string repeatPassword = Console.ReadLine();

            while(password != repeatPassword){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("De wachtwoorden komen niet overeen. Probeer nogmaals:");
            Console.ResetColor();
            repeatPassword = Console.ReadLine();
            }
        }
    }
}