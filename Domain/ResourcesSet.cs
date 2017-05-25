using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class ResourcesSet
    {
        private List<Resource> resources;
        Resource Resolve(ResourceType type)
        {
            return resources[(int)type];
        }
    }
}
