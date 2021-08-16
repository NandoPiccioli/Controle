using Controle.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Controle.Models
{
    public class Marca
    {
        [Key]
        [Display(Name = "Código")]
        public int IDMarca { get; set; }
        
        [Display(Name ="Descrição")]
        [Required(ErrorMessage = "O Nome da marca é obrigatório", AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage = "O campo Descrição pode ter no máximo 100 caracteres")]
        public string Descricao { get; set; }


      

    }
}