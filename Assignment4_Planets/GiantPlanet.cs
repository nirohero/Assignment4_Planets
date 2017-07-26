﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name:Nirojan Kalaimannan
 * Date: July 25, 2017
 * Description: This is the Giant Planet class that extends the base planet class
 * Version: 0.2 -Added iHasMoons interface to this class
 */
namespace Assignment4
{ 
    public class GiantPlanet : Planet , IHasMoons
    {
        //PRIVATE INSTANCE VARIABLES
        private string _type;

        private bool _hasMoons;
        //PUBLIC PROPERTIES
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
    }
}