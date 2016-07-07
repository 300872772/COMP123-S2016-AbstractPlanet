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
     * This 'TerrestrialPlanet' class is inherited from Planet class and has been linked with 2 interface
     *  </summary>
     *  
     * @class TerrestrialPlanet
     * @field {bool} _oxygen
     *  
     */
    public class TerrestrialPlanet : Planet, iHasMoons, iHabitable
    {
        //PRIVATE INSTANCE VARIABLE+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private bool _oxygen;

        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the constructor that is based on "Planet" class and its constructor
        * </summary>
        *  
        * @constructor TerrestrialPlanet 
        * @param {bool} oxygen 
        * @param {string} name 
        * @param {double} diameter 
        * @param {double} mass 
        * 
        */
        public TerrestrialPlanet(bool oxygen, string name, double diameter, double mass)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        //PUBLIC METHOD+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This is the inharited method from interface iHabitable.
         * </summary>
         *  
         * @method Habitable 
         * @return {bool}   
         * 
         */
        public bool Habitable()
        {
            if (this._oxygen == true)
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
            * This is the inharited method from interface iHasMoons.
            * </summary>
            *  
            * @method HasMoons 
            * @return {bool}   
            * 
            */
        bool iHasMoons.HasMoons()
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
    }
}