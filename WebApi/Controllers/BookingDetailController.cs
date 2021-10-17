using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Bussiness.DTO;
using WebApi.Data.Entites;
using WebApi.Data.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BookingDetailController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BookingDetailController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // POST api/<BookingDetailController>
        //[Authorize(Roles = "USER")]
        [HttpPost]
        public async Task<IActionResult> AddBookingDetail(List<CartItemViewModel> listCart, int idBooking)
        {
            int status = 0;
            if(idBooking != 0)
            {
                foreach (CartItemViewModel item in listCart)
                {
                    var bd = new BookingDetail();
                    bd.TimeStart = item.TimeStart;
                    bd.TimeEnd = item.TimeEnd;
                    bd.Price = item.Price;
                    bd.Status = true;
                    bd.BookingForeignKey = idBooking;
                    bd.FieldScheduleForeignKey = item.fieldScheduleId;
                    bd.FieldForeignKey = item.FieldForeignKey;
                    await _unitOfWork.BookingDetail.Add(bd);
                    status = _unitOfWork.Complete();
                }
            }
            if (status > 0)
            {
                return Ok();
            }
            return BadRequest();
          
        }
    }
}
