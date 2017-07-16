using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Planets
{
    class Planet
    {
        /// <summary>
        /// Private instance variables
        /// </summary>
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        /// <summary>
        /// Public Properties
        /// </summary>
        public double Diameter { get; }
        public double Mass { get; }
        public int MoonCount { get; }
        public double OrbitalPeriod { get; set; }
        public int RingCount { get; set; }
        public double RotationPeriod { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        public override string ToString()
        {
            return String.Format("name:{0}\n{1}\n{2}",_name,_diameter,_mass);
        }
    }
}
