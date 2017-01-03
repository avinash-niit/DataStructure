using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ResourceReader : IResourceReader
    {
        private ResourceManager resourceManager;

        public ResourceReader()
        {
            resourceManager = new ResourceManager(typeof(ResourceSet));
        }

        public string GetResourceValue(string key)
        {
            return resourceManager.GetString(key);
        }
    }
}
