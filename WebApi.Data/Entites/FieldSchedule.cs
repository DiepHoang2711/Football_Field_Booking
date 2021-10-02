using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Data.Entites
{
    public class FieldSchedule
    {
        public int FieldScheduleID { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public bool Status { get; set; }
        public int FieldForeignKey { get; set; }
        public Field Field { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
