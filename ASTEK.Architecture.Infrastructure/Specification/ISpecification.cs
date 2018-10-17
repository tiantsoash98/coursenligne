using System;
using System.Linq.Expressions;

namespace ASTEK.Architecture.Infrastructure.Specification
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Predicate { get; }

        bool IsSatisfiedBy(T candidate);
    }
}