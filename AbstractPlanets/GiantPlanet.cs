using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 *Author: Md Mamunur Rahman
 * Student ID: 300872772 
 *
 * Date: July 07, 2016
 * Description: This program demonstrates a game named 'Abstract Planet', 
 * 
 */
namespace AbstractPlanets
{
    /**
     * <summary>
     * This 'GiantPlanet' class is inherited from Planet class and has been linked with 2 interface
     *  </summary>
     *  
     * @class GiantPlanet
     * @field {string} _type
     *  
     */
    public class GiantPlanet : Planet, iHasMoons, iHasRings
    {
        //PRIVATE INSTANCE VARIABLE+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _type;



        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the constructor that is based on "Planet" class and its constructor
        * </summary>
        *  
        * @constructor GiantPlanet 
        * @param {string} type 
        * @param {string} name 
        * @param {double} diameter 
        * @param {double} mass 
        * 
        */
        public GiantPlanet(string type, string name, double diameter, double mass)
           : base(name, diameter, mass)
        {
            this._type = type;
        }

        //PUBLIC METHOD+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This is the inharited method from interface iHasmoon.
         * </summary>
         *  
         * @method HasMoons 
         * @return {bool}   
         * 
         */

        public bool HasMoons()
        {
            if (this.MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /**
         * <summary>
         * This is the inharited method from interface iHasRings.
         * </summary>
         *  
         * @method HasRings 
         * @return {bool}   
         * 
         */
        public bool HasRings()
        {
            if (this.RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}