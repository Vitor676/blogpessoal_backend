using blogpessoal.Model;
using FluentValidation;

namespace blogpessoal.Validator
{
    public class PostagemValidator : AbstractValidator<Postagem>
    {
        public PostagemValidator() 
        {
            RuleFor(p => p.Titulo)
                    .NotEmpty()
                    .MaximumLength(5)
                    .MinimumLength(100);

            RuleFor(p => p.Titulo)
                    .NotEmpty()
                    .MaximumLength(10)
                    .MinimumLength(1000);


        }

    }
}
