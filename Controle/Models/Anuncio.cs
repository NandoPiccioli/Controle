using System.ComponentModel.DataAnnotations;

namespace Controle.Models
{
    public class Anuncio
    {
        [Key]
        public int IDAnuncio { get; set; }
        
        [Required(ErrorMessage = "A Descrição do anuncio é obrigatória", AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage = "O campo Descrição pode ter no máximo 100 caracteres")]
        public string Descricao { get; set; }
        [Required]
        public Veiculo Veiculo { get; set; }
        public int VeiculoId { get; set; }
    }
}