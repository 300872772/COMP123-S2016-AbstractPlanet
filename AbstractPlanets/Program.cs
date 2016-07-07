using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*
 *Author: Md Mamunur Rahman
 * Student ID: 300872772 
 *
 * Date: July 07, 2016
 * Description: This program demonstrates a game named 'Abstract Planet', 
 * 
 * Version: 0.0.4 - added all comments and colose the project
 */
namespace AbstractPlanets
{
     /** 
      * This class is the "driver" class for our Program 
      *  
      * @class Program 
      */

    class Program
    {
         /** 
          * the main method for our driver class Program 
          *  
          * @method Main 
          * @param {sting[]} args 
          */


        static void Main(string[] args)
        {
            //Call Display Logo method
            DisplayLogo();


            Console.WriteLine(" GIANT PLANET");
            Console.WriteLine(" ------------");

            //create instance of the PlanetType Enum
            string planetType = Enum.GetName(typeof(PlanetType), PlanetType.Ice);

            //create instance of the GiantPlanet class
            GiantPlanet giantPlanet = new GiantPlanet(planetType, "Jupiter", 142984, 317.83);
            Console.WriteLine(giantPlanet.ToString());

            Console.WriteLine();


            Console.WriteLine(" TERRESTRIAL PLANET");
            Console.WriteLine(" ------------------");

            //create instance of the TerrestrialPlanet class
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet(false, "Mars", 1000, .11);
            Console.WriteLine(terrestrialPlanet.ToString());

            Console.ReadKey();

        }

        //PUBLIC METHOD+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This is the static void method to make decoration logo.
         * </summary>
         *  
         * @method DisplayLogo 
         * @return {void}   
         * 
         */

        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(400);
            Console.WriteLine("        ************");
            Thread.Sleep(400);
            Console.WriteLine("    ********************");
            Thread.Sleep(400);
            Console.WriteLine("  ************************");
            Thread.Sleep(400);
            Console.WriteLine(" ***************************");
            Thread.Sleep(400);
            Console.WriteLine("*****************************");
            Thread.Sleep(400);
            Console.Write("******");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("ABSTRACT PLANET");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("********\n");
            Thread.Sleep(400);
            Console.WriteLine("*****************************");
            Thread.Sleep(400);
            Console.WriteLine(" ***************************");
            Thread.Sleep(400);
            Console.WriteLine("  ************************");
            Thread.Sleep(400);
            Console.WriteLine("    ********************");
            Thread.Sleep(400);
            Console.WriteLine("        ************");
            Thread.Sleep(400);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
        }
    }
}
