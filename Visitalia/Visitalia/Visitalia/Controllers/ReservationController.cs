using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Visitalia.Data;
using Visitalia.Models;

namespace Visitalia.Controllers
{
    public class ReservationController : Controller
    {
        private VisitaliaContext db = new VisitaliaContext();

        [HttpPost]
        public ActionResult Create(int tourId, int reservationCount)
        {
            // Kullanıcının giriş yapıp yapmadığını kontrol et
            string userId = User.Identity.GetUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "Account");
            }

            // Rezervasyon kaydı oluştur
            var reservation = new Reservation
            {
                UserId = userId,
                TourId = tourId,
                NumberOfReservation = reservationCount,
                ReservationDate = DateTime.Now
            };

            // Rezervasyonu ekle
            db.Reservations.Add(reservation);

            // İlgili turun "Sold" değerini artır
            var tour = db.Tours.FirstOrDefault(t => t.ID == tourId);
            if (tour != null)
            {
                tour.Sold += reservationCount;
                db.SaveChanges(); // Değişiklikleri kaydet
            }

            return RedirectToAction("TourInfo", "Home", new { id = tourId });
        }
    }
}