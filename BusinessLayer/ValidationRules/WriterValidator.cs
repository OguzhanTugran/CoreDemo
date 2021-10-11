using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ValidationRules
{
   public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı Kısmı Boş Gecilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar Şifre Kısmı Boş Gecilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar Mail Kısmı Boş Gecilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lutfen en az 2 karakter giriniz.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Parola alanı boş geçilemez!");
            RuleFor(x=>x.WriterPassword).Must(IsPasswordValid).WithMessage("Parolanız en az altı karakter, en az bir harf ve bir sayı içermelidir!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lutfen en fazla 50 karakter bandında giriş yapınız.");
        }

        private bool IsPasswordValid(string arg)
        {
            Regex regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$");
            return regex.IsMatch(arg);
        }
    }
}
