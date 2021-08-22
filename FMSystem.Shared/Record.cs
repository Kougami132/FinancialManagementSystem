using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FMSystem.Shared
{
    public class Record
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "必须选择收支")]
        public InputOrOutput Type { get; set; }

        public int Category { get; set; }

        public int Account { get; set; }

        [Required(ErrorMessage = "必须输入金额")]
        [CheckValue]
        public double Value { get; set; }

        public DateTime CreateTime { get; set; }

        public string Description { get; set; }
        
        public int User { get; set; }
    }

    public class CheckValueAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Convert.ToDouble(value) <= 0)
            {
                return new ValidationResult("请输入大于 0 的金额", new[] { validationContext.MemberName });
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
