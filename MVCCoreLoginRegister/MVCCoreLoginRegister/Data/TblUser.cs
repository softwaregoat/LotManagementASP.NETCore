using System;
using System.Collections.Generic;

namespace MVCCoreLoginRegister.Data
{
    public partial class TblUser
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Rfid { get; set; }
        public string Email { get; set; }
        public bool? Active { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public bool? Admin { get; set; }
    }
}
