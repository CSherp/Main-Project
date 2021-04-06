namespace SushiLushi {
    class Menulijst {
        public static UISystem.Page page = new UISystem.Page("Menu pagina");
        public static void Display () {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Menulijst", test)
                .Add("Terug naar start", StartPage.Display);

            menu.Display();
        }

        private static void GoToDash() {
            Dashboard.Display();
        }
        private static void test() {

        }
    }
}