using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name:Nirojan Kalaimannan
 * Date: July 27, 2017
 * Description: This is the driver class
 * Version: 0.2 - Instantiated objects from both the Giant planet class and Terrestrial Planet class
 */
 
namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created a giant planet objecet
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter",139822,317.8,"Gas");
            Console.WriteLine(giantPlanet.ToString());

            //Created  a terrestrial planet object
            TerrestrialPlanet terristrestrialPlanet = new TerrestrialPlanet("Earth",12742,1,true);
            Console.WriteLine(terristrestrialPlanet.ToString());
        }
    }
}
