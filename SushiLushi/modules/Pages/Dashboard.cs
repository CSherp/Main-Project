using System;

namespace SushiLushi {
    class Dashboard {
        public static UISystem.Page page = new UISystem.Page("Dashboard Klant");
        public static void Display () {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Reserveringen", () => Console.WriteLine("None"))
                .Add("ik wil terug naar start!", StartPage.Display);

            menu.Display();


        }

    }
}