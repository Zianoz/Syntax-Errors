﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chas_Events.Models.ConnectionTable
{
    public class UserEventAttending
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }


        [ForeignKey("Event")]
        public int EventId { get; set; }
        public Event Event { get; set; }

    }
}
