using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain;

namespace CivSim
{
    class RelationshipManager
    {
        private List<Relationship> relationships = new List<Relationship>();

        public Relationship GetRelationship(SpeciesGroup target)
        {
            foreach(Relationship r in relationships)
            {
                if (r.Target.Equals(target))
                    return r;
            }
            return null;
        }
        public void AddRelationship(SpeciesGroup target)
        {
            relationships.Add(new Relationship(target));
        }
    }
}
