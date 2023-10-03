using blogpessoal.Model;
using blogpessoal.Service;
using blogpessoal.Service.Implements;
using blogpessoal.Validator;
using FluentValidation;
<<<<<<< HEAD
using Microsoft.AspNetCore.Authorization;
=======
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
using Microsoft.AspNetCore.Mvc;

namespace blogpessoal.Controllers
{
<<<<<<< HEAD
    [Authorize]
=======
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
    [Route("~/temas")]
    [ApiController]
    public class TemaController : ControllerBase
    {
<<<<<<< HEAD
=======

>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
        private readonly ITemaService _temaService;
        private readonly IValidator<Tema> _temaValidator;

        public TemaController(
<<<<<<< HEAD
           ITemaService temaService,
           IValidator<Tema> temaValidator)
=======
            ITemaService temaService,
            IValidator<Tema> temaValidator)
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
        {
            _temaService = temaService;
            _temaValidator = temaValidator;
        }
<<<<<<< HEAD

=======
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await _temaService.GetAll());
<<<<<<< HEAD
        }

        [HttpGet("{id}")] // <----- Isso serve para passar uma variável dentro da URL para o parâmetro
=======


        }
        [HttpGet("{id}")]
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
        public async Task<ActionResult> GetById(long id)
        {
            var Resposta = await _temaService.GetById(id);

            if (Resposta is null)
<<<<<<< HEAD
                return NotFound("Tema Não Encontrado");

=======
                return NotFound();
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
            return Ok(Resposta);
        }

        [HttpGet("descricao/{descricao}")]
<<<<<<< HEAD
        public async Task<ActionResult> GetByDescricao(string descricao)
        {
            return Ok(await _temaService.GetByDescricao(descricao));
        }

        [HttpPost]
        public async Task<ActionResult> Create(/* 
        Aqui ele pega o objeto para o teste já que não pode ser passado pelo caminho, que aceita apenas 
        um valor. Aqui ele é retornado como json */[FromBody] Tema tema)
        {
            var ValidarTema = await _temaValidator.ValidateAsync(tema);

            if (!ValidarTema.IsValid) // <-- A exclamação no começo da expressão indica negação
                return StatusCode(StatusCodes.Status400BadRequest, ValidarTema);

            var Resposta = await _temaService.Create(tema);

            return CreatedAtAction(nameof(GetById), new { id = Resposta!.Id }, Resposta);
=======
        public async Task<ActionResult> GetByTitulo(string descricao)
        {
            return Ok(await _temaService.GetByDescricao(descricao));


        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Tema tema)
        {
            var validartema = await _temaValidator.ValidateAsync(tema);

            if (!validartema.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, validartema);

            await _temaService.Create(tema);

            return CreatedAtAction(nameof(GetById), new { id = tema.Id }, tema);
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] Tema tema)
        {
            if (tema.Id == 0)
<<<<<<< HEAD
                return BadRequest("Id do tema é Invalido");

            var ValidarTema = await _temaValidator.ValidateAsync(tema);

            if (!ValidarTema.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ValidarTema);
=======
                return BadRequest("Id do Tema é invalido!!");
            var validartema = await _temaValidator.ValidateAsync(tema);


            if (!validartema.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, validartema);
            }
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5

            var Resposta = await _temaService.Update(tema);

            if (Resposta is null)
<<<<<<< HEAD
                return NotFound("Tema Não Encontrado!!");
=======
                return NotFound("Tema não encontrado !");
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5

            return Ok(Resposta);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var BuscaTema = await _temaService.GetById(id);

            if (BuscaTema is null)
<<<<<<< HEAD
                return NotFound("Tema não Encontrado.");
=======
                return NotFound("Tema não foi encontrado !");
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5

            await _temaService.Delete(BuscaTema);

            return NoContent();
<<<<<<< HEAD
=======

>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
        }
    }
}
