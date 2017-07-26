using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name:Nirojan Kalaimannan
 * Date: July 25, 2017
 * Description: This is the Giant Planet class that extends the base planet class
 * Version: 0.1 -Created the Giant Planet class
 */
namespace Assignment4
{ 
    public class GiantPlanet : Planet
    {
        //PRIVATE INSTANCE VARIABLES
        private string _type;
        
        /// <summary>
        /// 
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