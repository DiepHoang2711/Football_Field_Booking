using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.EF;
using WebApi.Data.Entites;

namespace WebApi.Data.Repositories
{
    public class FieldScheduleRepository : GenericRepository<FieldSchedule>, IFieldScheduleRepository
    {
        public FieldScheduleRepository(WebApiDbContext context) : base(context)
        {

        }
    }
}
