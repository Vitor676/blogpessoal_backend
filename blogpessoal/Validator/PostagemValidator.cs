using blogpessoal.Model;
using FluentValidation;

namespace blogpessoal.Validator
{
    public class PostagemValidator : AbstractValidator<Postagem>
    {
        public PostagemValidator() 
        {
            RuleFor(p => p.Titulo)
<<<<<<< HEAD
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(100);

            RuleFor(t => t.Texto)
                .NotEmpty()
                .MinimumLength(10)
                .MaximumLength(8000);
=======
                    .NotEmpty()
                    .MaximumLength(100)
                    .MinimumLength(5);

            RuleFor(p => p.Titulo)
                    .NotEmpty()
                    .MaximumLength(1000)
                    .MinimumLength(10);


>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
        }

    }
}
