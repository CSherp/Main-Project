using System;
using System.Text.RegularExpressions;
namespace SushiLushi {
    class AdminPageUser {
        public static UISystem.Page page = new UISystem.Page("Admin pagina");

        public static void Display () {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Gebruikers weergeven", listAllUsers)
                .Add("Gebruiker toevoegen", AddUser)
                .Add("Gebruiker aanpassen", change)
                .Add("Gebruiker verwijderen", RemoveUser)
                .Add("Terug naar start", StartPage.Display);

            menu.Display();
        }

        private static void listAllUsers() {
            page.Update();
            UISystem.Output.WriteLine(System.ConsoleColor.Cyan, "\nDit zijn alle gebruikers in het systeem!");

            int index = 1;
            foreach (Storage.User user in Storage.System.data.users) {
                System.Console.ForegroundColor = System.ConsoleColor.Cyan;
                System.Console.WriteLine("");
                System.Console.Write("[" + index + "] ");
                System.Console.ForegroundColor = System.ConsoleColor.Gray;
                System.Console.WriteLine("Username: " + user.username);
                System.Console.WriteLine("    Email: " + user.email);
                index++;
            }
            System.Console.WriteLine("");
            UISystem.Input.ReadString("\n(Druk op enter om verder te gaan)");
            Display();
        }

        private static void change(){

        }
        private static void AddUser() {
            page.Update();
            Console.WriteLine("");
            // Maak keuze registreren admin of gebruiker 
            var menu1 = new UISystem.Menu();

            menu1.Add("Nieuwe admin registreren", null);
            menu1.Add("Nieuwe gebruiker registreren", null);

            menu1.Display();
            
            int index_menu1 = menu1.GetSelectedIndex();
            int echte_index = index_menu1 - 1; 
            // Console.WriteLine(echte_index);

            page.Update();
            Console.WriteLine("");
            // Wordt gevraagd om invoeren van email
            Console.WriteLine("Voer uw emailadres in:");
            var email = Console.ReadLine().ToLower();
            // Als er geen geldige mail wordt ingevoerd komt er een foutmelding
            while(!(email.Contains('@') && email.Contains('.')) || email.Contains(' ')){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.WriteLine("Emailadres NIET geldig. Probeer nogmaals:");
                Console.ResetColor();
                email = Console.ReadLine().ToLower();
            }

            while(!RegisterPage.Check(email)){
                page.Update();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nDit emailadres is al in gebruik. Probeer nogmaals: ");
                Console.ResetColor();
                email = Console.ReadLine().ToLower();
            }

            Console.WriteLine("");
            // Wordt gevraagd om nogmaals invoeren van email
            Console.WriteLine("Voer uw emailadres nogmaals in:");
            string repeatEmail = Console.ReadLine().ToLower();

            // Als de 2e mail niet overeen komt geeft deze foutmelding
            while(email != repeatEmail){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.WriteLine("De emailadressen komen NIET overeen. Probeer nogmaals:");
                Console.ResetColor();
                repeatEmail = Console.ReadLine().ToLower();
            }

            page.Update();
            Console.WriteLine("");
            // Wordt gevraagd om invoeren van gebruikersnaam
            Console.WriteLine("Voer uw gebruikersnaam in:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("LET OP: hoofdletter gevoelig");
            Console.ResetColor();
            var username = Console.ReadLine();
            while(!RegisterPage.Check(username)){
                page.Update();
                Console.WriteLine("Deze gebruikersnaam is al in gebruik. Probeer nogmaals: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("LET OP: hoofdletter gevoelig");
                Console.ResetColor();
                username = Console.ReadLine(); 
            }

            while(username.Contains(' ')){
                Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("");
                    Console.WriteLine("Gebruikersnaam mag GEEN spaties bevatten. Probeer nogmaals:");
                    Console.ResetColor();
                    username = Console.ReadLine();
            }

            page.Update();
            Console.WriteLine("");
            // Wordt gevraagd om invoeren van wachtwoord
            Console.WriteLine("Voer uw wachtwoord in:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Wachtwoord moet bestaan uit 8 karakters met een cijfer, een hoofdletter en een speciaal karakter");
            Console.ResetColor();
            var password = Console.ReadLine();
        

            bool isNumber = false;
            bool isChar = false;
            while(isNumber == false || isChar == false){
                isNumber = false;
                isChar = false;
                var regexChar = new Regex("[^a-zA-Z0-9]+");
                var regexDigit = new Regex("[0-9]");
                while(password.Length < 8){
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("");
                    Console.WriteLine("Wachtwoord bevat GEEN 8 karakters. Probeer nogmaals:");
                    Console.ResetColor();
                    password = Console.ReadLine();
                }


                if (regexDigit.IsMatch(password))
                    isNumber = true;
         
                if (regexChar.IsMatch(password))
                    isChar = true;

                if(isNumber == false || isChar == false){
                    if(isNumber == false && isChar == false){
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("");
                    Console.WriteLine("Wachtwoord bevat GEEN digit en GEEN speciaal karakter. Probeer nogmaals:");
                    Console.ResetColor();
                    password = Console.ReadLine();
                    }
                    else if(isNumber == false){
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("");
                        Console.WriteLine("Wachtwoord bevat GEEN digit. Probeer nogmaals:");
                        Console.ResetColor();
                        password = Console.ReadLine();
                    }
                    else if (isChar == false){
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("");
                        Console.WriteLine("Wachtwoord bevat GEEN speciaal karakter. Probeer nogmaals:");
                        Console.ResetColor();
                        password = Console.ReadLine();
                    }
                }
            }
            
            Console.WriteLine("");
            // Wordt gevraagd om nogmaals invoeren van wachtwoord
            Console.WriteLine("Voer uw wachtwoord nogmaals in:");
            string repeatPassword = Console.ReadLine();

            // Als de 2e wachtwoord niet overeen komt geeft deze foutmelding
            while(password != repeatPassword){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nDe wachtwoorden komen NIET overeen. Probeer nogmaals:");
                Console.ResetColor();
                repeatPassword = Console.ReadLine();

            }

            // Maak nieuw user object aan
            // Stel de gegevens in (properties) 
            // Verschil tussen admin / user

            Storage.User newUser = new Storage.User() {
                username = username,
                email = email,
                password = password,
                role = "user"
            };

            if (echte_index == 0) {
                newUser.role = "admin";
            }

            // Voeg toe aan storge user list
            Storage.System.data.users.Add(newUser);

            // Sla de huidige gegevens op
            Storage.System.SaveStorage();
            page.Update();
            if (echte_index == 0) {
                UISystem.Input.ReadString("\nU heeft succesvol een nieuwe admin geregistreerd!  (klik op enter om door te gaan)");
            } else {
                UISystem.Input.ReadString("\nU heeft succesvol een nieuwe gebruiker geregistreerd! (klik op enter om door te gaan)");
            }
            
            StartPage.Display();
        }
        private static void RemoveUser() {
                while(true){
                page.Update();
                UISystem.Output.WriteLine(System.ConsoleColor.Cyan, "\nDit zijn alle geregistreerde accounts in het systeem:");
                int index = 1;
                foreach (Storage.User user in Storage.System.data.users) {
                System.Console.ForegroundColor = System.ConsoleColor.Cyan;
                System.Console.WriteLine("");
                System.Console.ForegroundColor = System.ConsoleColor.Cyan;
                System.Console.Write("[" + index + "] ");
                Console.ResetColor();
                System.Console.WriteLine("Username: " + user.username);
                System.Console.WriteLine("    Email: " + user.email);
                index++;
                }
                System.Console.ForegroundColor = System.ConsoleColor.Cyan;
                Console.WriteLine("");
                System.Console.Write("[" + index + "] ");
                UISystem.Output.WriteLine(ConsoleColor.White, "Terug naar vorige pagina\n");
                index = index+1;
                Console.Write("Selecteer een keuze: ");
                int n = Convert.ToInt32(Console.ReadLine());
                while(n < 1 || n >= index){
                    Console.Write($"Selecteer een keuze (1 t/m {index-1}): ");
                    n = Convert.ToInt32(Console.ReadLine());
                }

                if(n == (index-1))
                    Display();
                else if (n == 1){
                    page.Update();
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Username: " + Storage.System.data.users[n-1].username);
                    System.Console.WriteLine("Email: " + Storage.System.data.users[n-1].email);
                    System.Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    UISystem.Input.ReadString("\nDit account kan NIET worden verwijderd. Druk enter om verder te gaan");
                    Console.ResetColor();
                }
                else{
                    page.Update();
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Username: " + Storage.System.data.users[n-1].username);
                    System.Console.WriteLine("Email: " + Storage.System.data.users[n-1].email);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nWeet u zeker dat u dit account wilt verwijderen y/n?");
                    Console.ResetColor();
                    var t = Console.ReadLine().ToLower();
                    while(!(t == "y" || t == "n")){
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Weet u zeker dat u dit account wilt verwijderen y/n?");
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
}