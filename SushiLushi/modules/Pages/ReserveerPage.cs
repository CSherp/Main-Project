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
            DateTime today = DateTime.Now; 
            Console.WriteLine("Vandaag is het: "+ today.Date.ToString("dd-MM-yyyy"));
            Console.WriteLine("Kies een dag:");

            var menu2 = new UISystem.Menu()
                .Add(today.AddDays(1).Date.ToString("dd-MM-yyyy"), null)
                .Add(today.AddDays(2).Date.ToString("dd-MM-yyyy"), StartPage.Display)
                .Add(today.AddDays(3).Date.ToString("dd-MM-yyyy"), StartPage.Display);

            menu2.Display();

            string dieet_wensen = UISystem.Input.ReadString("Heeft u dieet wensen/ alergieën?");
        }
        private static void GoToStart() {
            StartPage.Display();        }
    }
}