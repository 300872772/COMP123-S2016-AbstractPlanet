using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractPlanets
{
    public class GiantPlanet : Planet, iHasMoons, iHasRings
    {
        private string _type;



        public GiantPlanet(string type, string name, double diameter, double mass)
           : base(name, diameter, mass)
        {
            if (type == "Gas" || type == "Ice")
            {
                this._type ="This Planet is a " + type + " type planet";
            }
            else
            {
                this._type = "Wrong Type";
            }

            
        }

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

         bool iHasRings.HasRings()
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