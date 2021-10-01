using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.Data.EF;
using WebApi.Data.Entites;

namespace WebApi.Data.Repositories
{
    public class GroupFieldRepository : GenericRepository<GroupField>, IGroupFieldRepository
    {
        public GroupFieldRepository(WebApiDbContext context) : base(context)
        {

        }
        public Task<IEnumerable<GroupField>> GetTopRate()
        {
            throw new NotImplementedException();
        }
    }
}
