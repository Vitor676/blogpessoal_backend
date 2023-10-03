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
<<<<<<< HEAD
                    .MinimumLength(2)
                    .MaximumLength(80);
=======
                    .MaximumLength(100)
                    .MinimumLength(5);


>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
        }
    }
}
