using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "必须选择收支类型")]
        public InputOrOutput Type { get; set; }
        [Required(ErrorMessage = "必须输入收支名称")]
        [MaxLength(16, ErrorMessage = "收支名称不得超过 16 位")]
        public string Name { get; set; }
        [MaxLength(16, ErrorMessage = "说明不得超过 16 位")]
        public string Description { get; set; }
        public int User { get; set; }
    }
}
