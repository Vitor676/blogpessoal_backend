using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
<<<<<<< HEAD
using blogpessoal.Model;

=======
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
namespace blogpessoal.Model
{
    public class Postagem : Auditable
    {
<<<<<<< HEAD
        [Key] // Chave Primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto Incremento
        public long Id { get; set; }

        [Column (TypeName ="varchar")]
=======
        [Key] 
   [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto Incremento
        public long Id { get; set; }

        [Column(TypeName = "varchar")]
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
        [StringLength(100)]
        public string Titulo { get; set; } = string.Empty;

        [Column(TypeName = "varchar")]
<<<<<<< HEAD
        [StringLength(8000)]
        public string Texto { get; set; } = string.Empty;

        public virtual Tema? Tema { get; set; } //Chave estrangeira 
        public virtual User? Usuario { get; set; } //Chave estrangeira 
=======
        [StringLength(100)]
        public string Texto { get; set; } = string.Empty;

        public virtual Tema? Tema { get; set; }
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
    }
}
