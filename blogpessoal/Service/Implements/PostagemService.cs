using blogpessoal.Data;
using blogpessoal.Model;
using Microsoft.EntityFrameworkCore;

namespace blogpessoal.Service.Implements
{
    public class PostagemService : IPostagemService
    {
        private readonly AppDbContext _context;

        public PostagemService(AppDbContext context)
        {
            _context = context;
        }

<<<<<<< HEAD
        public async Task<IEnumerable<Postagem>> GetAll()
        {
            return await _context.Postagens
                .Include(p => p.Tema)
                .Include(p => p.Usuario)
=======

        public async Task<IEnumerable<Postagem>> GetAll()
        {
            return await _context.Postagens
                .Include(postagem => postagem.Tema)
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
                .ToListAsync();
        }

        public async Task<Postagem?> GetById(long id)
        {
            try
            {
<<<<<<< HEAD
                var Postagem = await _context.Postagens
                    .Include(p => p.Tema)
                    .Include(p => p.Usuario)
                    .FirstAsync(i => i.Id == id);
                return Postagem;
            }
            catch
            {
                return null;
=======

                var Postagem = await _context.Postagens
                    .Include(postagem => postagem.Tema)
                    .FirstAsync(i => i.Id == id);
                return Postagem;

            }
            catch 
            { 
            return null;
            
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
            }
        }

        public async Task<IEnumerable<Postagem>> GetByTitulo(string titulo)
        {
            var Postagem = await _context.Postagens
<<<<<<< HEAD
                .Include(p => p.Tema)
                .Include(p => p.Usuario)
=======
                .Include(postagem => postagem.Tema)
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
                .Where(p => p.Titulo.Contains(titulo))
                .ToListAsync();

            return Postagem;
        }
        public async Task<Postagem?> Create(Postagem postagem)
        {
            if (postagem.Tema is not null)
            {
<<<<<<< HEAD
                var BuscarTema = await _context.Temas.FindAsync(postagem.Tema.Id);

                if (BuscarTema is null)
                    return null;
            }

            postagem.Tema = postagem.Tema is not null ? _context.Temas
                .FirstOrDefault(t => t.Id == postagem.Tema.Id) : null;

            postagem.Usuario = postagem.Usuario is not null 
                ? await _context.Users.FirstOrDefaultAsync(u => u.Id == postagem.Usuario.Id) : null;

            await _context.Postagens.AddAsync(postagem);
            await _context.SaveChangesAsync();

            return postagem;
=======
                var BuscaTema = await _context.Temas.FindAsync(postagem.Tema.Id);

                if (BuscaTema is null)
                {
                    return null;
                }
            }

            postagem.Tema = postagem.Tema is not null ? _context.Temas.FirstOrDefault(t => t.Id == postagem.Tema.Id) : null;

            //adiciona na fila
            await _context.Postagens.AddAsync(postagem);
            //persiste na fila
            await _context.SaveChangesAsync();

            return postagem;

>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
        }

        public async Task<Postagem?> Update(Postagem postagem)
        {
            var PostagemUpdate = await _context.Postagens.FindAsync(postagem.Id);

            if (PostagemUpdate is null)
<<<<<<< HEAD
                return null;

            if (postagem.Tema is not null)
            {
                var BuscarTema = await _context.Temas.FindAsync(postagem.Tema.Id);

                if (BuscarTema is null)
                    return null;
            }

            postagem.Tema = postagem.Tema is not null ? _context.Temas
                .FirstOrDefault(t => t.Id == postagem.Tema.Id) : null;

            postagem.Usuario = postagem.Usuario is not null
                ? await _context.Users.FirstOrDefaultAsync(u => u.Id == postagem.Usuario.Id) : null;
=======
            {
                return null;
            }

            if (postagem.Tema is not null)
            {
                var BuscaTema = await _context.Temas.FindAsync(postagem.Tema.Id);

                if (BuscaTema is null)
                {
                    return null;
                }
            }

            postagem.Tema = postagem.Tema is not null ? _context.Temas.FirstOrDefault(t => t.Id == postagem.Tema.Id) : null;
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5

            _context.Entry(PostagemUpdate).State = EntityState.Detached;
            _context.Entry(postagem).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return postagem;
<<<<<<< HEAD
=======

>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
        }
        public async Task Delete(Postagem postagem)
        {
            _context.Remove(postagem);
            await _context.SaveChangesAsync();

        }
    }
}
