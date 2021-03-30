namespace SushiLushi {
    class LoginPage {
        public static UISystem.Page page = new UISystem.Page("Login pagina");
        public static void Display () {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Ik wil inloggen", GoToDash)
                .Add("Terug naar start", StartPage.Display);

            menu.Display();
        }

        private static void GoToDash() {
            Dashboard.Display();
        }
    }
}