using Application.DTOs.Base;
using Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Application.DTOs.RequestDTO
{
    public class UserDTOs : UserDTO
    {
      
        public string UserName { get; set; } = String.Empty;
        public string UserEmail { get; set; } = String.Empty;

        public string Phone { get; set; }

        public string Address { get; set; } = String.Empty;

        public string Password { get; set; } = String.Empty;
        public new string IsValid()
        {
            string arabicPattern = @"^[\p{Arabic}\s-]{1,50}$";
            string patternphone = @"^(77|71|73)\d{7}$";
            string pattern = @"^[a-z0-9._%+-]+@[a-z]+\.[a-z]{2,}$";
            if (string.IsNullOrWhiteSpace(UserName))
                return "يرجى ادخال الاسم ";
            if (!Regex.IsMatch(UserName, arabicPattern))

                return " يرجى ادخال اسم صحيح ";


            if (string.IsNullOrEmpty(UserEmail))
                return "يرجى ادخال الايميل ";

            if (!Regex.IsMatch(UserEmail, pattern, RegexOptions.IgnoreCase))
                return "يرجى ادخال الايميل صحيح ";
            if (Phone == null)
                return "يرجى ادخال رقم الهاتف ";

            if (string.IsNullOrEmpty(Phone))
                return "يرجى ادخال رقم الهاتف ";

            if (!Regex.IsMatch(Phone, patternphone, RegexOptions.IgnoreCase))
                return "يرجى ادخال رقم الجوال صحيح ";

            return base.ToString();
        }


    }
}
