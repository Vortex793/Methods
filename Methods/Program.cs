using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        //CURTIS APFELBECK
        public static void DrawGuitar()
        {
            Console.WriteLine("");
            Console.WriteLine("                  _,.,");
            Console.WriteLine("               ,'   ,'");
            Console.WriteLine("               /   ,'");
            Console.WriteLine("              /   , ");
            Console.WriteLine("             /   ,");
            Console.WriteLine("            /   '");
            Console.WriteLine("           /   ,'");
            Console.WriteLine("           '.__|");
            Console.WriteLine("            |  |");
            Console.WriteLine("            |__|");
            Console.WriteLine("            |  |");
            Console.WriteLine("            |__|");
            Console.WriteLine("            |  |");
            Console.WriteLine("            |__|");
            Console.WriteLine("            |  |");
            Console.WriteLine("            |__|");
            Console.WriteLine("            |, |");
            Console.WriteLine("            |--|");
            Console.WriteLine("            |__|");
            Console.WriteLine("            |  |");
            Console.WriteLine("            |--|");
            Console.WriteLine("            |__|");
            Console.WriteLine("            |__|        ,-.");
            Console.WriteLine("            |__|'     ,'  /");
            Console.WriteLine("       _,.-'     ',_,' o /");
            Console.WriteLine("      /     8888        /");
            Console.WriteLine("      |                /");
            Console.WriteLine("       1              /");
            Console.WriteLine("       `L   8888     /");
            Console.WriteLine("        |           /");
            Console.WriteLine("       /    ====    \\");
            Console.WriteLine("      /     ____     \\");
            Console.WriteLine("     /     (____)  o  \\");
            Console.WriteLine("    /             o    \\");
            Console.WriteLine("   /             o     ,'");
            Console.WriteLine("  /               _,.'^");
            Console.WriteLine(" /        __,.-\"~^");
            Console.WriteLine("',,..--~~^");
            Console.WriteLine("");
        }

        public static void DrawFace()
        {
            Console.WriteLine("____||____");
            Console.WriteLine(" ///////////\\");
            Console.WriteLine("///////////  \\");
            Console.WriteLine("|    _    |  |");
            Console.WriteLine("|[] | | []|[]|");
            Console.WriteLine("|   | |   |  |");




        }

       public static void DrawYellowSubmarine()
        {
            Console.WriteLine("_.._");
            Console.WriteLine("                                         (    )");
            Console.WriteLine("                                     .--.\\   /");
            Console.WriteLine("                                     ( )) \\_.-,");
            Console.WriteLine("                                     _`\\  ( (( )");
            Console.WriteLine("                                    ( ``|  |  |");
            Console.WriteLine("                                     `|_|__|__|");
            Console.WriteLine("                                     /_ __ _ __|");
            Console.WriteLine("                                   .-L_7__7_7_7|");
            Console.WriteLine("_______                           (   ,----,  (`.");
            Console.WriteLine("\\\"\"\"\"\"\";`.                         |  .\\ \\ / /.|  \\");
            Console.WriteLine("/    [|  \\                        |  :-.-\"-,-:|   `-------.");
            Console.WriteLine("\\    [|   `-.___________________.-'  |_:_Q_:_|`-._______)  `----------.._");
            Console.WriteLine("/    [|         (       /   |        \"\"\"\"\"\"\"\"\" .------------------' (__) `.");
            Console.WriteLine("\\    [|          `-----'    |                 /  .--.  .--. .--.  .--.    ;");
            Console.WriteLine("/_____;                     7----------------'  :    ;:    ;;   ;:    :  /");
            Console.WriteLine("\"\"\"\"\"\"\"\"\"-.               .'   S$S S$S S$S S$S   `--'  `--' `--'  `--' .'");
            Console.WriteLine("          ,)              |                            |\"\"\"\"\"\"\"\"|     (");
            Console.WriteLine("          0-------....._  |             _________      |        |      )");
            Console.WriteLine("          '             `.|           .\"         \".    |        |    .'");
            Console.WriteLine("                          `-._        |           |    |________| .-'");
            Console.WriteLine("                              `-..____|___________|_________...--'   ");
        }
        
        public static void KnockKnock()
        {
            Console.WriteLine("Knock Knock");
            string who = Console.ReadLine().ToLower();
            if (who == "who's there" || who == "whos there")
            {
                Console.WriteLine("Yah");
                string yah = Console.ReadLine().ToLower();
                if (yah == "yah who?" || yah == "yah who" || yah == "yahoo" || yah == "yahwho")
                {
                    Console.WriteLine("No I use Google.");
                }
                else
                {
                    Console.WriteLine("You should say \"Yah who?\"");
                    return;
                }
            }
            else
            {
                Console.WriteLine("You should say \"Who's there?\"");
                return;
            }
            


        }
        static void Main(string[] args)
        {
            DrawGuitar();
            DrawFace();
            DrawYellowSubmarine();
            KnockKnock();
        }
    }
}
