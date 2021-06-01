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

                //Array met mogelijke keuzes
                string[] Choice = {"Meat", "Fish", "Vegan"};
                
                //Array met alle maaltijden van "Meat", "Fish" en "Vegan"
                string[][] MenuLijst = {
                    new string[] {"Surf n' turf roll", "Carpaccio roll", "Beef roll", "Tournedos", "Usuyaki", "Beef lettuce wrap", "Japanese burger", "Beef tataki"},
                    new string[] {"Maki zalm", "Maki tonijn", "Nigiri zalm", "Nigiri tonijn", "California roll", "Crunchy california roll", "Spicy tonijn roll", "Ebi tempura roll", "Zalm sashimi", "Tonijn sashimi"},
                    new string[] {"Nigir tamago", "Maki Komkommer", "Maki avocado", "Crispy mayo roll", "Wakame tamaki", "Edamame"}
                };
                string[] show = new string[4];
                int showAmount = 4;
                int index;
                string food;

                //Zorgt voor 4 willekeurige maaltijden en stopt ze in de array "show"
                for (int i = 0; i < showAmount; i++){
                    index = Random(Choice.Length);
                    food = MenuLijst[index][Random(MenuLijst[index].Length)];
                    bool run = true;
                    while (run){
                        food = MenuLijst[index][Random(MenuLijst[index].Length)];
                        if (show[0] == null && food.Length == 9 && !show.Contains(food)){
                            show[0] = food;
                            run = false;
                        }
                        else if (show[1] == null && food.Length == 11 && !show.Contains(food)){
                            show[1] = food;
                            run = false;
                        }
                        else if (show[2] == null && food.Length == 14 && !show.Contains(food)){
                            show[2] = food;
                            run = false;
                        }
                        else if (show[3] == null && food.Length == 12 && !show.Contains(food)){
                            show[3] = food;
                            run = false;
                        }
                    }
                }

                //Zorgt voor 4 willekeurige prijzen voor de maaltijden
                string[] price = {"6.75", "7.50", "8.00", "8.50", "9.00", "9.50", "10.00", "12.50", "14.00", "15.00"};
                string[] ChosenPrices = new string[4];
                for (int i = 0; i < showAmount; i++){
                    string randomprice = price[Random(price.Length)];
                    bool run = true;
                    while (run){
                        if (ChosenPrices[0] == null && randomprice.Length == 4 && !ChosenPrices.Contains(randomprice)){
                            ChosenPrices[0] = randomprice;
                            run = false;
                            break;
                        }
                        else if (ChosenPrices[1] == null && randomprice.Length == 5 && !ChosenPrices.Contains(randomprice)){
                            ChosenPrices[1] = randomprice;
                            run = false;
                            break;
                        }
                        else if (ChosenPrices[2] == null && randomprice.Length == 4 && !ChosenPrices.Contains(randomprice)){
                            ChosenPrices[2] = randomprice;
                            run = false;
                            break;
                        }
                        else if (ChosenPrices[3] == null && randomprice.Length == 5 && !ChosenPrices.Contains(randomprice)){
                            ChosenPrices[3] = randomprice;
                            run = false;
                            break;
                        }
                    }
                   
                }

                Tuple<string, string, string, string> prices = Tuple.Create(ChosenPrices[0], ChosenPrices[1], ChosenPrices[2], ChosenPrices[3]);


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine(@"`----------------------------------------------------------------------------------------`");  
                Console.WriteLine(@".s:------------------------------------------------------------------------------------:s.");
                Console.WriteLine(@".s.                                                                                    .s.");
                Console.WriteLine(@".s.                               Maaltijden van de dag:                               .s.");
                Console.WriteLine(@".s.                                                                                    .s.");
                Console.WriteLine($".s.                 {show[0]}:     {prices.Item1}            {show[2]}:   {prices.Item3}              .s.");
                Console.WriteLine($".s.                 {show[1]}:   {prices.Item2}           {show[3]}:   {prices.Item4}               .s.");
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
            UISystem.Output.WriteLine(System.ConsoleColor.White, "Welkom bij Sushi Lushi, het beste Sushi Restaurant in de wereld!");
            UISystem.Output.WriteLine(System.ConsoleColor.White, "Maak uw keuze!");
            UISystem.Output.WriteLine(System.ConsoleColor.White, "--------------------------");
            var menu = new UISystem.Menu()
                .Add("Login", LoginPage.Display)
                .Add("Registreren", RegisterPage.Display)
                .Add("Reserveren", ReserveerPage.Display)
                .Add("Menu", MenuList.Display);
            
            menu.Display();
        }   
    }
}