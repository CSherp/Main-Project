using System;

namespace SushiLushi {
    class Reglement{
        public static UISystem.Page page = new UISystem.Page("Reglement pagina");
        
        public static void Display(){
            Console.Clear();
            page.Update();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("   Hoera we mogen weer open! Als een stel jonge koeien die weer de wei in mogen na    ");
            Console.WriteLine("   een hele winter op stal te hebben gestaan, staan wij te trappelen om u weer als    ");
            Console.WriteLine("   onze gasten te mogen begroeten! Vanaf 1 juni bent u weer van harte welkom.         ");
            Console.WriteLine("");
            Console.WriteLine("   Er zijn wel wat regeltjes waar wij en u zich aan moeten houden:                    ");
            Console.WriteLine("     - Van te voren reserveren                                                        ");
            Console.WriteLine("     - Niet meer dan 2 personen per tafelt, tenzij allen tot hetzelfde                ");
            Console.WriteLine("       huishouden behoren                                                             ");
            Console.WriteLine("");
            Console.WriteLine("   Indien er veel reserveringen binnen komen (met name op zaterdagen), zullen we      ");
            Console.WriteLine("   proberen om in twee sessies te werken:                                             ");
            Console.WriteLine("     - Sessie 1: 13:00 - 16:00                                                        ");
            Console.WriteLine("     - Sessie 2: 17:00 - 20:00                                                        ");
            Console.WriteLine("");
            Console.WriteLine("   Bij aankomst volgt een kort intake gesprek waar u wordt gevraagd of u              ");
            Console.WriteLine("   ziekteverschijnselen heeft die mogelijk op een coronabesmetting kunnen duiden.     ");
            Console.WriteLine("");
            Console.WriteLine("   Er zijn 3 desinfectiepunten, 1 bij de ingang waar u bij aankomst uw handen         ");
            Console.WriteLine("   contactloos kunt ontsmetten, 1 in elk toilet en 1 bij de bar. Verder wordt er      ");
            Console.WriteLine("   steeds 1 tafelt vrij gelaten tussen de bezette tafels om de vereiste 1,5 meter     ");
            Console.WriteLine("   afstand te garanderen. Indien u gebruik wilt maken van het toilet, dient u eerst   ");
            Console.WriteLine("   uw handen contactloos te ontsmetten en na gebruik dient u nogmaals de handen te    ");
            Console.WriteLine("   ontsmetten. Er mag slechts 1 persoon tegelijk naar het toilet.                     ");
            Console.WriteLine("");
            Console.WriteLine("   Zo, dat zijn een hele hoop regels, en we rekenen op uw eigen verantwoordelijkheid  ");
            Console.WriteLine("   om deze regels zo goed mogelijk op te volgen zodat de horeca lang open kan blijven.");
            Console.WriteLine("");
            Console.WriteLine("                             We hopen u weer snel te zien!                            ");
            Console.WriteLine("");
            Console.ResetColor();

            UISystem.Input.ReadString("\n(Druk op enter om verder te gaan)");
            StartPage.Display();
        }
        
    }
}
