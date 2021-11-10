using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Bussiness.DTO
{
    public class BookingDetailRequest
    {
        public int BookingId { get; set; }
        public ICollection<CartItemViewModel> ListCart { get; set; }
    }
}
