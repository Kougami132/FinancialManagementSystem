using System;
using System.Collections.Generic;
using System.Text;

namespace FMSystem.Shared
{
    public class LoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class UserDto
    {
        public string Name { get; set; }
        public string Token { get; set; }
    }
}
