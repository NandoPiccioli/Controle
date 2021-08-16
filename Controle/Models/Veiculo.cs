using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Controle.Models
{
    public class Veiculo
    {
        [Key]
        public int IDVeiculo { get; set; }
        
        [Required(ErrorMessage = "O Ano do veículo obrigatório", AllowEmptyStrings = false)]
        [StringLength(4, ErrorMessage = "O campo ano pode ter no máximo 4 caracteres")]
        [Range(0, int.MaxValue, ErrorMessage = "Por favor insira um ano válido")]
        public string Ano { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Por favor insira um valor válido")]
        [Display(Name = "Valor de Compra")]
        public double ValorDeCompra { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Por favor insira um valor válido")]
        [Display(Name = "Valor de Venda")]
        public double ValorDeVenda { get; set; }

        [Required(ErrorMessage = "A Cor do veículo obrigatória", AllowEmptyStrings = false)]
        public string Cor { get; set; }
        [Display(Name = "Combustível")]
        [Required(ErrorMessage = "O tipo de combustível é obrigatório", AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage = "O campo tipo de combustível pode ter no máximo 100 caracteres")]
        public string TipoCombustivel { get; set; }
        [Display(Name = "Data da Venda")]
        public DateTime DataDeVenda { get; set; }
        [Required]
        [Display(Name = "Modelo")]
        public int ModeloId { get; set; }
        public virtual Modelos Modelo { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Imagem")]
        public byte[] ImageUpload { get; set; }
       
        
    }
}