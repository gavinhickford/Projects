using GenericResources.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Common.Entities
{
    public class LibraryItem : IResource
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
