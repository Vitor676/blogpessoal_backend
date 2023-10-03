using blogpessoal.Model;

namespace blogpessoal.Service
{
    public interface ITemaService
    {
        Task<IEnumerable<Tema>> GetAll();
<<<<<<< HEAD

        Task<Tema?> GetById(long id);

        Task<IEnumerable<Tema>> GetByDescricao(string descricao);

        Task<Tema?> Create(Tema temas);

        Task<Tema?> Update(Tema temas);

        Task Delete(Tema temas);
=======
        Task<Tema?> GetById(long id);
        Task<IEnumerable<Tema>> GetByDescricao(string descricao);
        Task<Tema?> Create(Tema Tema);
        Task<Tema?> Update(Tema Tema);
        Task Delete(Tema Tema);
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
    }
}
