using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Bussiness.DTO
{
    public class BookingRequest
    {
        public ICollection<CartItemViewModel> ListCart { get; set; }
    }
}
