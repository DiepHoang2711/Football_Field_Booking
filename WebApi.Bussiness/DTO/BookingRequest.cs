using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Bussiness.DTO
{
    public class BookingRequest
    {
        public int Discount { get; set; }
        public List<CartItemViewModel> ListCart { get; set; }
    }
}
