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

        }

        public bool HasMoons()
        {
            throw new System.NotImplementedException();
        }

        public bool HasRings()
        {
            throw new System.NotImplementedException();
        }
    }
}