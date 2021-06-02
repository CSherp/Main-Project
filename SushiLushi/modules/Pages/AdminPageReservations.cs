using System;
using System.Text.Json;


namespace SushiLushi {
    class AdminPageReservations {
        public static UISystem.Page page = new UISystem.Page("Admin pagina");

        public static void Display () {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Reservering weergeven", listAllReservations)
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
                index++;
                Console.Write("Selecteer een keuze: ");
                int n = Convert.ToInt32(Console.ReadLine());
                while(!(n >= 1 || n <= index)){
                    Console.Write("Selecteer een keuze: ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                if(n == index)
                    Display();

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
                    UISystem.Input.ReadString("\nReservering succesvol verwijderd! (Druk op enter om verder te gaan)");
                    Display();
                    break;
                }
            }

            
        }
    }
}