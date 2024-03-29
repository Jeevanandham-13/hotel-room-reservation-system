﻿using HotelRoomReservationSystem.Models;
using HotelRoomReservationSystem.Repositories.CustomerServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelRoomReservationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        private readonly ICustomer cus;
        public CustomersController(ICustomer cus)
        {
            this.cus = cus;
        }
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return cus.GetCustomer();
        }

        [HttpGet("{CustomerId}")]
        public Customer GetById(int CustomerId)
        {
            return cus.GetCustomerById(CustomerId);
        }

        [HttpPost]
        public Customer PostCustomer(Customer customer)
        {
            return cus.PostCustomer(customer);
        }
        [HttpPut("{CustomerId}")]
        public Customer PutCustomer(int CustomerId, Customer customer)
        {
            return cus.PutCustomer(CustomerId, customer);
        }
        [HttpDelete("{CustomerId}")]
        public Customer DeleteCustomer(int CustomerId)
        {
            return cus.DeleteCustomer(CustomerId);
        }
        [HttpGet("filter")]
        public IEnumerable<hotel> FilterHotels(string location)
        {
            return cus.FilterHotels(location);
        }


        [HttpGet("roomcount")]
        public int GetRoomCount(int RoomId, int HotelId)
        {
            return cus.GetRoomCount(RoomId, HotelId);


        }
        [HttpGet("price-range")]
        public IEnumerable<hotel> FilterPriceRange(decimal minPrice, decimal maxPrice)
        {
            return cus.FilterPriceRange(minPrice, maxPrice);
        }


    }
}
