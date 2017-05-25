using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivSim
{
    public class Relationship
    {
        private SpeciesGroup target;

        private int relationship = 50;

        private List<String> history;

        public Relationship(SpeciesGroup target)
        {
            this.target = target;
        }

        public SpeciesGroup Target
        {
            get
            {
                return this.target;
            }
        }

        public void SetRelationship(int desired)
        {
            this.relationship = desired;
        }

        public void AddHistory(String story)
        {
            this.history.Add(story);
        }

        public List<String> GetHistory()
        {
            return this.history;
        }
    }
}
