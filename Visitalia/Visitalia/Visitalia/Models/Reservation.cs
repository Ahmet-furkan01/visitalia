using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Visitalia.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        public string UserId { get; set; }
        public int TourId { get; set; }
        public int NumberOfReservation { get; set; }
        public DateTime ReservationDate { get; set; } = DateTime.Now;
    }
}