using System;

namespace SushiLushi {
    class RegisterPage {
        public static UISystem.Page page = new UISystem.Page("Registratie pagina");
        public static void Display () {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("registreren!", () => Console.WriteLine("test123"))
                .Add("ik wil terug naar start!", GoToStart);

            menu.Display();

            Console.WriteLine("Hallo dingen enzo");

        }

        private static void GoToStart() {
            StartPage.Display();
        }
    }
}