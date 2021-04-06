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
            UISystem.Output.WriteLine(System.ConsoleColor.White, "Maak uw keuze!");
            UISystem.Output.WriteLine(System.ConsoleColor.White, "--------------------------");
            var menu = new UISystem.Menu()
                .Add("Test", () => UISystem.Output.WriteLine("Dit is een test! :D"))
                .Add("Login", LoginPage.Display)
                .Add("Registreren", RegisterPage.Display)
                .Add("Reserveren", ReserveerPage.Display);
            
            menu.Display();
        }   
    }
}