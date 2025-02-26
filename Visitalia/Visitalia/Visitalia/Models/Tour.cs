using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Visitalia.Models;

namespace Visitalia.Models
{
    public class Tour
    {
        public int ID { get; set; }
        public string Location { get; set; }

        [Range(0.0, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        public float Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quota must be non-negative.")]
        public int Quota { get; set; }
        public string Description { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Sold must be non-negative.")]
        public int Sold { get; set; } = 0;
        public bool Available { get { return Quota != Sold; } }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public int Duration { get; set; }
    }
}