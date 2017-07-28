using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name:Nirojan Kalaimannan
  * Student Number:300606595
 * Date: July 27, 2017
 * Description: This is the TerristrialPlanet class
 * Version: 0.3 - Added ToString method 
 */
namespace Assignment4
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        //PRIVATE INSTANCE VARIABLES
        private bool _oxygen;
      
        //CONSTRUCTOR
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
        : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
        //method implementations
        public bool HasMoons()
        {
            if (MoonCount < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool Habitable()
        {
            if(_oxygen==false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// The driver class will this method when it is placed in the Console.Writeline method, returning a string that displays 
        /// in the prompt when ran.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string stats = "";
            stats += "====================\n";
            stats += "Planet name: " + this.Name;
            stats += "\n";
            stats += "Diameter: " + this.Diameter;
            stats += "\n";
            stats += "Mass: " + this.Mass;
            stats += "\n";
            stats += "Oxygen: " + this._oxygen;
            stats += "\n";
            stats += "====================\n";
            return stats;
        }
    }
}