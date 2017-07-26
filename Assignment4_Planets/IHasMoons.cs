using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name:Nirojan Kalaimannan
 * Date: July 25, 2017
 * Description: This is an interface that defines a moon property
 * Version: 0.1 -Created the IHasMoons interace
 */
namespace Assignment4
{
    /// <summary>
    /// This is the IHasMoons interface
    /// </summary>
    public interface IHasMoons
    {
        //PRIVATE INSTANCE VARIABLES
        
        //PUBLIC PROPERTIES

        bool HasMoons { get; set; }
    }
}