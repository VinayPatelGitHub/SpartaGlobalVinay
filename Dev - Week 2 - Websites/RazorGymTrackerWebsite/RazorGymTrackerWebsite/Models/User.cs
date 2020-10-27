using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymTrackerWebsite.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<Session> Sessions { get; } = new List<Session>();

        public override string ToString()
        {
            return $"{UserName}";
        }

    }
}