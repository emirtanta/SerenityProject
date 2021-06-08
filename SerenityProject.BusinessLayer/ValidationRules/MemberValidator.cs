using FluentValidation;
using SerenityProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SerenityProject.BusinessLayer.ValidationRules
{
    public class MemberValidator:AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("The name field is mandatory");
            RuleFor(x => TurkishCharacterReplace(x.Surname)).Must(IsLetter).WithMessage("Only letters must be entered int the name field");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("The surname field is mandatory");
            RuleFor(x => TurkishCharacterReplace(x.Surname)).Must(IsLetter).WithMessage("Only letters must be entered int the surname field");

            RuleFor(x => x.Email).NotEmpty().WithMessage("The email field is mandatory");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Enter your e-mail address int he correct format");

            RuleFor(x => x.Password).NotEmpty().WithMessage("The password field is mandatory").Must(IsPasswordValid).WithMessage("Your password must contain at least 8 characters,at least 1 letters and a number!"); ;

            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Name field cannot be less than 3 characters");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Name field cannot be more than 50 characters");

            RuleFor(x => x.Surname).MinimumLength(3).WithMessage("Surname field cannot be less than 3 characters");
            RuleFor(x => x.Surname).MaximumLength(50).WithMessage("Surname field cannot be more than 50 characters");

            

            RuleFor(x => x.PhoneNumber).Must(IsPhoneNumber).WithMessage("The phone number format was entered incorrectly");
        }

        private bool IsLetter(string arg)
        {
            Regex regex= new Regex(@"^[a-zA-Z]+$");

            return regex.IsMatch(arg);
        }

        private bool IsPhoneNumber(string arg)
        {
            Regex regex= new Regex(@"^[0-9]{10}$");

            return regex.IsMatch(arg);
        }

        private bool IsPasswordValid(string arg)
        {
            Regex regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
            return regex.IsMatch(arg);
        }

        private string TurkishCharacterReplace(string text)
        {
            text = text.Replace("ı", "i");
            text = text.Replace("ö", "o");
            text = text.Replace("ü", "u");
            text = text.Replace("ğ", "g");
            text = text.Replace("ç", "c");
            text = text.Replace("ş", "s");
            text = text.Replace("Ü", "U");
            text = text.Replace("İ", "I");
            text = text.Replace("Ö", "O");
            text = text.Replace("Ğ", "G");
            text = text.Replace("Ç", "C");
            text = text.Replace("Ş", "S");
            text = text.Replace(" ", "");
            return text;
        }
    }
}
