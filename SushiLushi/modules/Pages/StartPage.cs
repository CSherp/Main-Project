namespace SushiLushi {
    public static class StartPage {
        
        public static UISystem.Page page = new UISystem.Page("Start Page");

        public static void Display () {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("test", () => UISystem.Output.WriteLine("hello!"))
                .Add("login", LoginPage.Display);

            menu.Display();
        }   
    }
}