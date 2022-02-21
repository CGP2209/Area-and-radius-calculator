using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areal_beregner
{
    class Program
    {
        static void Main(string[] args)
        {

            string tastetryk = "";
            string svar = " ";
            do
            {
                Console.WriteLine("Areal beregner 1.0");
                Console.WriteLine("Vælg mellem: ");
                Console.WriteLine("\n[1] Beregn Firkant");
                Console.WriteLine("\n[2] Beregn Cirkel");
                Console.WriteLine("\n[3] Beregn Trekant");
                tastetryk = Convert.ToString(Console.ReadKey().KeyChar);
                Console.Clear(); Console.Beep(800, 100);

                switch (tastetryk)

                {
                    case "1":

                        Console.Clear(); Console.WriteLine("\bDu valgte : FIRKANT");
                        Console.Write("\nIndtast højde : ");

                        double højde = Convert.ToDouble(Console.ReadLine());
                        
                        Console.Write("\nIndtast bredde : ");

                        double bredde = Convert.ToDouble(Console.ReadLine());

                        double areal = (højde * bredde);
                        Console.WriteLine("\nDit areal er:" + areal);
                        break;

                    case "2":

                        Console.Clear(); Console.WriteLine("\bDu valgte : CIRKEL");
                        Console.WriteLine("\nIndtast radius:");

                        double radius = Convert.ToDouble(Console.ReadLine());
                        
                                    
                        areal = (3.14 * radius * radius);
                        Console.WriteLine("\nDit areal er:" + areal);
                        break;

                                                                                            // EVENTUELT FÅ CIRKEL TIL AT REGNE 
                                                                                            //DIAMETER, OMKREDS OG RADIUS

                    case "3":

                        Console.Clear(); Console.WriteLine("\bDu valgte : TREKANT");
                        Console.WriteLine("\nIndtast højde");
                        højde = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nIndtast grundlinjens længde");
                        Double længde = Convert.ToDouble(Console.ReadLine());
                        areal = 0.5 * højde * længde;
                        Console.WriteLine("\nDit areal er: " + areal);


                        break;

                    default:
                        Console.WriteLine(" FORKERT TAST !, vælg mellem [1], [2], eller [3]");
                        break;

                

                }

                if (svar != "nej")
                {
                    Console.WriteLine("Skal du udregne andet? \n[Ja] [Nej]");
                    svar = Console.ReadLine().ToLower();


                }
            } while (svar != "nej");
                    

            Console.WriteLine("\bDu trykkede på: {0}", tastetryk);
            Console.ReadLine();




        }
    }
}
