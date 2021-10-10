using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.EF;
using WebApi.Data.Entites;

namespace WebApi.Data.Repositories
{
    public class FieldRepository : GenericRepository<Field>, IFieldRepository
    {
        public FieldRepository(WebApiDbContext context) : base(context)
        {

        }
    }
}
