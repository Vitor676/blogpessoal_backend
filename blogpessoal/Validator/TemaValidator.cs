using blogpessoal.Model;
using FluentValidation;

namespace blogpessoal.Validator
{
    public class TemaValidator : AbstractValidator<Tema>
    {
        public TemaValidator()
        {
            RuleFor(d => d.Descricao)
                    .NotEmpty()
                    .MaximumLength(100)
                    .MinimumLength(5);


        }
    }
}
