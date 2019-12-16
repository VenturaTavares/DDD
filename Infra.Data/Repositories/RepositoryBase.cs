﻿using Domain.Interfaces;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {

        protected ProjetoContext db = new ProjetoContext();

        public void Add(TEntity obj)
        {
            db.Set<TEntity>().Add(obj);
            db.SaveChanges();
        }


        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            db.Set<TEntity>().Remove(obj);
            db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            db.Entry<TEntity>(obj).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
