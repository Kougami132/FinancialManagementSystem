using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace FMSystem.Shared
{
    public enum Permissions
    {
        ADMIN,
        NORMAL
    }
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "必须输入用户名")]
        [CheckUserName]
        public string UserName { get; set; }
        [Required(ErrorMessage = "必须输入密码")]
        [MinLength(6, ErrorMessage = "密码至少 6 位")]
        public string UserPwd { get; set; }
        [Required(ErrorMessage = "必须选择权限组")]
        public Permissions Permission { get; set; }
        [CheckQQ]
        public string QQ { get; set; }
        [CheckEmail]
        public string Email { get; set; }
    }

    public class CheckUserNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && !IsUserName(value.ToString()))
            {
                return new ValidationResult("请输入 3 - 16 位由字母、数字或_组成的用户名", new[] { validationContext.MemberName });
            }
            else
            {
                return ValidationResult.Success;
            }
        }
        public bool IsUserName(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;
            const string pattern = "^[a-zA-Z0-9_]{3,16}$";
            Regex rx = new Regex(pattern);
            return rx.IsMatch(s);
        }
    }

    public class CheckQQAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && !IsNumber(value.ToString()))
            {
                return new ValidationResult("请输入合法的 QQ 号", new[] { validationContext.MemberName });
            }
            else
            {
                return ValidationResult.Success;
            }
        }

        /// <summary>
        /// 判断字符串是否是数字
        /// </summary>
        public static bool IsNumber(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;
            const string pattern = "^[0-9]*$";
            Regex rx = new Regex(pattern);
            return rx.IsMatch(s);
        }
    }

    public class CheckEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && !IsEmail(value.ToString()))
            {
                return new ValidationResult("请输入合法的邮箱", new[] { validationContext.MemberName });
            }
            else
            {
                return ValidationResult.Success;
            }
        }

        public static bool IsEmail(string source)
        {
            return Regex.IsMatch(source, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", RegexOptions.IgnoreCase);
        }
    }
}
