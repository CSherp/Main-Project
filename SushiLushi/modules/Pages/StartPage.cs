using System;
using System.Linq;
using System.Collections.Generic;

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
                Console.WriteLine(@".s.                                      Prijzen:                                      .s.");
                Console.WriteLine(@".s.                                                                                    .s.");
                Console.WriteLine(@".s.         maandag t/m woensdag                        donderdag t/m zondag           .s.");
                Console.WriteLine(@".s.                                                                                    .s.");
                Console.WriteLine(@".s.    Persoon 12+ lunch       : 21.50             Persoon 12+ lunch       : 23.50     .s.");
                Console.WriteLine($".s.    Persoon 12+ diner       : 29.50             Persoon 12+ diner       : 32.50     .s.");
                Console.WriteLine($".s.    Persoon 4 t/m 11 lunch  : 13.50             Persoon 4 t/m 11 lunch  : 13.50     .s.");
                Console.WriteLine(@".s.    Persoon 4 t/m 11 diner  : 15.95             Persoon 4 t/m 11 diner  : 15.95     .s.");
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
                menu.Add("Reglement COVID-19", Reglement.Display);
            }

            // Ingelogd als gebruiker
            if (Storage.SushiLushiState.isLoggedIn && !Storage.SushiLushiState.isAdmin) {
                menu.Add("Reserveren", ReserveerPage.Display);
                menu.Add("Mijn reserveringen", listReservations);
                menu.Add("Reservering aanpassen", changeReservation);
                menu.Add("Menu bekijken", MenuList.Display);
                menu.Add("Reglement COVID-19", Reglement.Display);
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

        public static void changeReservation() {
            page.Update();

            UISystem.Output.WriteLine(ConsoleColor.Cyan, "Dit zijn uw reserveringen:");

            List<Storage.Reservation> userReservations = new List<Storage.Reservation>();

            foreach (Storage.Reservation reservation in Storage.System.data.reservations) {
                if (reservation.username == Storage.SushiLushiState.loggedUser.username) {
                    userReservations.Add(reservation);
                }
            }

            int index = 1;
            foreach (Storage.Reservation reservation in userReservations) {
                    System.Console.ForegroundColor = System.ConsoleColor.Cyan;
                    Console.WriteLine("");
                    System.Console.Write("[" + index + "] ");
                    System.Console.ForegroundColor = System.ConsoleColor.Gray;
                    UISystem.Output.WriteLine(ConsoleColor.Green, " | Gebruikersnaam: " + reservation.username);
                    UISystem.Output.WriteLine(ConsoleColor.Green, "     | Datum: " + reservation.datetime.ToString());
                    UISystem.Output.WriteLine(ConsoleColor.Green, "     | Aantal personen: " + reservation.amountPeople);
                    UISystem.Output.WriteLine(ConsoleColor.Green, "");
                    System.Console.Write("\n");
                    index++;
            }

            int selectedIndex = UISystem.Input.ReadInt("Selecteer een reservering:", 1, index);
            Storage.Reservation currentReservation = userReservations[selectedIndex - 1];
            
            UISystem.Output.WriteLine(ConsoleColor.Cyan, "");
            UISystem.Output.WriteLine(ConsoleColor.Cyan, "Wat wilt u doen met de geselecteerde reservering?");
            
            UISystem.Menu menu = new UISystem.Menu();
            menu.Add("Reservering datum verplaatsen", null);
            menu.Add("Terug naar menu", StartPage.Display);
            menu.Display();

            //
            // Remove old table reservation
            //
            foreach (Storage.Table table in Storage.System.data.tables) {
                foreach(Storage.TableReservation tablereservation in table.reservations.ToList()) {
                    if (tablereservation.reservationId == currentReservation.id) {
                        table.reservations.Remove(tablereservation);
                    }
                }
            }

            //
            // Select new datetime
            //

            bool selectedNew = false;
            DateTime selectedDateTime;

            while(!selectedNew) {
                //
                // Datum
                //
                
                Console.Write("Vandaag is het ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                DateTime today = DateTime.Now;  
                Console.WriteLine(today.ToString("dddd") + " " + today.Date.ToString("dd-MM-yyyy"));
                Console.ResetColor();

                Console.WriteLine("Kies een dag:");

                DateTime[] available_dates = new DateTime[] { today.AddDays(1), today.AddDays(2), today.AddDays(3), today.AddDays(4), today.AddDays(5) };

                var dateSelectMenu = new UISystem.Menu();

                foreach (DateTime value in available_dates) {
                    dateSelectMenu.Add(value.ToString("dddd") + " " + value.Date.ToString("dd-MM"));
                }

                dateSelectMenu.Display();

                int dateSelectIndex = dateSelectMenu.GetSelectedIndex(); 
                Console.Write("U heeft gekozen voor: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(available_dates[dateSelectIndex -1].ToString("dddd") + " " + available_dates[dateSelectIndex -1].Date.ToString("dd-MM"));
                Console.ResetColor();

                //
                // Tijd
                //

                Console.WriteLine("Kies een tijd: ");
                
                TimeSpan[] available_times = new TimeSpan[] { new TimeSpan(13, 00, 00), new TimeSpan(16, 00, 00), new TimeSpan(18, 00, 00), new TimeSpan(20, 00, 00)};
                var timeSelectMenu = new UISystem.Menu();

                foreach (TimeSpan value in available_times) {
                    timeSelectMenu.Add("Vanaf: " + value.ToString(@"hh\:mm"));
                }

                timeSelectMenu.Display();
                
                int timeSelectIndex = timeSelectMenu.GetSelectedIndex();
                page.Update();
                Console.Write("U heeft gekozen voor: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(available_dates[dateSelectIndex].ToString("dddd") + " " + available_dates[dateSelectIndex].Date.ToString("dd-MM") + " " + available_times[timeSelectIndex - 1].ToString(@"hh\:mm"));
                Console.ResetColor();

                // voeg tijd en datum bij elkaar tot een datetime object
                DateTime reservationDatetime = new DateTime(
                    available_dates[dateSelectIndex].Year,
                    available_dates[dateSelectIndex].Month,
                    available_dates[dateSelectIndex].Day,
                    available_times[timeSelectIndex - 1].Hours,
                    available_times[timeSelectIndex - 1].Minutes,
                    0
                );

                //
                // Table Checking
                //

                List<Storage.Table> SortedList = Storage.System.data.tables.OrderBy(o => o.size).ToList();

                bool foundTable = false;
                
                foreach (Storage.Table table in SortedList) {
                    if (foundTable) {
                        break;
                    }

                    else if (table.size >= currentReservation.amountPeople) {
                        bool timeAvailable = true;

                        foreach(Storage.TableReservation tablereservation in table.reservations) {
                            if (tablereservation.datetime == reservationDatetime) {
                                timeAvailable = false;
                            }
                        }

                        if (timeAvailable) {
                            Storage.TableReservation newTable = new Storage.TableReservation();
                            newTable.datetime = reservationDatetime;
                            newTable.reservationId = currentReservation.id;
                            table.reservations.Add(newTable);
                            foundTable = true;
                        }
                    }
                }

                if (!foundTable){
                    UISystem.Input.ReadString("Er zijn op het selecteerde moment geen plekken beschikbaar. (Druk op enter om verder te gaan)");
                    page.Update();
                }

                selectedNew = true;
                selectedDateTime = reservationDatetime;
            }

             // Sla de huidige gegevens op
            Storage.System.SaveStorage();
            
            UISystem.Input.ReadString("Reservering is verplaatst naar nieuwe datum. (Druk op enter om verder te gaan)");
            StartPage.Display();
        }
    }
}