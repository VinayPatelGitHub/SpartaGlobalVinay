using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace GymTrackerWebsite.Models
{
    public class Session
    {
        public int SessionId { get; set; }
        public string SessionDate { get; set; } //to datetime
        public string NameOfExercise { get; set; }
        public string SessionLength { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}