using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Infrastructure.Specification;
using ASTEK.Architecture.Infrastructure.UnitOfWork;

namespace ASTEK.Architecture.Repository
{
    public abstract class EFRepository<T, TId> : IRepository<T, TId> where T : EntityBase<TId>, IAggregateRoot
    {
        private readonly IQueryable<T> _repositoryQuery;
        private readonly DbSet<T> _repositoryTable;
        protected IUnitOfWork UnitOfWork { get; set; }

        protected EFRepository(IUnitOfWork uow)
        {
            UnitOfWork = uow ?? throw new ArgumentNullException("uow");

            _repositoryTable = GetDbSet<T>();
            _repositoryQuery = _repositoryTable.AsQueryable();
            Context.Configuration.LazyLoadingEnabled = false;
            Context.Configuration.ProxyCreationEnabled = false;
        }

        protected DbSet<TEntity> GetDbSet<TEntity>() where TEntity : class
        {
            return Context.Set<TEntity>();
        }

        public IQueryable<T> RepositoryQuery
        {
            get { return _repositoryQuery; }
        }

        protected EFDbContext Context
        {
            get { return (EFDbContext) UnitOfWork; }
        }

        // Constructor method of the class

        public int Count()
        {
            return _repositoryTable.Count();
        }


        public int Count(ISpecification<T> specification)
        {
            return _repositoryQuery.Where(specification.Predicate).Count();
        }

        public void Add(T entity)
        {
            _repositoryTable.Add(entity);
            UnitOfWork.SaveChanges();
        }

        public void Remove(T entity)
        {
            _repositoryTable.Remove(entity);
            UnitOfWork.SaveChanges();
        }

        public void Save(T entity)
        {
            SetEntityState(entity, entity.Id.Equals(default(TId)) ? EntityState.Added : EntityState.Modified);
            UnitOfWork.SaveChanges();
        }

        public T FindBy(TId id)
        {
            return _repositoryTable.Find(id);
        }

        public IEnumerable<T> FindAll()
        {
            return _repositoryQuery.AsEnumerable();
        }

        public IEnumerable<T> FindAll(int index, int count)
        {
            return _repositoryQuery.OrderBy(u => u.Id).Skip(index*count).Take(count).AsEnumerable();
        }

        public IEnumerable<T> FindBy(ISpecification<T> specification)
        {
            return _repositoryQuery.Where(specification.Predicate);
        }

        public IEnumerable<T> FindBy(ISpecification<T> specification, int index, int count)
        {
            return _repositoryQuery.Where(specification.Predicate).Skip(index*count).Take(count).AsEnumerable();
        }

        public IEnumerable<T> OrderBy(ISpecification<T> specification)
        {
            return _repositoryQuery.OrderBy(specification.Predicate).AsEnumerable();
        }

        public IEnumerable<T> OrderByDescending(ISpecification<T> specification)
        {
            return _repositoryQuery.OrderByDescending(specification.Predicate).AsEnumerable();
        }

        protected void SetEntityState(object entity, EntityState entityState)
        {
            Context.Entry(entity).State = entityState;
        }

        /// <summary>
        ///     Récupération d'une table du context basé sur le type d'entité du modèle
        /// </summary>
        /// <typeparam name="TEntity">
        ///     TEntity: représente le type de l'entité du modèle
        /// </typeparam>
        /// <returns>
        ///     Retourne un DbSet de type relatif à l'entité du modèle
        /// </returns>
       
    }
}