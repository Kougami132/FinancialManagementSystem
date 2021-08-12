using System;
using System.Collections.Generic;
using System.Text;

namespace FMSystem.Shared
{
    public enum InputOrOutput
    {
        INPUT, OUTPUT
    }
    public class Category
    {
        public int Id { get; set; }
        public InputOrOutput Type { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
    }
}
