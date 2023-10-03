using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using Newtonsoft.Json;

namespace blogpessoal.Model
{
    public class Tema 
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }
=======

namespace blogpessoal.Model
{
    public class Tema
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto Incremento
        public long Id { get; set; }
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Descricao { get; set; } = string.Empty;

<<<<<<< HEAD
        [InverseProperty("Tema")] // Indica chave estrangeira
        [JsonIgnore]
        public virtual ICollection<Postagem>? Postagem { get; set; }
    }
}
=======
        [InverseProperty("Tema")]
        public virtual ICollection<Postagem>? Postagem { get; set; }
    }
}

>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
