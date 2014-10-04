using GenericResources.Data.DataStores;
using GenericResources.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Data.Factories
{
    public class DataStoreFactory
    {
        public IResourceDataStore CreateDataStore(Enums.ResourceType resourceType)
        {
            IResourceDataStore store;
            switch (resourceType)
            {
                case Enums.ResourceType.Concept:
                    store = new ConceptDataStore();
                    break;
                case Enums.ResourceType.DocumentTemplate:
                    store = new DocumentDataStore();
                    break;
                case Enums.ResourceType.LibraryItem:
                    store = new LibraryItemDataStore();
                    break;
                case Enums.ResourceType.Template:
                    store = new TemplateDataStore();
                    break;
                case Enums.ResourceType.Protocol:
                    store = new ProtocolDataStore();
                    break;
                default:
                    store = new ConceptDataStore();
                    break;
            }

            return store;
        }
    }
}
