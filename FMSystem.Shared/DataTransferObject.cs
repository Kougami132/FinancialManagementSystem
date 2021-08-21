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

    public class CircleDto
    {
        public string Type { get; set; }
        public double Value { get; set; }
        public CircleDto(string type, double value)
        {
            Type = type;
            Value = value;
        }
    }

    public class ColumnDto
    {
        public string time { get; set; }
        public double value { get; set; }
        public string type { get; set; }
    }

    public class LineDto
    {
        public string time { get; set; }
        public double rate { get; set; }
        public string name { get; set; }
    }
}
