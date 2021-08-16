using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Controle.Models
{
    public class Modelos
    {
        [Key]
        public int IDModelo { get; set; }
        [Display(Name = "Descrição")]
        //[Required(ErrorMessage = "A Descrição do Modelo é obrigatória", AllowEmptyStrings = false)]
        [Required]
        [StringLength(100, ErrorMessage = "O campo Descrição pode ter no máximo 100 caracteres")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "A descrição do Modelo é obrigatória", AllowEmptyStrings = false)]

        [Display(Name = "Marca")]
   
        public virtual Marca Marca { get; set; }
   
        public int MarcaId { get; set; }

    }
}