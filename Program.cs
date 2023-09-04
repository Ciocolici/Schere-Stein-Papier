namespace Schere_Stein_Papier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programmiere ein Schere, Stein, Papier Spiel. 
            //Der User soll eines der Handzeichen wählen können.
            //Der Computer wählt per Zufall ein eigenes Zeichen.
            //(Recherchieren Sie hierzu Random für C#)
            //Dem User wird dann ausgegeben, welches Zeichen der Computer gewählt hat und ob man gewonnen, verloren oder ein Unentschieden hat.
            //Danach kann sich der User entscheiden eine weitere Runde zu spielen, oder nicht.

            Console.WriteLine("Hallöchen, Player!\nDruck Enter um das Spiel zu starten.");
            Console.ReadLine();

            bool gameOff = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Wähl mal eins aus, und schauen wir wer der bessere Gamer ist.\nSchere, Stein oder Papier?");
                string playerAuswahl = Console.ReadLine().ToLower();

                Random rando = new Random();
                List<string> auswahlListe = new List<string> { "STEIN", "SCHERE", "PAPIER" };
                int i = rando.Next(auswahlListe.Count);
                string pcAuswahl = auswahlListe[i];
                Console.WriteLine($"1, 2, 3.. uuundd.. {pcAuswahl}, I choose you! <3");

                if ((playerAuswahl == "schere" && pcAuswahl == "STEIN") || (playerAuswahl == "papier" && pcAuswahl == "SCHERE") || (playerAuswahl == "stein" && pcAuswahl == "PAPIER"))
                {
                    Console.WriteLine("Ich habe gewonnen.. offensichtlich! 0wn3d, n000b!! ;)");
                }
                else if ((playerAuswahl == "schere" && pcAuswahl == "SCHERE") || (playerAuswahl == "papier" && pcAuswahl == "PAPIER") || (playerAuswahl == "stein" && pcAuswahl == "STEIN"))
                {
                    Console.WriteLine("Es ist unentschieden.. Ich wärme mich noch auf. :)");
                }
                else if ((playerAuswahl == "schere" && pcAuswahl == "PAPIER") || (playerAuswahl == "papier" && pcAuswahl == "STEIN") || (playerAuswahl == "stein" && pcAuswahl == "SCHERE"))
                {
                    Console.WriteLine("Du.. hast gewonnen.. Bah. Weil ich es dir erlaubt habe, natürlich...");
                }
                else
                {
                    Console.WriteLine($"Schwer auszuwählen, deswegen wählst du {playerAuswahl} aus?\nHast Angst gegen mir... ich kann mir vorstellen. ^^,");
                }

                Console.WriteLine($"Hast du den Mut für noch eins?\nJa/Nein");
                string nochmal = Console.ReadLine().ToLower();

                switch (nochmal)
                {
                    case "ja":
                        Console.WriteLine("Ich zeig es dir gleich, was ich kann. ;)");
                        Console.ReadLine();
                        break;
                    case "nein":
                        gameOff = true;
                        Console.WriteLine("Verängstigte Katze.. -.-");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Kannst du nicht mal ja oder nein schreiben? :o\nDann, als Strafe, spielst du noch eins egal ob du willst oder nicht. ;)");
                        Console.ReadLine();
                        break;
                }
            } while (gameOff == false);
        }
    }
}