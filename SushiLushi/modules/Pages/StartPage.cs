using System;
namespace SushiLushi {
    public static class StartPage {
        
        public static UISystem.Page page = new UISystem.Page("Start Page");

        public static void Display () {
            page.Update(false);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("`----------------------------------------------------------------------------------------`");
            Console.WriteLine(".s:------------------------------------------------------------------------------------:s.");
            Console.WriteLine(".s.                                                                                    .s.");
            Console.WriteLine(".s.    `-/+oo+/:`      ++/     :++       .:+ooo+/-`     .++-    `++:     .++++++++++`  .s.");
            Console.WriteLine(".s.   `oso:---/o-      os+     +ss      -ss/---:++`     -ss-    `ss/     `---+ss/---   .s.");
            Console.WriteLine(".s.   -ss/`            os+     +ss      +ss-`           -ss-    `ss/         :ss-      .s.");
            Console.WriteLine(".s.    :oso+/-.`       os+     +ss      `+sso+:-`       -sso////+ss/         :ss-      .s.");
            Console.WriteLine(".s.     `.:+osso:      os+     +ss        `-/+oss+-     -ss+/////ss/         :ss-      .s.");
            Console.WriteLine(".s.          ./ss-     oso     +so            `.oss`    -ss-    `ss/         :ss-      .s.");
            Console.WriteLine(".s.   -+/-.``.+ss.     :ss:.`.:ss:     `/+:.```-oso     -ss-    `ss/      .../ss:...   .s.");
            Console.WriteLine(".s.   ./+oooooo/.       -+ooooo+-       -+oooooo+:`     .oo-    `oo/     .oooooooooo`  .s.");
            Console.WriteLine(".s.      ``````           `````           ``````         ``      ```      ``````````   .s.");
            Console.WriteLine(".s-````````````````````````````````````````````````````````````````````````````````````-s.");
            Console.WriteLine("`/::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::/`");
            Console.WriteLine("                                                                                          ");
            Console.WriteLine(" :+                  .+- :+`               .+oo+                -+. /+                :+` ");
            Console.WriteLine(" sd`                 -d: od`               /do/.                /d+:hd                +d. ");
            Console.WriteLine(" sd.``               -d+`sd`               `-/yh.               /d/-hd                +d. ");
            Console.WriteLine(" -oo+:                /ooo:                -ooo+                -o. +o                :o` ");
            Console.WriteLine("");
            UISystem.Output.WriteLine(System.ConsoleColor.White, "Welkom bij Sushi Lushi, het beste Sushi Restaurant in de wereld!");
            
            if (Storage.SushiLushiState.isLoggedIn) {
                UISystem.Output.WriteLine(System.ConsoleColor.Cyan, "U bent ingelogd als: " + Storage.SushiLushiState.loggedUser.username);
            }

            UISystem.Output.WriteLine(System.ConsoleColor.White, "Maak uw keuze!");
            UISystem.Output.WriteLine(System.ConsoleColor.White, "--------------------------");
            
            var menu = new UISystem.Menu();

            // Niet ingelogd
            if (!Storage.SushiLushiState.isLoggedIn) {
                menu.Add("Login", LoginPage.Display);
                menu.Add("Registreren", RegisterPage.Display);
                
                menu.Add("Reserveren", ReserveerPage.Display);
                menu.Add("Menu bekijken", Menulijst.Display);
            }

            // Ingelogd als gebruiker
            if (Storage.SushiLushiState.isLoggedIn && !Storage.SushiLushiState.isAdmin) {
                menu.Add("Reserveren", ReserveerPage.Display);
                menu.Add("Mijn reservaties", null);
                menu.Add("Menu bekijken", Menulijst.Display);
            }

            // Ingelogd als admin
            if (Storage.SushiLushiState.isLoggedIn && Storage.SushiLushiState.isAdmin) {
                menu.Add("Gebruikers beheren", AdminPage.Display);
                menu.Add("Reserveringen beheren", null);
            }
            
            menu.Display();
        }   
    }
}