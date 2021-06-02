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
            Console.WriteLine(" een hele winter op stal te hebben gestaan, staan wij te trappelen om u weer als onze ");
            Console.WriteLine("         gasten te mogen begroeten! Vanaf 1 juni bent u weer van harte welkom.        ");
            Console.WriteLine("");
            Console.WriteLine("     Er zijn wel wat regeltjes waar wij en u zich aan moeten houden: Van te voren     ");
            Console.WriteLine("     reserveren, niet meer dan 2 personen per tafeltje, tenzij allen tot dezelfde     ");
            Console.WriteLine("      huishouding behoren. Indien er veel reserveringen binnen komen (met name op     ");
            Console.WriteLine(" zaterdag), zullen we proberen met twee sessies te werken, de eerste is van 17:00 tot ");
            Console.WriteLine("");
            Console.WriteLine("        Bij aankomst volgt een kort intake gesprek waar u wordt gevraagd of u         ");
            Console.WriteLine("                ziekteverschijnselen heeft die op Corona kunnen duiden.               ");
            Console.WriteLine("");
            Console.WriteLine("Er zijn 3 desinfectiepunten, 1 bij de ingang waar u bij aankomst uw handen contactloos");
            Console.WriteLine("  kunt ontsmetten, 1 in elk toilet en 1 bij de bar. Verder wordt er steeds 1 tafeltje ");
            Console.WriteLine(" vrij gelaten tussen de bezette tafels om de vereiste 1,5 meter afstand te garanderen.");
            Console.WriteLine("   Indien u gebruik wilt maken van het toilet, dient u eerst uw handen contactloos te ");
            Console.WriteLine("  ontsmetten en na gebruik weer. Er mag slechts 1 persoon tegelijk naar het toilet.   ");
            Console.WriteLine("");
            Console.WriteLine("  Zo, dat zijn een hele hoop regels, en we rekenen op uw eigen verantwoordelijkheids  ");
            Console.WriteLine("                 gevoel om deze regels zo goed mogelijk op te volgen.                 ");
            Console.WriteLine("");
            Console.WriteLine("                         We hopen u weer snel te kunnen zien!                         ");
            Console.WriteLine("");
            Console.ResetColor();

            UISystem.Input.ReadString("\n(Druk op enter om verder te gaan)");
            StartPage.Display();
        }
        
    }
}
