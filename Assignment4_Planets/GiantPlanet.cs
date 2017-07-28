using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name:Nirojan Kalaimannan
 * Student Number:300606595
 * Date: July 27, 2017
 * Description: This is the Giant Planet class that extends the base planet class
 * Version: 0.6 -Added ToString method 
 */
namespace Assignment4
{ 
    public class GiantPlanet : Planet , IHasMoons , IHasRings
    {
        //PRIVATE INSTANCE VARIABLES
        private string _type;

        
        //PUBLIC PROPERTIES
        /*public bool HasMoons
        {
            get
            {
                return this._hasMoons;
            }
            set
            {
                this._hasMoons = value;
            }
        }
        */
        /*
        public bool HasRings
        {
            get
            {
                return this._hasRings;
            }
            set
            {
                this._hasRings = value;
            }
        }
        */
        
        /// <summary>
        /// This is the constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name,double diameter,double mass, string type)
        :base(name,diameter,mass)
        {
            this._type = type;
        }
        //PUBLIC METHODS
        /// <summary>
        /// These methods check if the giant planet has moons and rings, if they do it returns true.
        /// </summary>
        /// <returns></returns>
        public bool HasMoons()
        {
            if(MoonCount<0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public bool HasRings()
        {
            if (RingCount < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override string ToString()
        {
            string stats ="";
            stats+= "====================\n";
            stats+="Planet name: " +this.Name;
            stats+= "\n";
            stats+="Diameter: " + this.Diameter;
            stats+= "\n";
            stats+= "Mass: " +this.Mass;
            stats+= "\n";
            stats+= "Type: " + this._type;
            stats += "\n";
            stats+= "====================\n";
            return stats;
        }
        
    }
}