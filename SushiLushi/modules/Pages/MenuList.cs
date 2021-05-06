using System;

namespace SushiLushi {
    class MenuList{

        public static void showInfoFish(){
            page.Update();
            string[][] Fish = {
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Zalmfilet","Norivel(zeewier)"}, 
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Tonijnfilet","Norivel(zeewier)"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Zalmfilet"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Tonijnfilet"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Ebi tempura","Norivel(zeewier)", "Avocado", "Komkommer", "Tobiko","Gebakken ui", "Mayonaise", "Wasabi"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Zalmfilet","Norivel(zeewier)", "Avocado", "Komkommer", "Tobiko", "Mayonaise", "Wasabi"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Tonijnfilet","Norivel(zeewier)", "Avocado", "Bosui", "Sesamzaad", "Mayonaise", "Sriracha"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Ebi tempura","Norivel(zeewier)", "Sesamzaad","Gebakken ui", "Mayonaise", "Wasabi"},
                new string[] {"Zalmfilet", "Sesamzaad", "Bosui"},
                new string[] {"Tonijnfilet", "Sesamzaad", "Bosui"}
                };
                Console.WriteLine("");
                for (int j = 0; j < Fish[0].Length; j++){
                    Console.WriteLine($"- {Fish[0][j]}");
                }
                var menu = new UISystem.Menu()
                .Add("Terug naar visgerechten", fish);

            menu.Display();
            }
            public static void showInfoFlesh(){
                page.Update();
            string[][] Flesh = {
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Zalmfilet","Norivel(zeewier)"}, 
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Tonijnfilet","Norivel(zeewier)"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Zalmfilet"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Tonijnfilet"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Ebi tempura","Norivel(zeewier)", "Avocado", "Komkommer", "Tobiko","Gebakken ui", "Mayonaise", "Wasabi"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Zalmfilet","Norivel(zeewier)", "Avocado", "Komkommer", "Tobiko", "Mayonaise", "Wasabi"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Tonijnfilet","Norivel(zeewier)", "Avocado", "Bosui", "Sesamzaad", "Mayonaise", "Sriracha"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Ebi tempura","Norivel(zeewier)", "Sesamzaad","Gebakken ui", "Mayonaise", "Wasabi"},
                new string[] {"Zalmfilet", "Sesamzaad", "Bosui"},
                new string[] {"Tonijnfilet", "Sesamzaad", "Bosui"}
                };
                Console.WriteLine("");
                for (int j = 0; j < Flesh[0].Length; j++){
                    Console.WriteLine($"- {Flesh[0][j]}");
                }
                var menu = new UISystem.Menu()
                .Add("Terug naar vleesgerechten", flesh);

            menu.Display();
            }
            public static void showInfoVegan(){
                page.Update();
            string[][] Vegan = {
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Zalmfilet","Norivel(zeewier)"}, 
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Tonijnfilet","Norivel(zeewier)"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Zalmfilet"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Tonijnfilet"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Ebi tempura","Norivel(zeewier)", "Avocado", "Komkommer", "Tobiko","Gebakken ui", "Mayonaise", "Wasabi"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Zalmfilet","Norivel(zeewier)", "Avocado", "Komkommer", "Tobiko", "Mayonaise", "Wasabi"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Tonijnfilet","Norivel(zeewier)", "Avocado", "Bosui", "Sesamzaad", "Mayonaise", "Sriracha"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Ebi tempura","Norivel(zeewier)", "Sesamzaad","Gebakken ui", "Mayonaise", "Wasabi"},
                new string[] {"Zalmfilet", "Sesamzaad", "Bosui"},
                new string[] {"Tonijnfilet", "Sesamzaad", "Bosui"}
                };
                Console.WriteLine("");
                for (int j = 0; j < Vegan[0].Length; j++){
                    Console.WriteLine($"- {Vegan[0][j]}");
                }
                var menu = new UISystem.Menu()
                .Add("Terug naar vegetarische gerechten", vegan);

            menu.Display();
            }

        public static UISystem.Page page = new UISystem.Page("Menu pagina");
        public static void Display(){
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Menulijst", lijst)
                .Add("Terug naar start", StartPage.Display);

            menu.Display();
        }

        private static void GoToDash() {
            Dashboard.Display();
        }
        private static void lijst() {
            MenuList.page.Update();

            var menu = new UISystem.Menu()
                .Add("Visgerechten", fish)
                .Add("Vleesgerechten", flesh)
                .Add("Vegetarische gerechten", vegan)
                .Add("Alle gerechten", all);
            menu.Display();

        }
        public static void fish() {
            page.Update();
            var menu = new UISystem.Menu()
                .Add("Maki zalm", showInfoFish)
                .Add("Maki tonijn", showInfoFish)
                .Add("Nigiri zalm", showInfoFish)
                .Add("Nigiri tonijn", showInfoFish)
                .Add("California roll", showInfoFish)
                .Add("Crunchy california roll", showInfoFish)
                .Add("Spicy tonijn roll", showInfoFish)
                .Add("Ebi tempura roll", showInfoFish)
                .Add("Zalm sashimi", showInfoFish)
                .Add("Tonijn sashimi", showInfoFish)
                .Add("Terug naar gerechten", lijst);

            menu.Display();
        }
        public static void flesh() {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Maki zalm", showInfoFlesh)
                .Add("Maki tonijn", showInfoFlesh)
                .Add("Nigiri zalm", showInfoFlesh)
                .Add("Nigiri tonijn", showInfoFlesh)
                .Add("California roll", showInfoFlesh)
                .Add("Crunchy california roll", showInfoFlesh)
                .Add("Spicy tonijn roll", showInfoFlesh)
                .Add("Ebi tempura roll", showInfoFlesh)
                .Add("Zalm sashimi", showInfoFlesh)
                .Add("Tonijn sashimi", showInfoFlesh)
                .Add("Terug naar gerechten", lijst);

            menu.Display();
        }
        public static void vegan() {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Maki zalm", showInfoVegan)
                .Add("Maki tonijn", showInfoVegan)
                .Add("Nigiri zalm", showInfoVegan)
                .Add("Nigiri tonijn", showInfoVegan)
                .Add("California roll", showInfoVegan)
                .Add("Crunchy california roll", showInfoVegan)
                .Add("Spicy tonijn roll", showInfoVegan)
                .Add("Ebi tempura roll", showInfoVegan)
                .Add("Zalm sashimi", showInfoVegan)
                .Add("Tonijn sashimi", showInfoVegan)
                .Add("Terug naar gerechten", lijst);

            menu.Display();
    
        }       

        public static void all() {
            Dashboard.Display();
        } 
    }
}