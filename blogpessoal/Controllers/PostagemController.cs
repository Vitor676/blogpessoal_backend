﻿using blogpessoal.Model;
using blogpessoal.Service;
using FluentValidation;
<<<<<<< HEAD
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
=======
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
using Microsoft.AspNetCore.Mvc;

namespace blogpessoal.Controllers
{
<<<<<<< HEAD
    [Authorize]
=======
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
    [Route("~/postagens")]
    [ApiController]
    public class PostagemController : ControllerBase
    {
<<<<<<< HEAD
=======


>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
        private readonly IPostagemService _postagemService;
        private readonly IValidator<Postagem> _postagemValidator;

        public PostagemController(
            IPostagemService postagemService,
            IValidator<Postagem> postagemValidator)
        {
            _postagemService = postagemService;
            _postagemValidator = postagemValidator;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await _postagemService.GetAll());
<<<<<<< HEAD
        }

        [HttpGet("{id}")] // <----- Isso serve para passar uma variável dentro da URL para o parâmetro
=======


        }

        [HttpGet("{id}")]
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
        public async Task<ActionResult> GetById(long id)
        {
            var Resposta = await _postagemService.GetById(id);

            if (Resposta is null)
                return NotFound();
<<<<<<< HEAD

=======
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
            return Ok(Resposta);
        }

        [HttpGet("titulo/{titulo}")]
        public async Task<ActionResult> GetByTitulo(string titulo)
        {
            return Ok(await _postagemService.GetByTitulo(titulo));
<<<<<<< HEAD
        }

        [HttpPost]
        public async Task<ActionResult> Create(/* 
        Aqui ele pega o objeto para o teste já que não pode ser passado pelo caminho, que aceita apenas 
        um valor. Aqui ele é retornado como json */[FromBody] Postagem postagem)
        {
            var ValidarPostagem = await _postagemValidator.ValidateAsync(postagem);

            if (!ValidarPostagem.IsValid) // <-- A exclamação no começo da expressão indica negação
                return StatusCode(StatusCodes.Status400BadRequest, ValidarPostagem);

            var Resposta = await _postagemService.Create(postagem);

            if (Resposta is null)
                return BadRequest("Tema Não Encontrado!");

=======


        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Postagem postagem)
        {
            var validarpostagem = await _postagemValidator.ValidateAsync(postagem);

            if (!validarpostagem.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, validarpostagem);

            var Resposta = await _postagemService.Create(postagem);

            //if para ter um retorno caso seja colocado um tema que não existe
            if (Resposta is null)
            {
                return BadRequest("Tema não encontrado!");
            }
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
            return CreatedAtAction(nameof(GetById), new { id = postagem.Id }, postagem);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] Postagem postagem)
        {
            if (postagem.Id == 0)
<<<<<<< HEAD
                return BadRequest("Id da Postagem é Invalido");

            var validarPostagem = await _postagemValidator.ValidateAsync(postagem);

            if (!validarPostagem.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, validarPostagem);
=======
                return BadRequest("Id da postagem é invalido!!");
            var validarpostagem = await _postagemValidator.ValidateAsync(postagem);


            if (!validarpostagem.IsValid)
            { 
                return StatusCode(StatusCodes.Status400BadRequest, validarpostagem);
            }
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5

            var Resposta = await _postagemService.Update(postagem);

            if (Resposta is null)
<<<<<<< HEAD
                return NotFound("Postagem e/ou Tema Não Encontrados !!");
=======
                return NotFound("Postagem e/o Tema não encontrados !");
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5

            return Ok(Resposta);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
<<<<<<< HEAD
            var BuscaPostagem = await _postagemService.GetById(id);

            if (BuscaPostagem is null)
                return NotFound("Postagem não Encontrada.");

            await _postagemService.Delete(BuscaPostagem);

            return NoContent();
=======
           var BuscaPostagem = await _postagemService.GetById(id);
            
            if (BuscaPostagem is null)
                return NotFound("Postagem não foi encontrada !");

            await _postagemService.Delete(BuscaPostagem);

                return NoContent();

>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
        }
    }
}
