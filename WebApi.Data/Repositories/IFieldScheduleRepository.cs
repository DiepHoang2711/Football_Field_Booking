using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.Data.Entites;

namespace WebApi.Data.Repositories
{
    public interface IFieldScheduleRepository : IGenericRepository<FieldSchedule>
    {
        Task<List<int>> getScheduleAvailable(int id);

        Task<List<int>> getSchedule(int id);
    }

}
