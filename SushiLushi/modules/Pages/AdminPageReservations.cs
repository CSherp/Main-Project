using System;
using System.Linq;
using System.Collections.Generic;


namespace SushiLushi {
    class AdminPageReservations {
        public static UISystem.Page page = new UISystem.Page("Admin pagina");

        public static void Display () {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Reservering weergeven", listAllReservations)
                .Add("Reservering toevoegen", Add)
                .Add("Reserveringen aanpassen", Change)
                .Add("Reserveringen verwijderen", Remove)
                .Add("Terug naar start", StartPage.Display);

            menu.Display();
        }
        public static void listAllReservations(){
            page.Update();
            UISystem.Output.WriteLine(System.ConsoleColor.Cyan, "\nDit zijn alle reserveringen in het systeem:");

            int index = 1;
            foreach (Storage.Reservation reservation in Storage.System.data.reservations) {
                System.Console.ForegroundColor = System.ConsoleColor.Cyan;
                Console.WriteLine("");
                System.Console.Write("[" + index + "] ");
                System.Console.ForegroundColor = System.ConsoleColor.Gray;
                UISystem.Output.WriteLine(ConsoleColor.Green, reservation.guestAccount ? " | Gastgebruiker: " + reservation.fullname + " - " + reservation.email :  " | Gebruikersnaam: " + reservation.username);
                UISystem.Output.WriteLine(ConsoleColor.Green, "     | Datum: " + reservation.datetime.ToString());
                UISystem.Output.WriteLine(ConsoleColor.Green, "     | Aantal personen: " + reservation.amountPeople);
                UISystem.Output.WriteLine(ConsoleColor.Green, "");
                System.Console.Write("\n");
                index++;
            }

            UISystem.Input.ReadString("(Druk op enter om verder te gaan)");
            Display();
        }
        public static void Add(){
            page.Update();
            var name = "";
            var email = "";
            Console.WriteLine("\nVoer het emailadres in:");
            email = Console.ReadLine().ToLower();
            // Als er geen geldige mail wordt ingevoerd komt er een foutmelding
            while(!(email.Contains('@') && email.Contains('.')) || email.Contains(' ')){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.WriteLine("Emailadres NIET geldig. Probeer nogmaals:");
                Console.ResetColor();
                email = Console.ReadLine();
            }
            page.Update();
            Console.WriteLine("\nVoer de voor en achternaam in:");
            name = Console.ReadLine();
        
            page.Update();
            int aantal_mensen = UISystem.Input.ReadInt("Voer het aantal personen in:", 1, 5);
            List<Storage.Table> SortedList = Storage.System.data.tables.OrderBy(o => o.size).ToList();
            int reservationID = new Random().Next(100000, 999999);
            bool foundTable = false;
            foreach (Storage.Table table in SortedList){
                if (!table.available){
                    continue;
                }
                if (table.size >= aantal_mensen){
                    table.available = false;
                    table.reservationID = reservationID;
                    foundTable = true;
                    break;
                }
                else {
                    continue;
                }
            }
            if (!foundTable){
                UISystem.Input.ReadString("Er zijn geen plekken beschikbaar. Druk op enter om terug te gaan naar het startscherm.");
                StartPage.Display();
            }



            //
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

            var menu2 = new UISystem.Menu();

            foreach (DateTime value in available_dates) {
                menu2.Add(value.ToString("dddd") + " " + value.Date.ToString("dd-MM"));
            }

            menu2.Display();

            int index_menu2 = menu2.GetSelectedIndex(); 
            Console.Write("U hebt gekozen voor: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(available_dates[index_menu2 -1].ToString("dddd") + " " + available_dates[index_menu2 -1].Date.ToString("dd-MM"));
            Console.ResetColor();

            //
            // Tijd
            //

            Console.WriteLine("Kies een tijd: ");
            
            TimeSpan[] available_times = new TimeSpan[] { new TimeSpan(13, 00, 00), new TimeSpan(16, 00, 00), new TimeSpan(18, 00, 00), new TimeSpan(20, 00, 00)};
            var menu3 = new UISystem.Menu();

            foreach (TimeSpan value in available_times) {
                menu3.Add("Vanaf: " + value.ToString(@"hh\:mm"));
            }

            menu3.Display();
            
            int index_menu3 = menu3.GetSelectedIndex();
            page.Update();
            Console.Write("U hebt gekozen voor: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(available_dates[index_menu2].ToString("dddd") + " " + available_dates[index_menu2].Date.ToString("dd-MM") + " " + available_times[index_menu3 - 1].ToString(@"hh\:mm"));
            Console.ResetColor();  

            //
            // Dieet opmerkingen
            //
            
            int[] Arr_Opties = new int[aantal_mensen];  
            string[] Arr2 = new string[] { "Geen", "Vegetarisch", "Veganistisch", "Glutenvrij", "Notenallergie" };
            
            int counter_mensen = 1; 
            for (int i = 0; i < aantal_mensen; i++) { 
                Console.Write("Zijn er personen met dieet wensen/ alergieën?");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (i == 0)
                    Console.WriteLine(" Dieet wensen/ alergieën persoon " + counter_mensen);
                else
                    Console.WriteLine(" Persoon " + counter_mensen);
                Console.ResetColor();  

                var menu4 = new UISystem.Menu();

                foreach (string value in Arr2) {
                    menu4.Add(value);
                }

                menu4.Display();

                int index_menu4 = menu4.GetSelectedIndex();
                Arr_Opties[i] = index_menu4; 
                counter_mensen++; 
            }

            Console.WriteLine("Eetwensen personen: ");
            string[] people_notes = new string[aantal_mensen];
            for (int i = 0; i < aantal_mensen; i++) {
                int optie_menu = Arr_Opties[i];
                int index_onnodig = i+1;
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Persoon " + index_onnodig + ": "); 
                Console.ResetColor();  
                Console.WriteLine(Arr2[optie_menu - 1]); 

                people_notes[i] = Arr2[optie_menu - 1];
            }

        

            // voeg tijd en datum bij elkaar tot een datetime object
            DateTime reservationDatetime = new DateTime(
                available_dates[index_menu2].Year,
                available_dates[index_menu2].Month,
                available_dates[index_menu2].Day,
                available_times[index_menu3 - 1].Hours,
                available_times[index_menu3 - 1].Minutes,
                0
            );

            Storage.Reservation newReservation = new Storage.Reservation() {
                guestAccount = true,
                id = reservationID,
                username = "",
                fullname = name,
                email = email,
                amountPeople = aantal_mensen,
                peopleNotes = people_notes,
                datetime = reservationDatetime
            };

            Storage.System.data.reservations.Add(newReservation);
            Storage.System.SaveStorage();

            UISystem.Input.ReadString("U heeft succesvol een reservering geplaatst! (Klik op enter om door te gaan)");
            StartPage.Display();
        }
        public static void Change(){

        }
        public static void Remove(){
            while(true){
                page.Update();
                UISystem.Output.WriteLine(System.ConsoleColor.Cyan, "\nDit zijn alle reserveringen in het systeem:");
                int index = 1;
                foreach (Storage.Reservation reservation in Storage.System.data.reservations) {
                    System.Console.ForegroundColor = System.ConsoleColor.Cyan;
                    Console.WriteLine("");
                    System.Console.Write("[" + index + "] ");
                    System.Console.ForegroundColor = System.ConsoleColor.Gray;
                    UISystem.Output.WriteLine(ConsoleColor.Green, reservation.guestAccount ? " | Gastgebruiker: " + reservation.fullname + " - " + reservation.email :  " | Gebruikersnaam: " + reservation.username);
                    UISystem.Output.WriteLine(ConsoleColor.Green, "     | Datum: " + reservation.datetime.ToString());
                    UISystem.Output.WriteLine(ConsoleColor.Green, "     | Aantal personen: " + reservation.amountPeople);
                    UISystem.Output.WriteLine(ConsoleColor.Green, "");
                    System.Console.Write("\n");
                    index++;
                }
                System.Console.ForegroundColor = System.ConsoleColor.Cyan;
                Console.WriteLine("");
                System.Console.Write("[" + index + "] ");
                UISystem.Output.WriteLine(ConsoleColor.White, " Terug naar vorige pagina\n");
                UISystem.Output.WriteLine(ConsoleColor.Green, "");
                index = index+1;
                Console.Write("Selecteer een keuze: ");
                int n = Convert.ToInt32(Console.ReadLine());
                while(n < 1 || n >= index){
                    Console.Write($"Selecteer een keuze (1 t/m {index-1}): ");
                    n = Convert.ToInt32(Console.ReadLine());
                }

                if(n == (index-1))
                    Display();
                else{
                    page.Update();
                    System.Console.ForegroundColor = System.ConsoleColor.Gray;
                    UISystem.Output.WriteLine(ConsoleColor.Green, "");
                    UISystem.Output.WriteLine(ConsoleColor.Green, Storage.System.data.reservations[n-1].guestAccount ? " | Gastgebruiker: " + Storage.System.data.reservations[n-1].fullname + " - " + Storage.System.data.reservations[n-1].email :  " | Gebruikersnaam: " + Storage.System.data.reservations[n-1].username);
                    UISystem.Output.WriteLine(ConsoleColor.Green, " | Datum: " + Storage.System.data.reservations[n-1].datetime.ToString());
                    UISystem.Output.WriteLine(ConsoleColor.Green, " | Aantal personen: " + Storage.System.data.reservations[n-1].amountPeople);
                    UISystem.Output.WriteLine(ConsoleColor.Green, "");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Weet u zeker dat u deze reservering wilt verwijderen y/n?");
                    Console.ResetColor();
                    var t = Console.ReadLine().ToLower();
                    while(!(t == "y" || t == "n")){
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Weet u zeker dat u deze reservering wilt verwijderen y/n?");
                    Console.ResetColor();
                    t = Console.ReadLine().ToLower();
                    }
                    if(t == "y"){
                        Storage.System.data.reservations.Remove(Storage.System.data.reservations[n-1]);
                        Storage.System.SaveStorage();
                        page.Update();
                        Console.WriteLine("");
                        UISystem.Input.ReadString("Reservering succesvol verwijderd! (Druk op enter om verder te gaan)");
                        Display();
                        break;
                    }
                }
                
            }

            
        }
    }
}