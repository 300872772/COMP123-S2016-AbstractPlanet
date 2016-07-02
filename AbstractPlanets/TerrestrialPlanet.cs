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

        }

        public bool Habitable()
        {
            throw new System.NotImplementedException();
        }

        public void HasMoons()
        {
            throw new System.NotImplementedException();
        }
    }
}