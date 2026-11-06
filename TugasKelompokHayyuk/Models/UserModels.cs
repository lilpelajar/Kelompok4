using Org.BouncyCastle.Bcpg.Sig;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace TugasKelompokHayyuk.Models
{
    public  class UserModels
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string RoleUser { get; set;  }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } 
    }
}
