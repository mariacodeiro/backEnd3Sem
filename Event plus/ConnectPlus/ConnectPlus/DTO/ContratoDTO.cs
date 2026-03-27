using System.ComponentModel.DataAnnotations;

namespace ConnectPlus.DTO
{
    public class ContatoDTO
    {

        [Required(ErrorMessage = "O nome do contato é obrigatório.")]

        public string Nome { get; set; } = null!;

        [Required(ErrorMessage = "Os dados de contato (E-mail/Telefone) são obrigatórios.")]
        public string? DadosContato { get; set; }

        public IFormFile Imagem { get; set; }

        public Guid Id_tipoContato { get;set; }
    }
}
