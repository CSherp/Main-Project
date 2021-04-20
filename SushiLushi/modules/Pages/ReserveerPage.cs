using System;
namespace SushiLushi {
    class ReserveerPage {
        public static UISystem.Page page = new UISystem.Page("Reserveer pagina");
        public static void Display () {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Ik wil reserveren", Reserveer)
                .Add("Terug naar start", StartPage.Display);

            menu.Display();
        }

        private static void Reserveer() {
            int aantal_mensen = UISystem.Input.ReadInt("Voer het aantal personen in waarmee u komt:", 1, 5);
            int dieet_wensen = UISystem.Input.ReadString("Heeft u dieet wensen?");
        }
        private static void GoToStart() {
            StartPage.Display();
        }
    }
}