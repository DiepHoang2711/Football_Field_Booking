using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.EF;
using WebApi.Data.Entites;

namespace WebApi.Data.Repositories
{
    public class GroupFieldRepository : GenericRepository<GroupField>, IGroupFieldRepository
    {
        public GroupFieldRepository(WebApiDbContext context) : base(context)
        { 

        }
    }
}
