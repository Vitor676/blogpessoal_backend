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
                    .MaximumLength(100)
                    .MinimumLength(5);

            RuleFor(p => p.Titulo)
                    .NotEmpty()
                    .MaximumLength(1000)
                    .MinimumLength(10);


        }

    }
}
