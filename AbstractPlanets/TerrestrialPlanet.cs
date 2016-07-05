using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractPlanets
{
    public class TerrestrialPlanet : Planet, iHasMoons, iHabitable
    {
        private bool _oxygen;

        public TerrestrialPlanet(bool oxygen, string name, double diameter, double mass)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

         bool iHabitable.Habitable()
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