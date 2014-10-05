using GenericResources.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Common.Entities
{
    public class Concept : IResource
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
