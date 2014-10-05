using GenericResources.Common.Interfaces;
using GenericResources.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using GenericResources.Data.DataStores;

namespace GenericResources.Data.Factories
{
    public class DataStoreFactory
    {
        public IResourceDataStore CreateDataStore(ResourceType resourceType)
        {
            IResourceDataStore store;
            switch (resourceType)
            {
                case ResourceType.Concept:
                    store = new ConceptDataStore();
                    break;
                case ResourceType.DocumentTemplate:
                    store = new DocumentDataStore();
                    break;
                case ResourceType.LibraryItem:
                    store = new LibraryItemDataStore();
                    break;
                case ResourceType.Template:
                    store = new TemplateDataStore();
                    break;
                case ResourceType.Protocol:
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
