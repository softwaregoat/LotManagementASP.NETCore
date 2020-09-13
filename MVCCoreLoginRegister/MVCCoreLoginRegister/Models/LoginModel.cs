using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreLoginRegister.Models
{
    public class LoginModel
    {
        
        [DataType(DataType.Password)]
        public string Rfid { get; set; }
        
        [DataType(DataType.Text)]
        public string Username { get; set; }
        
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
