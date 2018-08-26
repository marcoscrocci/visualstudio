using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiroWeb.Models
{
    public class Conta: Entidade
    {
        //[Required(ErrorMessage = "O campo \"{0}\" é obrigatório")]
        //[StringLength(50, ErrorMessage = "O tamanho máximo para o campo \"{0}\" é de 50 caracteres")]
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]        
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        //[Required(ErrorMessage = "O campo \"{0}\" é obrigatório")]
        //[Display(Name = "Saldo Inicial R$")]
        [Display(Name = "Saldo Inicial")]
        [Required]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public double SaldoInicial { get; set; }

        //[Required(ErrorMessage = "O campo \"{0}\" é obrigatório")]
        //[Display(Name = "Tipo de Conta")]
        [Required]
        [Display(Name = "Tipo de Conta")]
        public int TipoContaId { get; set; }

        //[StringLength(200, ErrorMessage = "O tamanho máximo para o campo \"{0}\" é de 200 caracteres")]
        //[Display(Name = "Observações")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        [Display(Name = "Tipo de Conta")]
        public virtual TipoConta TipoContaInfo { get; set; }

    }
}
