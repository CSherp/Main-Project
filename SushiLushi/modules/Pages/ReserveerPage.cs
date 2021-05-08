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
            Console.Write("Vandaag is het ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(today.ToString("dddd") + " " + today.Date.ToString("dd-MM-yyyy"));
            Console.ResetColor();
            Console.WriteLine("Kies een dag:");

            var menu2 = new UISystem.Menu()
                .Add(today.AddDays(1).ToString("dddd") + " " + today.AddDays(1).Date.ToString("dd-MM"))
                .Add(today.AddDays(2).ToString("dddd") + " " + today.AddDays(2).Date.ToString("dd-MM"))
                .Add(today.AddDays(3).ToString("dddd") + " " + today.AddDays(3).Date.ToString("dd-MM"));

            menu2.Display();

            int index_menu2 = menu2.GetSelectedIndex(); 
            Console.Write("Je hebt gekozen voor: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(today.AddDays(index_menu2).ToString("dddd") + " " + today.AddDays(index_menu2).Date.ToString("dd-MM"));
            Console.ResetColor();            
            Console.WriteLine("Kies een tijd: ");
            
            string[] Arr = new string[] {"Vanaf 13:00","Vanaf 16:00","Vanaf 19:00"};

            var menu3 = new UISystem.Menu();
                foreach (string value in Arr) {
                    menu3.Add(value);
                }

            menu3.Display();
            
            int index_menu3 = menu3.GetSelectedIndex();
            Console.Write("Je hebt gekozen voor: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(today.AddDays(index_menu2).ToString("dddd") + " " + today.AddDays(index_menu2).Date.ToString("dd-MM") + " " + Arr[index_menu3 - 1]);
            Console.ResetColor();  
            
            int[] Arr_Opties = new int[aantal_mensen];  
            string[] Arr2 = new string[] {"Geen","Vegetarisch","Veganistisch","Glutenvrij","Notenallergie"};
            
            int counter_mensen = 1; 
            for (int i = 0; i < aantal_mensen; i++) { 
                Console.Write("Heeft u dieet wensen/ alergieën?");
                Console.ForegroundColor = ConsoleColor.Yellow;
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
            for (int i = 0; i < aantal_mensen; i++) {
                int optie_menu = Arr_Opties[i];
                int index_onnodig = i+1;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Persoon " + index_onnodig + ": "); 
                Console.ResetColor();  
                Console.WriteLine(Arr2[optie_menu-1]); 
            }
        }
        private static void GoToStart() {
            StartPage.Display();        }

    }
}