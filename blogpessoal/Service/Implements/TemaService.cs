using blogpessoal.Data;
using blogpessoal.Model;
using Microsoft.EntityFrameworkCore;

namespace blogpessoal.Service.Implements
{
    public class TemaService : ITemaService
    {
        private readonly AppDbContext _context;

        public TemaService(AppDbContext context)
        {
            _context = context;
        }

<<<<<<< HEAD
        public async Task<IEnumerable<Tema>> GetAll()
        {
            return await _context.Temas
                        .Include(t => t.Postagem)
                        .ToListAsync();
=======

        public async Task<IEnumerable<Tema>> GetAll()
        {
            return await _context.Temas
                .Include(t => t.Postagem)
                .ToListAsync();
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
        }

        public async Task<Tema?> GetById(long id)
        {
            try
            {
<<<<<<< HEAD
                var Tema = await _context.Temas
                                .Include(t => t.Postagem)
                                .FirstAsync(i => i.Id == id);

                return Tema;
=======

                var Tema = await _context.Temas
                    .Include(t => t.Postagem)
                    .FirstAsync(i => i.Id == id);
                return Tema;

>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
            }
            catch
            {
                return null;
<<<<<<< HEAD
=======

>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
            }
        }

        public async Task<IEnumerable<Tema>> GetByDescricao(string descricao)
        {
            var Tema = await _context.Temas
<<<<<<< HEAD
                            .Include(t => t.Postagem)
                            .Where(t => t.Descricao.Contains(descricao))
                            .ToListAsync();
=======
                .Include(t => t.Postagem)
                .Where(d => d.Descricao.Contains(descricao))
                .ToListAsync();

            return Tema;
        }
        public async Task<Tema?> Create(Tema Tema)
        {
            await _context.Temas.AddAsync(Tema);
            await _context.SaveChangesAsync();
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5

            return Tema;
        }

<<<<<<< HEAD
        public async Task<Tema?> Create(Tema temas)
        {
            _context.Temas.Add(temas);
            await _context.SaveChangesAsync();

            return temas;
        }

        public async Task<Tema?> Update(Tema temas)
        {
            var TemaUpdate = await _context.Temas.FindAsync(temas.Id);
=======
        public async Task<Tema?> Update(Tema Tema)
        {
            var TemaUpdate = await _context.Temas.FindAsync(Tema.Id);
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5

            if (TemaUpdate is null)
                return null;

            _context.Entry(TemaUpdate).State = EntityState.Detached;
<<<<<<< HEAD
            _context.Entry(temas).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return temas;
        }
        public async Task Delete(Tema temas)
        {
            _context.Remove(temas);
=======
            _context.Entry(Tema).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Tema;
        }
        public async Task Delete(Tema Tema)
        {
            _context.Remove(Tema);
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
            await _context.SaveChangesAsync();

        }
    }
}
