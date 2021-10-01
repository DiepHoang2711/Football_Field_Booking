using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Data.Repositories
{
    public interface IUnitOfWork: IDisposable
    {
        IGroupFieldRepository GroupField { get; }
        int Complete();
    }
}
