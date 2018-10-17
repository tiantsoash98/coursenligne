using System.Collections.Generic;
using ASTEK.Architecture.Infrastructure.Specification;

namespace ASTEK.Architecture.Infrastructure.Domain
{
    public interface IReadOnlyRepository<T, Tid> where T : IAggregateRoot
    {
        IEnumerable<T> FindAll();
        IEnumerable<T> FindAll(int index, int count);
       
        T FindBy(Tid id);
        IEnumerable<T> FindBy(ISpecification<T> specification);
        IEnumerable<T> FindBy(ISpecification<T> specification, int index, int count);
    }
}