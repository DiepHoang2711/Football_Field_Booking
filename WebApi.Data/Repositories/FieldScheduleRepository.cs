using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Data.EF;
using WebApi.Data.Entites;

namespace WebApi.Data.Repositories
{
    public class FieldScheduleRepository : GenericRepository<FieldSchedule>, IFieldScheduleRepository
    {

        public FieldScheduleRepository(WebApiDbContext context) : base(context)
        {

        }


        public async Task<List<int>> getSchedule(int id)
        {
            List<int> schedule = new List<int>();

            var result = _context.FieldSchedules
                .Where(x => x.FieldForeignKey == id)
                .FirstOrDefault();

            var start = result.TimeStart.Hour;
            var end = result.TimeEnd.Hour;

            long timeTable = end - start; 
            for (int i = start; i < end; i++)
            {
                schedule.Add(i);
            }
            return schedule;
        }

        public async Task<List<int>> getScheduleAvailable(int id)
        {
            List<int> schedule = new List<int>();

            //var demo = await _context.Fields
            //    .Include(field => field.FieldSchedules)
            //    .ThenInclude(fieldSchedule => fieldSchedule.Bookings.Where(x => x.FieldScheduleForeignKey == field.FieldId))
            //    .ThenInclude(booking => booking.BookingDetails.Where(x => x.BookingForeignKey == booking.BookingId))
            //    .ToListAsync();

            var result = _context.BookingDetails
                .Include(bd => bd.Booking)
                .ThenInclude(b => b.FieldSchedule.FieldForeignKey == id)
                .FirstOrDefault();

            var start = result.TimeStart.Hour;
            var end = result.TimeEnd.Hour;

            long timeTable = end - start; // = 17
            for (int i = start; i < end; i++)
            {
                schedule.Add(i);
            }
            return schedule;
        }
    }

}
