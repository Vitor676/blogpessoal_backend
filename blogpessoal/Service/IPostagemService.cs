using blogpessoal.Model;

namespace blogpessoal.Service
{
    public interface IPostagemService
    {
        Task<IEnumerable<Postagem>> GetAll();
<<<<<<< HEAD

        Task<Postagem?> GetById(long id);

        Task<IEnumerable<Postagem>> GetByTitulo(string titulo);

        Task<Postagem?> Create(Postagem postagem);

        Task<Postagem?> Update(Postagem postagem);

=======
        Task<Postagem?> GetById(long id);
        Task<IEnumerable<Postagem>> GetByTitulo(string titulo);
        Task<Postagem?> Create(Postagem postagem);
        Task <Postagem?> Update(Postagem postagem);
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
        Task Delete(Postagem postagem);
    }
}
