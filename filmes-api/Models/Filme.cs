using System.ComponentModel.DataAnnotations;

namespace filmes_api.Models
{
    public class Filme
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O titulo do filme e obrigatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O genero do filme e obrigatorio")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "A duracao do filme e obrigatoria")]
        [Range(70, 600, ErrorMessage = "A duracao deve ser um numero entre 70 e 600 minutos")]
        public int Duracao { get; set; }
    }
}
