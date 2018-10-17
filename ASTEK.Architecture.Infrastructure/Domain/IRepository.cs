﻿using ASTEK.Architecture.Infrastructure.Specification;

namespace ASTEK.Architecture.Infrastructure.Domain
{
    public interface IRepository<T, TId> : IReadOnlyRepository<T, TId> where T : IAggregateRoot
    {
        void Save(T entity);
        void Add(T entity);
        void Remove(T entity);
        int Count();
        int Count(ISpecification<T> specification);
    }
}