namespace SushiLushi {
    class AdminPage {
        public static UISystem.Page page = new UISystem.Page("Admin pagina");

        public static void Display () {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Gebruikers weergeven", listAllUsers)
                .Add("Gebruiker toevoegen", null)
                .Add("Terug naar start", StartPage.Display);

            menu.Display();
        }

        private static void listAllUsers() {
            page.Update();
            UISystem.Output.WriteLine(System.ConsoleColor.Cyan, "Dit zijn alle gebruikers in het systeem!");

            int index = 0;
            foreach (Storage.User user in Storage.System.data.users) {
                System.Console.ForegroundColor = System.ConsoleColor.Cyan;
                System.Console.Write("[" + index + "] ");
                System.Console.ForegroundColor = System.ConsoleColor.Gray;
                System.Console.Write(user.username + " - " + user.email);
                System.Console.Write("\n");
                index++;
            }

            

            
        }
    }
}