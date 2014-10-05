using GenericResources.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Domain.Entities
{
    public class DocumentTemplate : IResource
    {
        public string Name { get; set; }

        public string Description { get; set; }
        
    }
}
