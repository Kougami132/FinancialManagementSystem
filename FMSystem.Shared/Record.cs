using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FMSystem.Shared
{
    public class Record
    {
        public int Id { get; set; }

        public InputOrOutput Type { get; set; }

        public string? Category { get; set; }

        public string? Account { get; set; }

        [Required(ErrorMessage = "必须输入金额")]
        public double Value { get; set; }

        public DateTime CreateTime { get; set; }

        public string? Description { get; set; }
        
        public string User { get; set; }
    }
}
