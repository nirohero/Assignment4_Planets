using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name:Nirojan Kalaimannan
 * Date: July 16, 2017
 * Description: This is the Planet class
 * Version: 0.1 -Created the Planet class
 */
namespace Assignment4
{
    /// <summary>
    /// This is the abstract Planet class
    /// </summary>
    public abstract class Planet
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
        public double Diameter
          {
             get
             {
                 return this._diameter;
             }
          }
        public double Mass
         {
             get
             {
                 return this._mass;
             }
         }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
           
        }
        public double OrbitalPeriod
         {
             get
             {
                 return this._orbitalPeriod;
             }
             set
             {
                this._orbitalPeriod = value;
             }
         }
        public int RingCount
         {
             get
             {
                 return this._ringCount;
             }
            set
             {
                this._ringCount = value;
             }
         }

        public double RotationPeriod
         {
             get
             {
                 return this._rotationPeriod;
             }
            set
            {
                this._rotationPeriod = value;
            }
         }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="diameter"></param>
    /// <param name="mass"></param>
    public Planet(string name, double diameter, double mass)
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
