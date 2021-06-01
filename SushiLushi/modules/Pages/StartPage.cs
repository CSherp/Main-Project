using System;
using System.Linq;
namespace SushiLushi {
    using static MenuList;
    public static class StartPage {
        
        public static UISystem.Page page = new UISystem.Page("Start Page");

        public static void Display () {
            page.Update(false);

            //Returns random int from 0 - menu.length
            static int Random(int length){
                Random rd = new Random();
                return rd.Next(0, length);
            }
            
            //Start Visualization
            static void PrintTop(){
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");

                Console.WriteLine(@"`/::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::/`");
                Console.WriteLine(@".s:------------------------------------------------------------------------------------:s.");
                Console.WriteLine(@".s.                                                                                    .s.");
                Console.WriteLine(@".s.    `-/+oo+/:`      ++/     :++       .:+ooo+/-`     .++-    `++:     .++++++++++`  .s.");
                Console.WriteLine(@".s.   `oso:---/o-      os+     +ss      -ss/---:++`     -ss-    `ss/     `---+ss/---   .s.");
                Console.WriteLine(@".s.   -ss/`            os+     +ss      +ss-`           -ss-    `ss/         :ss-      .s.");
                Console.WriteLine(@".s.    :oso+/-.`       os+     +ss      `+sso+:-`       -sso////+ss/         :ss-      .s.");
                Console.WriteLine(@".s.     `.:+osso:      os+     +ss        `-/+oss+-     -ss+/////ss/         :ss-      .s.");
                Console.WriteLine(@".s.          ./ss-     oso     +so            `.oss`    -ss-    `ss/         :ss-      .s.");
                Console.WriteLine(@".s.   -+/-.``.+ss.     :ss:.`.:ss:     `/+:.```-oso     -ss-    `ss/      .../ss:...   .s.");
                Console.WriteLine(@".s.   ./+oooooo/.       -+ooooo+-       -+oooooo+:`     .oo-    `oo/     .oooooooooo`  .s.");
                Console.WriteLine(@".s.      ``````           `````           ``````         ``      ```      ``````````   .s.");
                Console.WriteLine(@".s.   _               _      _             ______             _   _              _     .s.");
                Console.WriteLine(@".s.  |+|             |.|    |+|           /======/           |s| |d|            |#|    .s.");
                Console.WriteLine(@".s.  |d|             |-|    |d|           \----/             |o|_|g|            |@|    .s.");
                Console.WriteLine(@".s.  |d|             |@|    |!|             \%-^\            |hf_hg|            |*|    .s.");
                Console.WriteLine(@".s.  |=|___           \-\___/-/             /*#-/            |h| |s|            |#|    .s.");
                Console.WriteLine(@".s.  |=====|           \=====/            \=====/            |=| |=|            |=|    .s.");
                Console.WriteLine(@"                                                                                          ");
                Console.WriteLine(@".s-````````````````````````````````````````````````````````````````````````````````````-s.");
                Console.WriteLine(@"`/::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::/`");

            }


            static void PrintBottom(){

                


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine(@"`----------------------------------------------------------------------------------------`");  
                Console.WriteLine(@".s:------------------------------------------------------------------------------------:s.");
                Console.WriteLine(@".s.                                                                                    .s.");
                Console.WriteLine(@".s.                               Maaltijden van de dag:                               .s.");
                Console.WriteLine(@".s.                                                                                    .s.");
                Console.WriteLine($".s.                 Persoon 12+ dinner :                                               .s.");
                Console.WriteLine($".s.                                                                                    .s.");
                Console.WriteLine(@".s.                                                                                    .s.");
                Console.WriteLine(@"`/::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::/`");
                Console.WriteLine(@".s:------------------------------------------------------------------------------------:s.");
                Console.WriteLine(@".s.                                                                                    .s.");
                Console.WriteLine(@".s.                                 Snel en gemakkelijk!                               .s.");
                Console.WriteLine(@".s.                ___________________________    ___________________________          .s.");
                Console.WriteLine(@".s.                |       Sushi Lushi       |    |       Sushi Lushi       |          .s.");
                Console.WriteLine(@".s.                |-------------------------|    |-------------------------|          .s.");
                Console.WriteLine(@".s.                |          Menu           |    |      Reserveringen      |          .s.");
                Console.WriteLine(@".s.                |                         |    |                         |          .s.");
                Console.WriteLine($".s.                |                         |    |   Datum:                |          .s.");
                Console.WriteLine(@".s.                |    Fish        [3] + -  |    |       21-05-2021        |          .s.");
                Console.WriteLine($".s.                |                         |    |                         |          .s.");
                Console.WriteLine(@".s.                |    Meat        [0] + -  |    |   Tijd:                 |          .s.");
                Console.WriteLine($".s.                |                         |    |       14:00 - 16:00     |          .s.");
                Console.WriteLine(@".s.                |    Vegan       [1] + -  |    |                         |          .s.");
                Console.WriteLine(@".s.                |                         |    |   Personen:             |          .s.");
                Console.WriteLine(@".s.                |                         |    |       3                 |          .s.");
                Console.WriteLine(@".s.                |_________________________|    |_________________________|          .s.");
                Console.WriteLine(@".s.                          Stap 1                         Stap 2                     .s.");
                Console.WriteLine(@".s.                     Kies van het menu                  Reserveer                   .s.");
                Console.WriteLine(@".s.                                                                                    .s.");
                Console.WriteLine(@"`::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::/` ");

            }
            PrintTop();
            PrintBottom();
            UISystem.Output.WriteLine(System.ConsoleColor.White, "");
            UISystem.Output.WriteLine(System.ConsoleColor.White, "Welkom bij Sushi Lushi, het beste Sushi restaurant in de wereld!");
            UISystem.Output.WriteLine(System.ConsoleColor.White, "Maak uw keuze!");

            var menu = new UISystem.Menu();

            // Niet ingelogd
            if (!Storage.SushiLushiState.isLoggedIn) {
                menu.Add("Login", LoginPage.Display);
                menu.Add("Registreren", RegisterPage.Display);
                
                menu.Add("Reserveren", ReserveerPage.Display);
                menu.Add("Menu bekijken", MenuList.Display);
            }

            // Ingelogd als gebruiker
            if (Storage.SushiLushiState.isLoggedIn && !Storage.SushiLushiState.isAdmin) {
                menu.Add("Reserveren", ReserveerPage.Display);
                menu.Add("Mijn reserveringen", listReservations);
                menu.Add("Menu bekijken", MenuList.Display);
            }

            // Ingelogd als admin
            if (Storage.SushiLushiState.isLoggedIn && Storage.SushiLushiState.isAdmin) {
                menu.Add("Gebruikers beheren", AdminPageUser.Display);
                menu.Add("Reserveringen beheren", AdminPageReservations.Display);
            }

            if (Storage.SushiLushiState.isLoggedIn) {
                menu.Add("Uitloggen", logout);
            }


            menu.Display();
        } 
        public static void logout() {
            Storage.SushiLushiState.isLoggedIn = false;
            Storage.SushiLushiState.isAdmin = false;
            Storage.SushiLushiState.loggedUser = null;
            
            UISystem.Input.ReadString("U bent uitgelogd! (Druk op enter om verder te gaan)");
            StartPage.Display();
        }

        public static void listReservations() {
            UISystem.Output.WriteLine(ConsoleColor.Cyan, "Dit zijn uw reserveringen:");

            foreach (Storage.Reservation reservation in Storage.System.data.reservations) {
                if (reservation.username == Storage.SushiLushiState.loggedUser.username) {
                    UISystem.Output.WriteLine(ConsoleColor.Green, "");
                    UISystem.Output.WriteLine(ConsoleColor.Green, "| Datum: " + reservation.datetime.ToString());
                    UISystem.Output.WriteLine(ConsoleColor.Green, "| Aantal personen: " + reservation.amountPeople);
                    UISystem.Output.WriteLine(ConsoleColor.Green, "");
                }
            }
            
            UISystem.Input.ReadString("(Druk op enter om verder te gaan)");
            StartPage.Display();
        }  
    }
}