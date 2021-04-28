namespace SushiLushi {
    class MenuList {
        public static UISystem.Page page = new UISystem.Page("Menu pagina");
        public static void Display () {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Menulijst", lijst)
                .Add("Terug naar start", StartPage.Display);

            menu.Display();
        }

        private static void GoToDash() {
            Dashboard.Display();
        }
        private static void lijst() {
            MenuList.page.Update();

            var menu = new UISystem.Menu()
                .Add("Visgerechten", fish)
                .Add("Vleesgerechten", flesh)
                .Add("Vegetarische gerechten", vegan)
                .Add("Alle gerechten", all);
            menu.Display();

        }
        private static void fish() {
            MenuList.page.Update();

            var menu = new UISystem.Menu()
                .Add("Maki zalm", showInfo)
                .Add("Maki tonijn", showInfo)
                .Add("Nigiri zalm", showInfo)
                .Add("Nigiri tonijn", showInfo)
                .Add("California roll", showInfo)
                .Add("Spicy tonijn roll", showInfo)
                .Add("Crunchy california roll", showInfo)
                .Add("Ebi tempura garnaal roll", showInfo)
                .Add("Zalm sashimi", showInfo)
                .Add("Tonijn sashimi", showInfo)
                .Add("Terug", lijst);
        }
        private static void flesh() {
            Dashboard.Display();
        }
        private static void vegan() {
            Dashboard.Display();
        }       

        private static void all() {
            Dashboard.Display();
        } 

        private static void showInfo() {
            Dashboard.Display();
        }
    }
}