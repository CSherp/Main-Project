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

        }
        private static void GoToStart() {
            StartPage.Display();
        }
    }
}