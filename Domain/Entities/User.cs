using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
       
        [Key]
         public int UserId { get; set; }
        public string Name { get; set; } = String.Empty;  
         public string Email { get; set; }= String.Empty;
        public string Phone { get; set; }= String.Empty;
        public string Address { get; set; }= String.Empty;
        public string Password { get; set; }=String.Empty;
        public DateTime Created { get; set; }= DateTime.Now;

        public new string IsValid()
        {
            string arabicPattern = @"^[\p{Arabic}\s-]{1,50}$";
            string patternphone = @"^(77|71|73)\d{7}$";
            string pattern = @"^[a-z0-9._%+-]+@[a-z]+\.[a-z]{2,}$";
            if (string.IsNullOrWhiteSpace(Name))
                return "يرجى ادخال الاسم ";
            if (!Regex.IsMatch(Name, arabicPattern))

                return " يرجى ادخال اسم صحيح ";

            if (string.IsNullOrEmpty(Email))
                return "يرجى ادخال الايميل ";

            if (!Regex.IsMatch(Email, pattern, RegexOptions.IgnoreCase))
                return "يرجى ادخال الايميل صحيح ";
            if (Phone == null)
                return "يرجى ادخال رقم الهاتف ";

            if (string.IsNullOrEmpty(Phone))
                return "يرجى ادخال رقم الهاتف ";

            if (!Regex.IsMatch(Phone, patternphone, RegexOptions.IgnoreCase))
                return " يرجى ادخال رقم الجوال صحيح يجب ان يبدأ 71,77,73";

           

            return base.ToString();
        }


    }
}
