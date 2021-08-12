using System;
using System.Collections.Generic;
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
        public PaymentType Type { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
    }
}
