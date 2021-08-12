using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FMSystem.Shared
{
    public enum PaymentType
    {
        BANK, ONLINE, CASH, OTHER
    }
    public class Account
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "必须选择账户种类")]
        public PaymentType Type { get; set; }

        [Required(ErrorMessage = "必须输入账户名称")]
        [MaxLength(16, ErrorMessage ="账户名称不得超过 16 位")]
        public string Name { get; set; }

        [MaxLength(16, ErrorMessage = "说明不得超过 16 位")]
        public string Description { get; set; }

        public string User { get; set; }
    }
}
