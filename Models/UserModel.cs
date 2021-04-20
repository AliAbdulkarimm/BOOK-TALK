using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTalk.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UserLoginSuccessModel
    {
        public string message { get; set; }
        public string token { get; set; }
    }
    public class UserLoginError
    {
        public string message { get; set; }
    }
}
