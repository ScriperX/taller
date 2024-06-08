using System;
using System.ComponentModel.DataAnnotations;

namespace ReservationSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string CustomerPhone { get; set; }

        [Required]
        [Display(Name = "Reservation Date")]
        [DataType(DataType.Date)]
        public DateTime ReservationDate { get; set; }

        [Required]
        [Display(Name = "Reservation Time")]
        [DataType(DataType.Time)]
        public DateTime ReservationTime { get; set; }

        [Required]
        [Display(Name = "Service")]
        public string Service { get; set; }
    }
}

