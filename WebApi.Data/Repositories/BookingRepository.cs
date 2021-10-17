using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.EF;
using WebApi.Data.Entites;

namespace WebApi.Data.Repositories
{
    public class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
        public BookingRepository(WebApiDbContext context) : base(context)
        {

        }
    }
}
