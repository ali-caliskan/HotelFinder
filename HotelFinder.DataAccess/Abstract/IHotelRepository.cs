using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Abstract
{
	public  interface IHotelRepository
	{
		//Liste Türünden Hotelleri döndürücek.(Parametre Almıyacak)
		List<Hotel> GetAllHotels();

		//Hotel döndürücek.
		Hotel GetHotelById(int id);

		//Ekleme methodu.(Eklediğimiz hoteli geriye döndürücek.)
		Hotel CreateHotel(Hotel hotel);

		//update methodu.(Eklediğimiz hoteli geriye döndürücek)
		Hotel UpdateHotel(Hotel hotel);

		void DeleteHotel(int id);
	}
}
