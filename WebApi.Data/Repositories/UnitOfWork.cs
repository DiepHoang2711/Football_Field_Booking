﻿using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.EF;

namespace WebApi.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WebApiDbContext _context;
        public IGroupFieldRepository GroupField { get; }

        public UnitOfWork(WebApiDbContext context)
        {
            _context = context;
            GroupField = new GroupFieldRepository(context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
