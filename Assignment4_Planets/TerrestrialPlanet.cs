using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name:Nirojan Kalaimannan
 * Date: July 26, 2017
 * Description: This is the TerristrialPlanet class
 * Version: 0.1 -Created the TerrestrialPlanet class
 */
namespace Assignment4
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        //PRIVATE INSTANCE VARIABLES
        private bool _oxygen;
        private bool _hasMoons;
        private bool _habitable;

        public bool HasMoons
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
        public bool Habitable
        {
            get
            {
                return this._habitable;
            }
            set
            {
                this._habitable = value;
            }
        }

        //CONSTRUCTOR
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
        : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
        public bool Moons()
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
        public bool isHabitable()
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
    }
}