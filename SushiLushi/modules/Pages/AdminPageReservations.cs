using System;

namespace SushiLushi {
    class AdminPageReservations {
        public static UISystem.Page page = new UISystem.Page("Admin pagina");

        public static void Display () {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Reservering weergeven", listAllReservations)
                .Add("Reserveringen aanpassen", ChangeReservations)
                .Add("Reserveringen verwijderen")
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
        public static void ChangeReservations(){

        }
    }
}