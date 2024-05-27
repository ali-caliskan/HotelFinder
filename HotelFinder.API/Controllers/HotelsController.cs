using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelFinder.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class HotelsController : ControllerBase
	{
		private IHotelService _hotelservice;

		public HotelsController()
		{
			_hotelservice = new HotelManager();
		}

		[HttpGet]
		public List<Hotel> Get()
		{
			return _hotelservice.GetAllHotels();
		}

		[HttpGet("{id}")]
		public Hotel Get(int id)
		{
			return _hotelservice.GetHotelById(id);
		}

	}
}
