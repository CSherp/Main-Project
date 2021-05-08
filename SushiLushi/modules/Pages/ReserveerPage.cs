using System;
namespace SushiLushi {
    class ReserveerPage {
        public static UISystem.Page page = new UISystem.Page("Reserveer pagina");
        public static void Display () {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Ik wil reserveren", Reserveer)
                .Add("Terug naar start", StartPage.Display);

            menu.Display();
        }

        private static void Reserveer() {

            int aantal_mensen = UISystem.Input.ReadInt("Voer het aantal personen in waarmee u komt:", 1, 5);
            DateTime today = DateTime.Now;  
            // Console.WriteLine("Vandaag is het " + today.ToString("dddd") + " " + today.Date.ToString("dd-MM-yyyy"));
            Console.Write("Vandaag is het ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(today.ToString("dddd") + " " + today.Date.ToString("dd-MM-yyyy"));
            Console.ResetColor();
            Console.WriteLine("Kies een dag:");

            var menu2 = new UISystem.Menu()
                .Add(today.AddDays(1).ToString("dddd") + " " + today.AddDays(1).Date.ToString("dd-MM"), null)
                .Add(today.AddDays(2).ToString("dddd") + " " + today.AddDays(2).Date.ToString("dd-MM"), null)
                .Add(today.AddDays(3).ToString("dddd") + " " + today.AddDays(3).Date.ToString("dd-MM"), null);

            menu2.Display();

            int index_menu2 = menu2.GetSelectedIndex(); 
            Console.Write("Je hebt gekozen voor: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(today.AddDays(index_menu2).ToString("dddd") + " " + today.AddDays(index_menu2).Date.ToString("dd-MM"));
            Console.ResetColor();            
            Console.WriteLine("Kies een tijd: ");
            
            var menu3 = new UISystem.Menu()
                .Add("Vanaf 13:00", null)
                .Add("Vanaf 16:00", null)
                .Add("Vanaf 19:00", null);

            menu3.Display();

            int index_menu3 = menu3.GetSelectedIndex();
            Console.Write("Je hebt gekozen voor: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(today.AddDays(index_menu2).ToString("dddd") + " " + today.AddDays(index_menu2).Date.ToString("dd-MM") + " om ..... ");
            Console.ResetColor();  
            
            string dieet_wensen = UISystem.Input.ReadString("Heeft u dieet wensen/ alergieën?");
        }
        private static void GoToStart() {
            StartPage.Display();        }

        // public static void GekleurdTekstje(ConsoleColor color, string text)
        // {
        //     ConsoleColor originalColor = Console.ForegroundColor;
        //     Console.ForegroundColor = color;
        //     Console.Write(text);
        //     Console.ForegroundColor = originalColor;
        // }
    }
}