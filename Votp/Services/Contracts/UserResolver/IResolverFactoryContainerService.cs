﻿namespace Votp.Services.Contracts.UserResolver
{
    public interface IResolverFactoryContainerService<T>
    {
        public void RegisterFactory(string uniqueName,IResolverFactory<T> f);
        public IResolverFactory<T> GetFactory(string name);
    }
}
