using System;
namespace GenericResources.Data.Factories
{
    public interface IDataStoreFactory
    {
        GenericResources.Common.Interfaces.IResourceDataStore CreateDataStore(GenericResources.Common.Enums.ResourceType resourceType);
    }
}
